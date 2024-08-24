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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediManage
{
    public partial class userForm : Form
    {
        List<userItems> userItems = new List<userItems>();
        int selectedItemId = -1;


        public userForm()
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

            userDataGridView.Columns.Add(actionColumn);
            userDataGridView.Columns.Add(deleteColumn);

            //Event handler 
            userDataGridView.CellClick -= userDataGridView_CellContentClick;



           
        }
        private void userForm_Load(object sender, EventArgs e)
        {
            LoadForms();
        }

        //Create Table
        public void CreateTableDate()
        {
            foreach (var item in userItems)
            {

                int rowIndex = userDataGridView.Rows.Add(item.Id, item.Name, item.PassWord, item.contactnumber, item.Email);
                DataGridViewRow row = userDataGridView.Rows[rowIndex];
                row.Cells["Edit"].Value = "Edit";
                row.Cells["Delete"].Value = "Delete";

            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // calling Edit Btn  Function
            if (e.ColumnIndex == userDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                editItem((int)userDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
            // calling Delete Btn Function
            else if (e.ColumnIndex == userDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                delete((int)userDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }



        // Function To bring data from the db to the table

        public void LoadForms ()
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            //Select Query
            string query = $"SELECT D.Id AS Id, user_Name AS Name, user_PassWord AS PassWord, user_contactNumber AS Contact, user_Email AS Email FROM UserDetails AS D ";

            try
            {
                userItems.Clear();
                userDataGridView.Rows.Clear();


                using (con)
                {
                    con.Open();

                    using(SqlCommand cmdToken = new SqlCommand(query, con))
                    {
                        cmdToken.CommandType = CommandType.Text;

                        var resultToken = cmdToken.ExecuteReader();

                        while (resultToken.Read()) 
                        {
                            userItems.Add(new userItems() 
                            {
                                Id = Convert.ToInt32(resultToken["Id"].ToString()),
                                Name = resultToken["Name"].ToString(),
                                PassWord = resultToken["Password"].ToString(),
                                contactnumber = resultToken["Contact"].ToString(),
                                Email = resultToken["email"].ToString(),

                            });     
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            CreateTableDate();
        }



        // Edit user Method
        private void editItem(int id = 0)
        {
          
            selectedItemId = id;
            userItems selectedItem = userItems.Find(x => x.Id == id);
            EditUserNameTxtBox.Text = selectedItem.Name;
            userPassWordTxtBox.Text = selectedItem.PassWord;
            EditUsercontactNumberTxtBox.Text = selectedItem.contactnumber;
            userEmialTxtBox.Text = selectedItem.Email;
        }

        // Delete user Method 

        private void delete(int id = 0)
        {
            //Sql Connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            try
            {
                using (con)
                {

                    con.Open();

                    // Confirm
                    var confirm = MessageBox.Show("Are you sure you want to delete this User?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        // Sql Query to delete item 
                        string deleteQuery = $"DELETE FROM userDetails WHERE Id = {id}";

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
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadForms();
        }



       

        

        //Add User Btn
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            userRegistrationForm userRegistrationForm = new userRegistrationForm();
            userRegistrationForm.ShowDialog();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userClearBtn_Click(object sender, EventArgs e)
        {
            clearFilds();
        }

        //Clear The Text Box
        public void clearFilds()
        {
            try
            {
                // Get Values from text boxes
                EditUserNameTxtBox.Clear();
                userPassWordTxtBox.Clear();
                EditUsercontactNumberTxtBox.Clear();
                userEmialTxtBox.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // update Btn
        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            try
            {
                using (con)
                {
                    string userName = EditUserNameTxtBox.Text;
                    string userPassWord = userPassWordTxtBox.Text;
                    string userContactNumber = EditUsercontactNumberTxtBox.Text;
                    string userEmail = userEmialTxtBox.Text;
                    int itemId = selectedItemId;

                    // Update SQL Query
                    string updateQuery = $"UPDATE userDetails SET user_Name = '{userName}', user_PassWord = '{userPassWord}', user_contactNumber = '{userContactNumber}', user_Email = '{userEmail}' WHERE Id = {itemId}";

                    if (userName == "" && userPassWord == "" && userContactNumber == "" && userEmail == "")
                    {
                        MessageBox.Show("Please Fill All Values To Update The User");
                    }
                    else if (userName == "")
                    {
                        MessageBox.Show("Enter User Name to Update The User");
                    }
                    else if (userPassWord == "")
                    {
                        MessageBox.Show("Enter User PassWord to Update The User");
                    }
                    else if (userContactNumber == "")
                    {
                        MessageBox.Show("Enter User Contact Number to Update The User");
                    }
                    else if (userEmail == "")
                    {
                        MessageBox.Show("Enter User Email To Update The User");
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
            LoadForms();
            clearFilds();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
