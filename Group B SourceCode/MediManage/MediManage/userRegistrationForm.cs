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
    public partial class userRegistrationForm : Form
    {
        public userRegistrationForm()
        {
            InitializeComponent();

           
        }

        private void userRegistrationForm_Load(object sender, EventArgs e)
        {
           
        }

        

        private void Regbtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            try
            {
                ///Sajana Ranasinghe ------> Code with errors
                //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sajan\\OneDrive\\Documents\\userregidb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
                //con.Open();
                //String insertQuery = "INSERT INTO User VALUES(@Name,@userName,@userPassword,@usercontactNumber,@userEmail)";
                //SqlCommand cmd = new SqlCommand(insertQuery, con);
                //cmd.Parameters.AddWithValue("@Name", Nametxt.Text);
                //cmd.Parameters.AddWithValue("@userName", Usernametxt.Text);
                //cmd.Parameters.AddWithValue("@userPassword", Userpasstxt.Text);
                //cmd.Parameters.AddWithValue("usercontactNumber", Usercnumbertxt.Text);
                //cmd.Parameters.AddWithValue("userEmail", Useremailtxt.Text);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Registered Succesefully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ///Duhudu Wijesinghe ------> Bug fixed and modified code
                ///

                using (con)
                {
                    con.Open();
                    // Get Values from text boxes
                    string userName = Usernametxt.Text;
                    string userPassWord = Userpasstxt.Text;
                    string userContactNumber = Usercnumbertxt.Text;
                    string userEmail = Useremailtxt.Text;

                    // Check if the username already exists
                    if (CheckUserName(con, userName))
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }

                    // Check if all text fields are filled 
                    if (userName == "")
                    {
                        MessageBox.Show("Please Enter User Name to Register A User");
                        return;
                    }
                    if (userPassWord == "")
                    {
                        MessageBox.Show("Please Enter User PassWord to Register A User");
                        return;
                    }
                    if (userContactNumber == "")
                    {
                        MessageBox.Show("Please Enter User Contact Number to Register A User");
                        return;
                    }
                    if (userEmail == "")
                    {
                        MessageBox.Show("Please Enter User Email to Register A User");
                        return;
                    }

                    //  insert query
                    string insertQuery = $"INSERT INTO UserDetails (user_Name, user_PassWord, user_contactNumber, user_Email) " +
                                         $"VALUES  ('{Usernametxt.Text}', '{Userpasstxt.Text}', '{Usercnumbertxt.Text}','{Useremailtxt.Text}')";

                    //Check if all text fields are filled 
                    if (userName == "" && userPassWord == "" && userContactNumber == "" && userEmail == "")
                    {
                        MessageBox.Show("Please Fill All Values To Register An User");
                    }
                    else if (userName == "")
                    {
                        MessageBox.Show("Please Enter User Name to Register An User");
                    }
                    else if (userPassWord == "")
                    {
                        MessageBox.Show("Please Enter User PassWord to Register An User");
                    }
                    else if (userContactNumber == "")
                    {
                        MessageBox.Show("Please Enter User Contact Number to Register An User");
                    }
                    else if (userEmail == "")
                    {
                        MessageBox.Show("Please Enter User Email to Register An User");
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

        // Method to check if the username already exists
        private bool CheckUserName(SqlConnection con, string userName)
        {
            string checkQuery = $"SELECT COUNT(1) FROM UserDetails WHERE user_Name = '{userName}'";
            using (SqlCommand cmdCheck = new SqlCommand(checkQuery, con))
            {
                int count = (int)cmdCheck.ExecuteScalar();
                return count > 0;
            }
        }

        //ClearBtn
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //Clear Method
        private void  ClearData()
        {
            Usernametxt.Clear();
            Userpasstxt.Clear();
            Usercnumbertxt.Clear();
            Useremailtxt.Clear();
        }

        //BackBtn
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            userForm userForm = new userForm();
            userForm.ShowDialog();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
