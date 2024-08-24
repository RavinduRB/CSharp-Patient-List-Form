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
    public partial class patientForm : Form
    {
        List<patientItem> patientItems = new List<patientItem>();
        int selectedItemId = -1;

        public patientForm()
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

            patientDataGridView.Columns.Add(actionColumn);
            patientDataGridView.Columns.Add(deleteColumn);

            //Event handler 
            patientDataGridView.CellClick -= patientDataGridView_CellContentClick;

            
        }

        
        private void patientForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        // Create Table 
        public void CreateTableDate()
        {
            foreach (var item in patientItems)
            {
                int rowIndex = patientDataGridView.Rows.Add(item.Id, item.Name, item.Illness, item.contactNumber);
                DataGridViewRow row = patientDataGridView.Rows[rowIndex];
                row.Cells["Edit"].Value = "Edit";
                row.Cells["Delete"].Value = "Delete";

            }
        }



        public void LoadForm()
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            string query = $"SELECT P.Id AS Id, patient_Name AS Name, patient_Illness AS Illness, patient_contactNumber AS ContactNumber FROM patient AS P ";

            try
            {
                patientItems.Clear();
                patientDataGridView.Rows.Clear();

                using (con)
                {
                    con.Open();

                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        var resultToken = cmd.ExecuteReader();

                        while (resultToken.Read())
                        {
                            patientItems.Add(new patientItem()
                            {
                                Id = Convert.ToInt32(resultToken["Id"].ToString()),
                                Name = resultToken["Name"].ToString(),                                
                                Illness = resultToken["Illness"].ToString(),
                                contactNumber = resultToken["ContactNumber"].ToString()
                            });

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            CreateTableDateinPatient();
        }

        // Create Table 
        public void CreateTableDateinPatient()
        {
            foreach (var item in patientItems)
            {
                int rowIndex = patientDataGridView.Rows.Add(item.Id, item.Name, item.Illness, item.contactNumber);
                DataGridViewRow row = patientDataGridView.Rows[rowIndex];
                row.Cells["Edit"].Value = "Edit";
                row.Cells["Delete"].Value = "Delete";

            }
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // calling Edit Btn  Function
            if (e.ColumnIndex == patientDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                editItem((int)patientDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
            // calling Delete Btn Function
            else if (e.ColumnIndex == patientDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                delete((int)patientDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void editItem(int id = 0)
        {
            selectedItemId = id;
            patientItem selectedItem = patientItems.Find(x => x.Id == id);
            EditPatientNameTxtBox.Text = selectedItem.Name;
            patientIllnessTxtBox.Text = selectedItem.Illness;
            patientContactnumberTxt.Text = selectedItem.contactNumber;
        }



        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            try
            {
                using (con)
                {

                    string itemName = EditPatientNameTxtBox.Text;
                    string itemIllness = patientIllnessTxtBox.Text;
                    string itemContactNumber = patientContactnumberTxt.Text;
                    
                    int itemId = selectedItemId;

                    // Update/ Edit SQL Query
                    string upDateQuery = $"UPDATE patient SET patient_Name = '{itemName}', patient_Illness = '{itemIllness}', patient_contactNumber = '{itemContactNumber}'";

                    if (itemName == "" && itemIllness == "" && itemContactNumber == "")
                    {
                        MessageBox.Show("Please Fill All Values To Update The User");
                    }
                    else if (itemName == "")
                    {
                        MessageBox.Show("Enter User Name to Update The user");
                    }
                    else if (itemIllness == "")
                    {
                        MessageBox.Show("Enter User Illness to Update The User");
                    }
                    else if (itemContactNumber == "")
                    {
                        MessageBox.Show("Enter User Contact Number to Update The User");
                    }
                    else
                    {
                        // Execute Query
                        SqlCommand command = new SqlCommand(upDateQuery, con);

                        con.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Update successful");

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
            LoadForm();
            clearFilds();
        }


        private void delete(int Id = 0)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            var confirm = MessageBox.Show("Are you sure you want to delete this Patient?", "Confirm Delete", MessageBoxButtons.YesNo);

            try 
            {
                using( con )
                {
                    con.Open();
                    if (confirm == DialogResult.Yes)
                    {
                        // Sql Query to delete item 
                        string deleteQuery = $"DELETE FROM patient WHERE Id = {Id}";

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
            LoadForm();

        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFilds();
        }

        //Clear The Text Box
        public void clearFilds()
        {
            try
            {
                // Get Values from text boxes
                EditPatientNameTxtBox.Clear();
                patientIllnessTxtBox.Clear();
                patientContactnumberTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            addPatientForm AddPatientForm = new addPatientForm();
            AddPatientForm.ShowDialog();
        }
    }
}
