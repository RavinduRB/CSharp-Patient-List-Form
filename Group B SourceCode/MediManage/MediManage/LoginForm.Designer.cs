namespace MediManage
{
    partial class LoginForm
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
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passWordTxt = new System.Windows.Forms.TextBox();
            this.passWordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(373, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(769, 42);
            this.header.TabIndex = 93;
            this.header.Text = "Welcome To MediManage";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.White;
            this.userNameTxt.Location = new System.Drawing.Point(744, 210);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(313, 34);
            this.userNameTxt.TabIndex = 95;
            // 
            // userNameLbl
            // 
            this.userNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(407, 213);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(206, 29);
            this.userNameLbl.TabIndex = 94;
            this.userNameLbl.Text = "Enter User Name ";
            // 
            // passWordTxt
            // 
            this.passWordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passWordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.passWordTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTxt.ForeColor = System.Drawing.Color.White;
            this.passWordTxt.Location = new System.Drawing.Point(744, 305);
            this.passWordTxt.Name = "passWordTxt";
            this.passWordTxt.Size = new System.Drawing.Size(313, 34);
            this.passWordTxt.TabIndex = 97;
            // 
            // passWordLbl
            // 
            this.passWordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passWordLbl.AutoSize = true;
            this.passWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passWordLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLbl.ForeColor = System.Drawing.Color.White;
            this.passWordLbl.Location = new System.Drawing.Point(407, 305);
            this.passWordLbl.Name = "passWordLbl";
            this.passWordLbl.Size = new System.Drawing.Size(189, 29);
            this.passWordLbl.TabIndex = 96;
            this.passWordLbl.Text = "Enter PassWord";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(744, 395);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(313, 54);
            this.loginBtn.TabIndex = 99;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1483, 676);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passWordTxt);
            this.Controls.Add(this.passWordLbl);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.header);
            this.Name = "LoginForm";
            this.Text = "profileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox passWordTxt;
        private System.Windows.Forms.Label passWordLbl;
        private System.Windows.Forms.Button loginBtn;
    }
}