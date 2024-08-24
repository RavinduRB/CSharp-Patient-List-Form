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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            
        }


        // Help: Login Page
        private void LoignHelpLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            HelpLoginForm helpLoginForm = new HelpLoginForm();
            helpLoginForm.ShowDialog();

        }

        //Help: Home Page
        private void homeHelpLbl_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpHomeForm helpHomeForm = new HelpHomeForm();
            helpHomeForm.ShowDialog();
        }

        //Help: Inventory Management Page
        private void inventoryManageLbl_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpInventoryForm helpInventoryForm = new HelpInventoryForm();  
            helpInventoryForm.ShowDialog();
        }

        //Help: Patient Management Page
        private void patientManageLbl_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpPatientForm helpPatientForm = new HelpPatientForm();    
            helpPatientForm.ShowDialog();
        }

        //Help: user Management Page
        private void userManageLbl_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpUserForm helpUserForm = new HelpUserForm();
            helpUserForm.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
