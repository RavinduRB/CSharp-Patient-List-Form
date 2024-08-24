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

namespace MediManage
{
    public static class UserSession
    {
        // This static property will hold the logged-in username
        public static string LoggedUserName { get; set; }
    }

    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");

            string userName = userNameTxt.Text;
            string userPassWord = passWordTxt.Text;
            
            using(con)
            {
                try
                {
                    using (con)
                    {
                        con.Open();
                        // SQL query to check if username and password match
                        string query = $"SELECT COUNT(1) FROM UserDetails WHERE user_Name = '{userName}' AND user_PassWord = '{userPassWord}'";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                //MessageBox.Show("Login successful!");

                                // Store the logged-in username in the UserSession class
                                UserSession.LoggedUserName = userName;

                                this.Hide();

                                HomeForm homeForm = new HomeForm();
                                homeForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.");
                            }
                        }

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
