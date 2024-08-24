namespace MediManage
{
    partial class patientForm
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
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_skickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.editPatientNameLbl = new System.Windows.Forms.Label();
            this.EditPatientNameTxtBox = new System.Windows.Forms.TextBox();
            this.patientIllnessTxtBox = new System.Windows.Forms.TextBox();
            this.patientIllnessLbl = new System.Windows.Forms.Label();
            this.patientContactnumberTxt = new System.Windows.Forms.TextBox();
            this.patientContactnumberLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.patient_skickness,
            this.contactNumber});
            this.patientDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientDataGridView.Location = new System.Drawing.Point(12, 141);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowHeadersWidth = 51;
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(734, 537);
            this.patientDataGridView.TabIndex = 0;
            this.patientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellContentClick);
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
            // patient_skickness
            // 
            this.patient_skickness.HeaderText = "Illness ";
            this.patient_skickness.MinimumWidth = 6;
            this.patient_skickness.Name = "patient_skickness";
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(624, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(308, 38);
            this.header.TabIndex = 76;
            this.header.Text = "Patient Managment";
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
            this.backBtn.TabIndex = 77;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(1295, 12);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(170, 54);
            this.addUserBtn.TabIndex = 90;
            this.addUserBtn.Text = "Add Patient";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // editPatientNameLbl
            // 
            this.editPatientNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPatientNameLbl.AutoSize = true;
            this.editPatientNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.editPatientNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatientNameLbl.ForeColor = System.Drawing.Color.White;
            this.editPatientNameLbl.Location = new System.Drawing.Point(815, 144);
            this.editPatientNameLbl.Name = "editPatientNameLbl";
            this.editPatientNameLbl.Size = new System.Drawing.Size(187, 25);
            this.editPatientNameLbl.TabIndex = 91;
            this.editPatientNameLbl.Text = "Edit Patient Name";
            // 
            // EditPatientNameTxtBox
            // 
            this.EditPatientNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPatientNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.EditPatientNameTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPatientNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.EditPatientNameTxtBox.Location = new System.Drawing.Point(1152, 141);
            this.EditPatientNameTxtBox.Name = "EditPatientNameTxtBox";
            this.EditPatientNameTxtBox.Size = new System.Drawing.Size(313, 34);
            this.EditPatientNameTxtBox.TabIndex = 93;
            // 
            // patientIllnessTxtBox
            // 
            this.patientIllnessTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIllnessTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.patientIllnessTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIllnessTxtBox.ForeColor = System.Drawing.Color.White;
            this.patientIllnessTxtBox.Location = new System.Drawing.Point(1152, 201);
            this.patientIllnessTxtBox.Name = "patientIllnessTxtBox";
            this.patientIllnessTxtBox.Size = new System.Drawing.Size(313, 34);
            this.patientIllnessTxtBox.TabIndex = 95;
            // 
            // patientIllnessLbl
            // 
            this.patientIllnessLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIllnessLbl.AutoSize = true;
            this.patientIllnessLbl.BackColor = System.Drawing.Color.Transparent;
            this.patientIllnessLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIllnessLbl.ForeColor = System.Drawing.Color.White;
            this.patientIllnessLbl.Location = new System.Drawing.Point(815, 204);
            this.patientIllnessLbl.Name = "patientIllnessLbl";
            this.patientIllnessLbl.Size = new System.Drawing.Size(190, 25);
            this.patientIllnessLbl.TabIndex = 94;
            this.patientIllnessLbl.Text = "Edit Patient Illness";
            // 
            // patientContactnumberTxt
            // 
            this.patientContactnumberTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientContactnumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.patientContactnumberTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientContactnumberTxt.ForeColor = System.Drawing.Color.White;
            this.patientContactnumberTxt.Location = new System.Drawing.Point(1152, 262);
            this.patientContactnumberTxt.Name = "patientContactnumberTxt";
            this.patientContactnumberTxt.Size = new System.Drawing.Size(313, 34);
            this.patientContactnumberTxt.TabIndex = 97;
            // 
            // patientContactnumberLbl
            // 
            this.patientContactnumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientContactnumberLbl.AutoSize = true;
            this.patientContactnumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.patientContactnumberLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientContactnumberLbl.ForeColor = System.Drawing.Color.White;
            this.patientContactnumberLbl.Location = new System.Drawing.Point(815, 265);
            this.patientContactnumberLbl.Name = "patientContactnumberLbl";
            this.patientContactnumberLbl.Size = new System.Drawing.Size(291, 25);
            this.patientContactnumberLbl.TabIndex = 96;
            this.patientContactnumberLbl.Text = "Edit Patient Contact Number";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(972, 409);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(170, 54);
            this.UpdateBtn.TabIndex = 98;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(1295, 409);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(170, 54);
            this.clearBtn.TabIndex = 99;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1477, 690);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.patientContactnumberTxt);
            this.Controls.Add(this.patientContactnumberLbl);
            this.Controls.Add(this.patientIllnessTxtBox);
            this.Controls.Add(this.patientIllnessLbl);
            this.Controls.Add(this.EditPatientNameTxtBox);
            this.Controls.Add(this.editPatientNameLbl);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.patientDataGridView);
            this.Name = "patientForm";
            this.Text = "patientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.patientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label editPatientNameLbl;
        private System.Windows.Forms.TextBox EditPatientNameTxtBox;
        private System.Windows.Forms.TextBox patientIllnessTxtBox;
        private System.Windows.Forms.Label patientIllnessLbl;
        private System.Windows.Forms.TextBox patientContactnumberTxt;
        private System.Windows.Forms.Label patientContactnumberLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_skickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
    }
}