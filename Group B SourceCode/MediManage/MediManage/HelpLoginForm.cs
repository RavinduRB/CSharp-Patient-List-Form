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
    public partial class HelpLoginForm : Form
    {
        public HelpLoginForm()
        {
            InitializeComponent();
            
        }

        


        private void HelpLoginForm_Load(object sender, EventArgs e)
        {

        }

        //BackBtn
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void loginHomePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
