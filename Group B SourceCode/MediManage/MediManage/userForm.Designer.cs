namespace MediManage
{
    partial class userForm
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
            this.addUserBtn = new System.Windows.Forms.Button();
            this.userClearBtn = new System.Windows.Forms.Button();
            this.userUpdateBtn = new System.Windows.Forms.Button();
            this.userPassWordTxtBox = new System.Windows.Forms.TextBox();
            this.userEmialTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditUsercontactNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.editUserNameLbl = new System.Windows.Forms.Label();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRegistrationLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.addUserBtn);
            this.gradientPanel1.Controls.Add(this.userClearBtn);
            this.gradientPanel1.Controls.Add(this.userUpdateBtn);
            this.gradientPanel1.Controls.Add(this.userPassWordTxtBox);
            this.gradientPanel1.Controls.Add(this.userEmialTxtBox);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.EditUsercontactNumberTxtBox);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.EditUserNameTxtBox);
            this.gradientPanel1.Controls.Add(this.editUserNameLbl);
            this.gradientPanel1.Controls.Add(this.userDataGridView);
            this.gradientPanel1.Controls.Add(this.userRegistrationLbl);
            this.gradientPanel1.Controls.Add(this.backBtn);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1462, 668);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(1277, 20);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(170, 54);
            this.addUserBtn.TabIndex = 89;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // userClearBtn
            // 
            this.userClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userClearBtn.BackColor = System.Drawing.Color.Red;
            this.userClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userClearBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userClearBtn.ForeColor = System.Drawing.Color.White;
            this.userClearBtn.Location = new System.Drawing.Point(1277, 438);
            this.userClearBtn.Name = "userClearBtn";
            this.userClearBtn.Size = new System.Drawing.Size(170, 54);
            this.userClearBtn.TabIndex = 88;
            this.userClearBtn.Text = "Clear";
            this.userClearBtn.UseVisualStyleBackColor = false;
            this.userClearBtn.Click += new System.EventHandler(this.userClearBtn_Click);
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userUpdateBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.userUpdateBtn.Location = new System.Drawing.Point(936, 438);
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.Size = new System.Drawing.Size(170, 54);
            this.userUpdateBtn.TabIndex = 87;
            this.userUpdateBtn.Text = "Update";
            this.userUpdateBtn.UseVisualStyleBackColor = false;
            this.userUpdateBtn.Click += new System.EventHandler(this.userUpdateBtn_Click);
            // 
            // userPassWordTxtBox
            // 
            this.userPassWordTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPassWordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userPassWordTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassWordTxtBox.ForeColor = System.Drawing.Color.White;
            this.userPassWordTxtBox.Location = new System.Drawing.Point(1134, 196);
            this.userPassWordTxtBox.Name = "userPassWordTxtBox";
            this.userPassWordTxtBox.Size = new System.Drawing.Size(313, 34);
            this.userPassWordTxtBox.TabIndex = 86;
            // 
            // userEmialTxtBox
            // 
            this.userEmialTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userEmialTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userEmialTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmialTxtBox.ForeColor = System.Drawing.Color.White;
            this.userEmialTxtBox.Location = new System.Drawing.Point(1134, 316);
            this.userEmialTxtBox.Name = "userEmialTxtBox";
            this.userEmialTxtBox.Size = new System.Drawing.Size(317, 34);
            this.userEmialTxtBox.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(786, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Edit User Email";
            // 
            // EditUsercontactNumberTxtBox
            // 
            this.EditUsercontactNumberTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditUsercontactNumberTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.EditUsercontactNumberTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsercontactNumberTxtBox.ForeColor = System.Drawing.Color.White;
            this.EditUsercontactNumberTxtBox.Location = new System.Drawing.Point(1134, 254);
            this.EditUsercontactNumberTxtBox.Name = "EditUsercontactNumberTxtBox";
            this.EditUsercontactNumberTxtBox.Size = new System.Drawing.Size(313, 34);
            this.EditUsercontactNumberTxtBox.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(786, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Edit User Contact Number";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(786, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Edit User PassWord";
            // 
            // EditUserNameTxtBox
            // 
            this.EditUserNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditUserNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.EditUserNameTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.EditUserNameTxtBox.Location = new System.Drawing.Point(1134, 136);
            this.EditUserNameTxtBox.Name = "EditUserNameTxtBox";
            this.EditUserNameTxtBox.Size = new System.Drawing.Size(313, 34);
            this.EditUserNameTxtBox.TabIndex = 78;
            // 
            // editUserNameLbl
            // 
            this.editUserNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editUserNameLbl.AutoSize = true;
            this.editUserNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.editUserNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserNameLbl.ForeColor = System.Drawing.Color.White;
            this.editUserNameLbl.Location = new System.Drawing.Point(786, 136);
            this.editUserNameLbl.Name = "editUserNameLbl";
            this.editUserNameLbl.Size = new System.Drawing.Size(160, 25);
            this.editUserNameLbl.TabIndex = 77;
            this.editUserNameLbl.Text = "Edit User Name";
            // 
            // userDataGridView
            // 
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.passWord,
            this.contactNumber,
            this.email});
            this.userDataGridView.Location = new System.Drawing.Point(12, 136);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(768, 520);
            this.userDataGridView.TabIndex = 76;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // passWord
            // 
            this.passWord.HeaderText = "PassWord";
            this.passWord.MinimumWidth = 6;
            this.passWord.Name = "passWord";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // userRegistrationLbl
            // 
            this.userRegistrationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRegistrationLbl.AutoSize = true;
            this.userRegistrationLbl.BackColor = System.Drawing.Color.Transparent;
            this.userRegistrationLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegistrationLbl.ForeColor = System.Drawing.Color.White;
            this.userRegistrationLbl.Location = new System.Drawing.Point(556, 21);
            this.userRegistrationLbl.Name = "userRegistrationLbl";
            this.userRegistrationLbl.Size = new System.Drawing.Size(270, 38);
            this.userRegistrationLbl.TabIndex = 75;
            this.userRegistrationLbl.Text = "User Managment";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(170, 54);
            this.backBtn.TabIndex = 74;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 668);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "userForm";
            this.Text = "userForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label userRegistrationLbl;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.TextBox EditUserNameTxtBox;
        private System.Windows.Forms.Label editUserNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditUsercontactNumberTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userEmialTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button userClearBtn;
        private System.Windows.Forms.Button userUpdateBtn;
        private System.Windows.Forms.TextBox userPassWordTxtBox;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}