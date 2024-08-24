namespace MediManage
{
    partial class profileForm
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
            this.header = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passWordLbl = new System.Windows.Forms.Label();
            this.emialLbl = new System.Windows.Forms.Label();
            this.contactNumberLbl = new System.Windows.Forms.Label();
            this.profileContactNumLbl = new System.Windows.Forms.Label();
            this.profilePassWordLbl = new System.Windows.Forms.Label();
            this.profileUserNameLbl = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.profileEmailLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(632, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(141, 42);
            this.header.TabIndex = 93;
            this.header.Text = "Profile ";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(170, 54);
            this.backBtn.TabIndex = 94;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(774, 160);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(111, 36);
            this.userNameLbl.TabIndex = 95;
            this.userNameLbl.Text = "Name: ";
            // 
            // passWordLbl
            // 
            this.passWordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passWordLbl.AutoSize = true;
            this.passWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passWordLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLbl.ForeColor = System.Drawing.Color.White;
            this.passWordLbl.Location = new System.Drawing.Point(774, 273);
            this.passWordLbl.Name = "passWordLbl";
            this.passWordLbl.Size = new System.Drawing.Size(165, 36);
            this.passWordLbl.TabIndex = 96;
            this.passWordLbl.Text = "PassWord: ";
            // 
            // emialLbl
            // 
            this.emialLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emialLbl.AutoSize = true;
            this.emialLbl.BackColor = System.Drawing.Color.Transparent;
            this.emialLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emialLbl.ForeColor = System.Drawing.Color.White;
            this.emialLbl.Location = new System.Drawing.Point(774, 483);
            this.emialLbl.Name = "emialLbl";
            this.emialLbl.Size = new System.Drawing.Size(104, 36);
            this.emialLbl.TabIndex = 98;
            this.emialLbl.Text = "Emial: ";
            // 
            // contactNumberLbl
            // 
            this.contactNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactNumberLbl.AutoSize = true;
            this.contactNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.contactNumberLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLbl.ForeColor = System.Drawing.Color.White;
            this.contactNumberLbl.Location = new System.Drawing.Point(774, 378);
            this.contactNumberLbl.Name = "contactNumberLbl";
            this.contactNumberLbl.Size = new System.Drawing.Size(256, 36);
            this.contactNumberLbl.TabIndex = 97;
            this.contactNumberLbl.Text = "Contact Number: ";
            // 
            // profileContactNumLbl
            // 
            this.profileContactNumLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileContactNumLbl.AutoSize = true;
            this.profileContactNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.profileContactNumLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileContactNumLbl.ForeColor = System.Drawing.Color.White;
            this.profileContactNumLbl.Location = new System.Drawing.Point(1073, 378);
            this.profileContactNumLbl.Name = "profileContactNumLbl";
            this.profileContactNumLbl.Size = new System.Drawing.Size(204, 36);
            this.profileContactNumLbl.TabIndex = 99;
            this.profileContactNumLbl.Text = "\"conNumber\"";
            // 
            // profilePassWordLbl
            // 
            this.profilePassWordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePassWordLbl.AutoSize = true;
            this.profilePassWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.profilePassWordLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePassWordLbl.ForeColor = System.Drawing.Color.White;
            this.profilePassWordLbl.Location = new System.Drawing.Point(1073, 273);
            this.profilePassWordLbl.Name = "profilePassWordLbl";
            this.profilePassWordLbl.Size = new System.Drawing.Size(177, 36);
            this.profilePassWordLbl.TabIndex = 100;
            this.profilePassWordLbl.Text = "\"passWord\"";
            // 
            // profileUserNameLbl
            // 
            this.profileUserNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileUserNameLbl.AutoSize = true;
            this.profileUserNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.profileUserNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUserNameLbl.ForeColor = System.Drawing.Color.White;
            this.profileUserNameLbl.Location = new System.Drawing.Point(1073, 160);
            this.profileUserNameLbl.Name = "profileUserNameLbl";
            this.profileUserNameLbl.Size = new System.Drawing.Size(118, 36);
            this.profileUserNameLbl.TabIndex = 101;
            this.profileUserNameLbl.Text = "\"name\"";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(681, 570);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(170, 54);
            this.logOutBtn.TabIndex = 104;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // profileEmailLbl
            // 
            this.profileEmailLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileEmailLbl.AutoSize = true;
            this.profileEmailLbl.BackColor = System.Drawing.Color.Transparent;
            this.profileEmailLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileEmailLbl.ForeColor = System.Drawing.Color.White;
            this.profileEmailLbl.Location = new System.Drawing.Point(1073, 483);
            this.profileEmailLbl.Name = "profileEmailLbl";
            this.profileEmailLbl.Size = new System.Drawing.Size(116, 36);
            this.profileEmailLbl.TabIndex = 105;
            this.profileEmailLbl.Text = "\"emial\"";
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1493, 656);
            this.Controls.Add(this.profileEmailLbl);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.profileUserNameLbl);
            this.Controls.Add(this.profilePassWordLbl);
            this.Controls.Add(this.profileContactNumLbl);
            this.Controls.Add(this.emialLbl);
            this.Controls.Add(this.contactNumberLbl);
            this.Controls.Add(this.passWordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.header);
            this.Name = "profileForm";
            this.Text = "profileForm";
            this.Load += new System.EventHandler(this.profileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passWordLbl;
        private System.Windows.Forms.Label emialLbl;
        private System.Windows.Forms.Label contactNumberLbl;
        private System.Windows.Forms.Label profileContactNumLbl;
        private System.Windows.Forms.Label profilePassWordLbl;
        private System.Windows.Forms.Label profileUserNameLbl;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label profileEmailLbl;
    }
}