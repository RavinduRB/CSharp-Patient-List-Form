using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediManage
{
    public partial class addPatientForm : Form
    {
        public addPatientForm()
        {
            InitializeComponent();
            
        }

        

        private void addBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            try
            {
                using (con)
                {
                    con.Open();

                    string patientName = enterPatientNameTxtBox.Text;
                    string patientIllness = enterPatientIllnessTxtBox.Text;
                    string patientContactNumber = enterPatientContactnumberTxt.Text;

                    //  insert query
                    string insertQuery = $"INSERT INTO patient (patient_Name, patient_Illness, patient_contactNumber) " +
                                         $"VALUES ('{enterPatientNameTxtBox.Text}', '{enterPatientIllnessTxtBox.Text}', '{enterPatientContactnumberTxt.Text}')";               
                    
                    //Check if all text fields are filled 
                    if (patientName == "" && patientIllness == "" && patientContactNumber == "" )
                    {
                        MessageBox.Show("Please Fill All Values To Register An User");
                    }
                    else if (patientName == "")
                    {
                        MessageBox.Show("Please Enter User Name to Register An User");
                    }
                    else if (patientIllness == "")
                    {
                        MessageBox.Show("Please Enter User PassWord to Register An User");
                    }
                    else if (patientContactNumber == "")
                    {
                        MessageBox.Show("Please Enter User Contact Number to Register An User");
                    }                 
                    else
                    {
                        // Excute Insert Query
                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                        {
                            // Execute the insert query
                            int rowsAffected = cmdInsert.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Insertion failed.");
                            }
                            ClearData();
                        }
                    }

                    // Closing the Connection
                    con.Close();
                }

            
            }
            catch (Exception ex)
            {
                throw new Exception("Error in LordRecords ! :" + ex);
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            patientForm patientForm = new patientForm();
            patientForm.Show();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            enterPatientNameTxtBox.Text = "";
            enterPatientIllnessTxtBox.Text = "";
            enterPatientContactnumberTxt.Text = "";
        }
    }
}
