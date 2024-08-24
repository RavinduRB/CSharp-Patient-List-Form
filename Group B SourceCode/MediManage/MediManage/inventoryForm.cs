using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace MediManage
{

    public partial class inventoryForm : Form
    {

        // Creating SQL Connection

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

        // Connecting inventoryItems
        List<inventoryItems> inventoryItems = new List<inventoryItems>();
        int selectedItemId = -1;
        List<Category> CategoryItems = new List<Category>();
        private bool isInitialized = false;

        public inventoryForm()
        {
            InitializeComponent();
            

            // Create new specific for buttons in a DataGridView
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
            actionColumn.Name = "Edit";
            actionColumn.HeaderText = "Edit";
            actionColumn.Text = "Edit";
            actionColumn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            inventoryDataGridView.Columns.Add(actionColumn);
            inventoryDataGridView.Columns.Add(deleteColumn);

            //Event handler 
            inventoryDataGridView.CellClick -= inventoryDataGridView_CellContentClick;

            

        }

       

        private void inventoryForm_Load(object sender, EventArgs e)
        {
            LoadRecords(-1);
            SetCategories();
            
            if (selectedItemId == -1)
            {
                insertBtn.Visible = true;
                updateBtn.Visible = false;
            }
            
        }

        // Create Table 
        public void CreateTableDate()
        {
            foreach (var item in inventoryItems)
            {
                int rowIndex = inventoryDataGridView.Rows.Add(item.Id, item.Name, item.Quantity, item.Category.Name);
                DataGridViewRow row = inventoryDataGridView.Rows[rowIndex];
                row.Cells["Edit"].Value = "Edit";
                row.Cells["Delete"].Value = "Delete";

            }
        }


        // Function To bring data from the db to the table
        public void LoadRecords(int catId)
        {
            //filter secleter
            string whereCondition = "";
            if (catId != -1) {
                whereCondition = "WHERE I.FK_category_id = " + catId.ToString();
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            //query to get items
            string query = $"SELECT I.Id AS Id, item_Name AS Name, item_Quantity AS Quantity, created_date AS CreatedDate, item_description AS Description,C.Id AS CatId,C.code AS Code,C.name AS CatName FROM inventory AS I INNER JOIN category AS C ON C.Id = I.FK_category_id " + whereCondition;
            try
            {
                inventoryItems.Clear();
                inventoryDataGridView.Rows.Clear();

                // Use the "con" to connect to db
                using (con)
                {
                    // open db
                    con.Open();

                    // Check the Token and create a instance of the SqlCommand class.
                    using (SqlCommand  cmdToken = new SqlCommand(query, con) )
                    {
                        cmdToken.CommandType = CommandType.Text;

                        // Executing the sql SP command
                        var resultToken = cmdToken.ExecuteReader();
                        while (resultToken.Read())
                        {
                            inventoryItems.Add(new inventoryItems()
                            {
                                Id = Convert.ToInt32(resultToken["Id"].ToString()),
                                Name = resultToken["Name"].ToString(),
                                Category = new Category()
                                {
                                    Id = Convert.ToInt32(resultToken["CatId"].ToString()),
                                    Name = resultToken["CatName"].ToString(),
                                    Code = resultToken["Code"].ToString(),
                                },
                                Created = Convert.ToDateTime(resultToken["CreatedDate"].ToString()),
                                Description = resultToken["Description"].ToString(),
                                Quantity = resultToken["Quantity"].ToString()
                            });

                        }

                    }
                    // Closing the Connection
                    con.Close();
                }
            } catch (Exception ex)
            {
                throw new Exception("Error in LordRecords ! :" + ex);
            }
           
           

            CreateTableDate();

        }

        // Set Categories To ComboBox
        public void SetCategories() {
            List<Category> categories = GetCategories();
            catComboBox1.DataSource = new List<Category>(categories);
            catComboBox1.DisplayMember = "Name";
            catComboBox1.ValueMember = "Id";

            List<Category> tableFiler = new List<Category>(categories);
            tableFiler.Insert(0, new Category() { Id = -1, Code = "ALL", Name = "All" });
            
            catComboBox2.DataSource = new List<Category>(tableFiler);
            catComboBox2.DisplayMember = "Name";
            catComboBox2.ValueMember = "Id";
            
            isInitialized = true;

        }
        
        //Get categories from db
        public List<Category> GetCategories()
        {
            string query = "SELECT * FROM category";
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            List<Category> catLocal = new List<Category>();


            try
            {
                using (con)
                {

                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Category category = new Category
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["name"].ToString(),
                            Code = reader["code"].ToString()
                        };
                        catLocal.Add(category);
                    }

                    reader.Close();
                    // Closing the Connection
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return catLocal;
        }


        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // calling Edit Btn  Function
            if (e.ColumnIndex == inventoryDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
               
                editItem((int)inventoryDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            } 
            // calling Delete Btn Function
            else if (e.ColumnIndex == inventoryDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                delete((int)inventoryDataGridView.Rows[e.RowIndex].Cells["Id"].Value); 
            }
            
           
        }

        // Edit Item Method
        private void editItem(int id = 0)
        {
            insertBtn.Visible = false;
            updateBtn.Visible = true;
            selectedItemId = id;
            inventoryItems selectedItem = inventoryItems.Find(x => x.Id == id);
            nameTxtBox.Text = selectedItem.Name;
            quantityTxtBox.Text = selectedItem.Quantity;
            descriptionTxtBox.Text = selectedItem.Description;
            catComboBox1.SelectedValue = selectedItem.Category.Id;

            
        }

        // Delete Item Method
        private void delete(int id = 0)
        {
            //Sql connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            try
            {
                using (con)
                {
                    // Open Connection  
                    con.Open();

                    

                    // Confirm
                    var confirm = MessageBox.Show("Are you sure you want to delete this item?","Confirm Delete", MessageBoxButtons.YesNo);
                    

                    if(confirm == DialogResult.Yes)
                    {
                        // Sql Query to delete item 
                        string deleteQuery = $"DELETE FROM inventory WHERE Id = {id}";

                        // Execute Delete Query
                        using (SqlCommand cmdDeleteItem = new SqlCommand(deleteQuery, con))
                        {
                            // Execute the Delete query
                            int rowsAffected = cmdDeleteItem.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item Deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Deletion  failed.");
                            }
                        }
                        // Close Connection 
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadRecords(-1);
        }

        // Method to connect the comboBox to db (Method Extraction)
        private void connectComboBoxToDB(ComboBox comboBox, string query)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            comboBox.Items.Clear();

            try
            {
                using (con)
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            comboBox.ValueMember = "code";
                            comboBox.DataSource = dt;
                            comboBox.SelectedIndex = 0;
                        }
                    }
                    // Closing the Connection
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

      

        // Insert New Item Method
        private void insertBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            try
            {
                using (con)
                {
                    con.Open();

                    // Get Values from text boxes
                    string itemName = nameTxtBox.Text;
                    string itemQuantity = quantityTxtBox.Text;
                    string itemDescription = descriptionTxtBox.Text;
                    int selectedCatId = (int)catComboBox1.SelectedValue;

                    
                        //  insert query
                        string insertQuery = $"INSERT INTO inventory (item_Name, item_Quantity, FK_category_id, item_description) " +
                                             $"VALUES ('{itemName}', '{itemQuantity}', {selectedCatId}, '{itemDescription}')";

                    if(itemName == "" &&  itemQuantity == "" && itemDescription == "" &&  selectedCatId == -1)
                    {
                        MessageBox.Show("Please Fill All Values To Insert An Item Into the ");
                    }
                    else if(itemName == "")
                    {
                        MessageBox.Show("Please Enter Item Name to ");
                    }


                        // Excute Insert Query
                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                        {
                            // Execute the insert query
                            int rowsAffected = cmdInsert.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Insertion failed.");
                            }
                        }
                   
                     // Closing the Connection
                    con.Close();
                }
            }

           

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadRecords(-1);
            clearFilds();


        }

        // Cancle Btn Method 
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
         clearFilds();
        }

        //Clear The Text Box
        public void clearFilds()
        {
            try
            {
                // Get Values from text boxes
                nameTxtBox.Clear();
                quantityTxtBox.Clear();
                descriptionTxtBox.Clear();
                catComboBox1.SelectedIndex = -1;

                insertBtn.Visible = true;
                updateBtn.Visible = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Update  Method 
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            try
            {
                using (con)
                {

                    string itemName = nameTxtBox.Text;
                    string itemQuantity = quantityTxtBox.Text;
                    string itemDescription = descriptionTxtBox.Text;
                    int selectedCatId = (int)catComboBox1.SelectedValue;
                    int itemId = selectedItemId;

                    // Update/ Edit SQL Query
                    string updateQuery = $"UPDATE inventory SET item_Name = '{itemName}', item_Quantity = '{itemQuantity}', FK_category_id = {selectedCatId}, item_description = '{itemDescription}' WHERE Id = {itemId}";

                    if(itemName == "" && itemQuantity == "" && itemDescription == "")
                    {
                        MessageBox.Show("Please Fill All Values To Update The Item");
                    }
                    else if(itemName == "")
                    {
                        MessageBox.Show("Enter Item Name to Update The Item");
                    }
                    else if (itemQuantity == "")
                    {
                        MessageBox.Show("Enter Item Quantity to Update The Item");
                    }
                    else if (itemDescription == "")
                    {
                        MessageBox.Show("Enter Item Description to Update The Item");
                    }
                    else
                    {
                        // Execute Query
                        SqlCommand command = new SqlCommand(updateQuery, con);

                        con.Open();
                        command.ExecuteNonQuery();

                    }

                    // Closing the Connection
                    con.Close();
                    selectedItemId = -1;
                    
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadRecords(-1);
            clearFilds();

        }

        private void catComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the ComboBox has been fully initialized
            if (!isInitialized)
            {

                return; // Exit if the ComboBox is still being initialized
            }
           
            LoadRecords((int)catComboBox2.SelectedValue);
            
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
