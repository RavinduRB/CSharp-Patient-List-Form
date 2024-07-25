using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Step 01
// Importing the library
using System.Data.SqlClient;
//
using System.Data.Sql;

namespace PatientListForm
{
    public partial class PatientList : Form
    {
        //Step 02
        //Creating the conectionusing the connection string 
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\ASUS\source\repos\PatientListForm\PatientListForm\PatientListDB.mdf';Integrated Security=True");
        public PatientList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            if (txtPatientName.Text == null)
            {
                dsp.Text = "Enter patient Name"; 
            }
            else if (txtPatientIllness.Text == null)
            {
                dsp.Text = "Enter patient Illness";
            }
            else if (txtContactNumber.Text == null)
            {
                dsp.Text = "Enter patient Contact Number";
            }
            else if (gen.Text == null)
            {
                dsp.Text = "Enter patient Gender";
            }

                string PatientName = txtPatientName.Text;
                string PatientIllness = txtPatientIllness.Text;
                string ContactNumber = txtContactNumber.Text;
                string Gender = gen.Text;
            
            //Step 03 
            // Creating theSQL Query
            string query01 = $"INSERT INTO patient(patient_Name,patient_Illness,patient_contactNumber,patient_gender) VALUES ('{PatientName}','{PatientIllness}','{ContactNumber}','{Gender}')";

            try
            {

                //Step 04
                // Creating the SQL Command
                SqlCommand cmd1 = new SqlCommand(query01, con1);

                //Step 05
                // Opening the Connection
                con1.Open();

                //Step 06
                // Executing the Commands
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");

                //Step 07
                //Close the connection to the DB
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientListDBDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientListDBDataSet.patient);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "";
            txtPatientIllness.Text = "";
            txtContactNumber.Text = "";
            gen.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form2 SinglePatientList = new Form2();
           //SinglePatientList.Show();
           //this.Hide();
        }
    }
}
