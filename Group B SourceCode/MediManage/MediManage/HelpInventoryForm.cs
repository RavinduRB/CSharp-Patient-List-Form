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
    public partial class HelpInventoryForm : Form
    {
        public HelpInventoryForm()
        {
            InitializeComponent();

            
        }

        

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void loginHelpLbl_Click(object sender, EventArgs e)
        {

        }

        private void HelpInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void loginHomePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
