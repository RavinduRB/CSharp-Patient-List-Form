namespace MediManage
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeGradientPanel = new MediManage.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryPicBox = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Label();
            this.patientHomeLbl = new System.Windows.Forms.Label();
            this.userRegHomeLbl = new System.Windows.Forms.Label();
            this.helpHomeLbl = new System.Windows.Forms.Label();
            this.helpPicBox = new System.Windows.Forms.PictureBox();
            this.userPicBox = new System.Windows.Forms.PictureBox();
            this.patientPicBox = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.Button();
            this.homeGradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // homeGradientPanel
            // 
            this.homeGradientPanel.Angle = 0F;
            this.homeGradientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.homeGradientPanel.BottomColor = System.Drawing.Color.Empty;
            this.homeGradientPanel.Controls.Add(this.label1);
            this.homeGradientPanel.Controls.Add(this.inventoryPicBox);
            this.homeGradientPanel.Controls.Add(this.header);
            this.homeGradientPanel.Controls.Add(this.patientHomeLbl);
            this.homeGradientPanel.Controls.Add(this.userRegHomeLbl);
            this.homeGradientPanel.Controls.Add(this.helpHomeLbl);
            this.homeGradientPanel.Controls.Add(this.helpPicBox);
            this.homeGradientPanel.Controls.Add(this.userPicBox);
            this.homeGradientPanel.Controls.Add(this.patientPicBox);
            this.homeGradientPanel.Controls.Add(this.profileBtn);
            this.homeGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.homeGradientPanel.Name = "homeGradientPanel";
            this.homeGradientPanel.Size = new System.Drawing.Size(1503, 800);
            this.homeGradientPanel.TabIndex = 0;
            this.homeGradientPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Inventroy";
            // 
            // inventoryPicBox
            // 
            this.inventoryPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.inventoryPicBox.Image = global::MediManage.Properties.Resources.invnetory_icon_1;
            this.inventoryPicBox.Location = new System.Drawing.Point(253, 135);
            this.inventoryPicBox.Name = "inventoryPicBox";
            this.inventoryPicBox.Size = new System.Drawing.Size(458, 315);
            this.inventoryPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.inventoryPicBox.TabIndex = 93;
            this.inventoryPicBox.TabStop = false;
            this.inventoryPicBox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(644, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(245, 42);
            this.header.TabIndex = 92;
            this.header.Text = "MediManage";
            // 
            // patientHomeLbl
            // 
            this.patientHomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patientHomeLbl.AutoSize = true;
            this.patientHomeLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.patientHomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientHomeLbl.Location = new System.Drawing.Point(951, 135);
            this.patientHomeLbl.Name = "patientHomeLbl";
            this.patientHomeLbl.Size = new System.Drawing.Size(85, 25);
            this.patientHomeLbl.TabIndex = 90;
            this.patientHomeLbl.Text = "Patient ";
            // 
            // userRegHomeLbl
            // 
            this.userRegHomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRegHomeLbl.AutoSize = true;
            this.userRegHomeLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userRegHomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegHomeLbl.Location = new System.Drawing.Point(443, 518);
            this.userRegHomeLbl.Name = "userRegHomeLbl";
            this.userRegHomeLbl.Size = new System.Drawing.Size(63, 25);
            this.userRegHomeLbl.TabIndex = 89;
            this.userRegHomeLbl.Text = "User ";
            // 
            // helpHomeLbl
            // 
            this.helpHomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpHomeLbl.AutoSize = true;
            this.helpHomeLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.helpHomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpHomeLbl.Location = new System.Drawing.Point(974, 518);
            this.helpHomeLbl.Name = "helpHomeLbl";
            this.helpHomeLbl.Size = new System.Drawing.Size(62, 25);
            this.helpHomeLbl.TabIndex = 86;
            this.helpHomeLbl.Text = "Help ";
            // 
            // helpPicBox
            // 
            this.helpPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.helpPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpPicBox.Image = global::MediManage.Properties.Resources.Help_icon_;
            this.helpPicBox.Location = new System.Drawing.Point(766, 509);
            this.helpPicBox.Name = "helpPicBox";
            this.helpPicBox.Size = new System.Drawing.Size(458, 315);
            this.helpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.helpPicBox.TabIndex = 84;
            this.helpPicBox.TabStop = false;
            this.helpPicBox.Click += new System.EventHandler(this.helpPicBox_Click);
            // 
            // userPicBox
            // 
            this.userPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicBox.Image = global::MediManage.Properties.Resources.user_reg_icon;
            this.userPicBox.Location = new System.Drawing.Point(253, 509);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(458, 315);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicBox.TabIndex = 83;
            this.userPicBox.TabStop = false;
            this.userPicBox.Click += new System.EventHandler(this.userPicBox_Click);
            // 
            // patientPicBox
            // 
            this.patientPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patientPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.patientPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientPicBox.Image = global::MediManage.Properties.Resources.patient_icon;
            this.patientPicBox.Location = new System.Drawing.Point(766, 135);
            this.patientPicBox.Name = "patientPicBox";
            this.patientPicBox.Size = new System.Drawing.Size(458, 315);
            this.patientPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.patientPicBox.TabIndex = 80;
            this.patientPicBox.TabStop = false;
            this.patientPicBox.Click += new System.EventHandler(this.patientPicBox_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(12, 21);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(170, 54);
            this.profileBtn.TabIndex = 75;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 800);
            this.Controls.Add(this.homeGradientPanel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.homeGradientPanel.ResumeLayout(false);
            this.homeGradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.PictureBox patientPicBox;
        private System.Windows.Forms.PictureBox userPicBox;
        private System.Windows.Forms.PictureBox helpPicBox;
        private System.Windows.Forms.Label helpHomeLbl;
        private System.Windows.Forms.Label userRegHomeLbl;
        private System.Windows.Forms.Label patientHomeLbl;
        private System.Windows.Forms.Label header;
        private GradientPanel homeGradientPanel;
        private System.Windows.Forms.PictureBox inventoryPicBox;
        private System.Windows.Forms.Label label1;
    }
}