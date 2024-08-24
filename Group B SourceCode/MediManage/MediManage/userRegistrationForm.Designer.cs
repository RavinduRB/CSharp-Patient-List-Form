namespace MediManage
{
    partial class userRegistrationForm
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
            this.gradientPanel1 = new MediManage.GradientPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.userRegistrationLbl = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Regbtn = new System.Windows.Forms.Button();
            this.Useremailtxt = new System.Windows.Forms.TextBox();
            this.Usercnumbertxt = new System.Windows.Forms.TextBox();
            this.Userpasstxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.UserCnumberlbl = new System.Windows.Forms.Label();
            this.Useremaillbl = new System.Windows.Forms.Label();
            this.Userpasswordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.backBtn);
            this.gradientPanel1.Controls.Add(this.userRegistrationLbl);
            this.gradientPanel1.Controls.Add(this.Clearbtn);
            this.gradientPanel1.Controls.Add(this.Regbtn);
            this.gradientPanel1.Controls.Add(this.Useremailtxt);
            this.gradientPanel1.Controls.Add(this.Usercnumbertxt);
            this.gradientPanel1.Controls.Add(this.Userpasstxt);
            this.gradientPanel1.Controls.Add(this.Usernametxt);
            this.gradientPanel1.Controls.Add(this.UserCnumberlbl);
            this.gradientPanel1.Controls.Add(this.Useremaillbl);
            this.gradientPanel1.Controls.Add(this.Userpasswordlbl);
            this.gradientPanel1.Controls.Add(this.Usernamelbl);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1503, 767);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(170, 54);
            this.backBtn.TabIndex = 73;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userRegistrationLbl
            // 
            this.userRegistrationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRegistrationLbl.AutoSize = true;
            this.userRegistrationLbl.BackColor = System.Drawing.Color.Transparent;
            this.userRegistrationLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegistrationLbl.ForeColor = System.Drawing.Color.White;
            this.userRegistrationLbl.Location = new System.Drawing.Point(607, 36);
            this.userRegistrationLbl.Name = "userRegistrationLbl";
            this.userRegistrationLbl.Size = new System.Drawing.Size(268, 38);
            this.userRegistrationLbl.TabIndex = 72;
            this.userRegistrationLbl.Text = "User Registration";
            // 
            // Clearbtn
            // 
            this.Clearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clearbtn.BackColor = System.Drawing.Color.Red;
            this.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(1009, 569);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(170, 52);
            this.Clearbtn.TabIndex = 71;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Regbtn
            // 
            this.Regbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Regbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.Regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regbtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbtn.ForeColor = System.Drawing.Color.White;
            this.Regbtn.Location = new System.Drawing.Point(671, 569);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(170, 52);
            this.Regbtn.TabIndex = 70;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = false;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Useremailtxt
            // 
            this.Useremailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Useremailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.Useremailtxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useremailtxt.ForeColor = System.Drawing.Color.White;
            this.Useremailtxt.Location = new System.Drawing.Point(671, 483);
            this.Useremailtxt.Name = "Useremailtxt";
            this.Useremailtxt.Size = new System.Drawing.Size(494, 34);
            this.Useremailtxt.TabIndex = 69;
            // 
            // Usercnumbertxt
            // 
            this.Usercnumbertxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usercnumbertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.Usercnumbertxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usercnumbertxt.ForeColor = System.Drawing.Color.White;
            this.Usercnumbertxt.Location = new System.Drawing.Point(671, 430);
            this.Usercnumbertxt.Name = "Usercnumbertxt";
            this.Usercnumbertxt.Size = new System.Drawing.Size(494, 34);
            this.Usercnumbertxt.TabIndex = 68;
            // 
            // Userpasstxt
            // 
            this.Userpasstxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Userpasstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.Userpasstxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userpasstxt.ForeColor = System.Drawing.Color.White;
            this.Userpasstxt.Location = new System.Drawing.Point(671, 368);
            this.Userpasstxt.Name = "Userpasstxt";
            this.Userpasstxt.Size = new System.Drawing.Size(494, 34);
            this.Userpasstxt.TabIndex = 67;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.ForeColor = System.Drawing.Color.White;
            this.Usernametxt.Location = new System.Drawing.Point(671, 304);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(494, 34);
            this.Usernametxt.TabIndex = 66;
            // 
            // UserCnumberlbl
            // 
            this.UserCnumberlbl.AutoSize = true;
            this.UserCnumberlbl.BackColor = System.Drawing.Color.Transparent;
            this.UserCnumberlbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCnumberlbl.ForeColor = System.Drawing.Color.White;
            this.UserCnumberlbl.Location = new System.Drawing.Point(287, 427);
            this.UserCnumberlbl.Name = "UserCnumberlbl";
            this.UserCnumberlbl.Size = new System.Drawing.Size(274, 25);
            this.UserCnumberlbl.TabIndex = 65;
            this.UserCnumberlbl.Text = "Enter User contact Number";
            // 
            // Useremaillbl
            // 
            this.Useremaillbl.AutoSize = true;
            this.Useremaillbl.BackColor = System.Drawing.Color.Transparent;
            this.Useremaillbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useremaillbl.ForeColor = System.Drawing.Color.White;
            this.Useremaillbl.Location = new System.Drawing.Point(287, 481);
            this.Useremaillbl.Name = "Useremaillbl";
            this.Useremaillbl.Size = new System.Drawing.Size(169, 25);
            this.Useremaillbl.TabIndex = 64;
            this.Useremaillbl.Text = "Enter User Email";
            // 
            // Userpasswordlbl
            // 
            this.Userpasswordlbl.AutoSize = true;
            this.Userpasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userpasswordlbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userpasswordlbl.ForeColor = System.Drawing.Color.White;
            this.Userpasswordlbl.Location = new System.Drawing.Point(287, 365);
            this.Userpasswordlbl.Name = "Userpasswordlbl";
            this.Userpasswordlbl.Size = new System.Drawing.Size(208, 25);
            this.Userpasswordlbl.TabIndex = 63;
            this.Userpasswordlbl.Text = "Enter User Password";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.White;
            this.Usernamelbl.Location = new System.Drawing.Point(287, 301);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(173, 25);
            this.Usernamelbl.TabIndex = 62;
            this.Usernamelbl.Text = "Enter User Name";
            // 
            // userRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1503, 767);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "userRegistrationForm";
            this.Text = "User Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userRegistrationForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label userRegistrationLbl;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.TextBox Useremailtxt;
        private System.Windows.Forms.TextBox Usercnumbertxt;
        private System.Windows.Forms.TextBox Userpasstxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label UserCnumberlbl;
        private System.Windows.Forms.Label Useremaillbl;
        private System.Windows.Forms.Label Userpasswordlbl;
        private System.Windows.Forms.Label Usernamelbl;
    }
}