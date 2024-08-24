using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediManage
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            //FullScreen Method call
           
        }

       
        
        // hide Home Form and show patient Form
        private void patientPicBox_Click(object sender, EventArgs e)
        {

            this.Hide();

            patientForm patientForm = new patientForm();
            patientForm.Show();

        }
        // hide Home Form and show user  Form
        private void userPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();

            userForm userForm = new userForm();
            userForm.Show();
        }

        // hide Home Form and show Help Form
        private void helpPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm helpForm = new HelpForm(); 
            helpForm.Show();
        }
        // hide Home Form and show inventory Form
        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            profileForm profileForm = new profileForm();
            profileForm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            inventoryForm inventoryForm = new inventoryForm();
            inventoryForm.Show();
        }
    }
    
}
