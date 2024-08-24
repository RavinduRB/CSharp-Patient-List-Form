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
    public partial class LoadingForm : Form
    {
        private Timer timer; // Timer to update the progress bar

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            // Initialize progress bar settings
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Blocks;

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 50; // Adjust the interval as needed
            timer.Tick += new EventHandler(Timer_Tick); // Attach the Tick event handler
            timer.Start(); // Start the timer
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            // The progress bar click event is not needed to start the progress bar animation
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                
                progressBar.PerformStep();
            }
            else
            {
                // Stop the timer when the progress bar is full
                timer.Stop();

                // Hide the loading form
                Hide();

                // Open the login form
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += LoginForm_FormClosed;
                loginForm.Show();

                // Hide the loading form
                Hide();
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the loading form after the login form is closed
            Close();
        }
    }
}
