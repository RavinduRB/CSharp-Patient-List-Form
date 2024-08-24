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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediManage
{
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
            //FullScreen Method call
           
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            // Get the logged-in username from the UserSession class
            string loggedUserName = UserSession.LoggedUserName;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Software Engineer\Year 1\senester 2\Object Oriented Programming with C#\Group B SourceCode\MediManage\MediManage\inventory_db.mdf"";Integrated Security=True");
            try
            {
                con.Open();
                // SQL query to get user details
                string query = $"SELECT user_Name, user_PassWord, user_contactNumber, user_Email FROM UserDetails WHERE user_Name = '{loggedUserName}'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Store the retrieved values in labels
                            profileUserNameLbl.Text = reader["user_Name"].ToString();
                            profilePassWordLbl.Text = reader["user_PassWord"].ToString();
                            profileContactNumLbl.Text = reader["user_contactNumber"].ToString();
                            profileEmailLbl.Text = reader["user_Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
