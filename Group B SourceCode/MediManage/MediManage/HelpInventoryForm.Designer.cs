namespace MediManage
{
    partial class HelpInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpInventoryForm));
            this.gradientPanel1 = new MediManage.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginHomePageBtn = new System.Windows.Forms.Button();
            this.loginHelpLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.loginHomePageBtn);
            this.gradientPanel1.Controls.Add(this.loginHelpLbl);
            this.gradientPanel1.Controls.Add(this.backBtn);
            this.gradientPanel1.Controls.Add(this.header);
            this.gradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1924, 876);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Click here to go to the Home page:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1697, 200);
            this.label1.TabIndex = 42;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // loginHomePageBtn
            // 
            this.loginHomePageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginHomePageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.loginHomePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginHomePageBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHomePageBtn.ForeColor = System.Drawing.Color.White;
            this.loginHomePageBtn.Location = new System.Drawing.Point(964, 693);
            this.loginHomePageBtn.Name = "loginHomePageBtn";
            this.loginHomePageBtn.Size = new System.Drawing.Size(265, 46);
            this.loginHomePageBtn.TabIndex = 41;
            this.loginHomePageBtn.Text = "Home Page";
            this.loginHomePageBtn.UseVisualStyleBackColor = false;
            this.loginHomePageBtn.Click += new System.EventHandler(this.loginHomePageBtn_Click);
            // 
            // loginHelpLbl
            // 
            this.loginHelpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginHelpLbl.AutoSize = true;
            this.loginHelpLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginHelpLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHelpLbl.ForeColor = System.Drawing.Color.White;
            this.loginHelpLbl.Location = new System.Drawing.Point(161, 121);
            this.loginHelpLbl.Name = "loginHelpLbl";
            this.loginHelpLbl.Size = new System.Drawing.Size(1143, 225);
            this.loginHelpLbl.TabIndex = 40;
            this.loginHelpLbl.Text = resources.GetString("loginHelpLbl.Text");
            this.loginHelpLbl.Click += new System.EventHandler(this.loginHelpLbl_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(179, 46);
            this.backBtn.TabIndex = 39;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(778, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(240, 38);
            this.header.TabIndex = 28;
            this.header.Text = "Help: Inventory";
            // 
            // HelpInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 876);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "HelpInventoryForm";
            this.Text = "HelpInventoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HelpInventoryForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label loginHelpLbl;
        private System.Windows.Forms.Button loginHomePageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}