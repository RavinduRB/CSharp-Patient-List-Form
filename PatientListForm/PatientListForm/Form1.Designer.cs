namespace PatientListForm
{
    partial class PatientList
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
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientIllness = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIllnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientcontactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientListDBDataSet = new PatientListForm.PatientListDBDataSet();
            this.addSinglePatient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientTableAdapter = new PatientListForm.PatientListDBDataSetTableAdapters.patientTableAdapter();
            this.gen = new System.Windows.Forms.ComboBox();
            this.dsp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1067, 324);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 36);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(811, 324);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 36);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.SpringGreen;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(991, 98);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(261, 27);
            this.txtPatientName.TabIndex = 28;
            // 
            // txtPatientIllness
            // 
            this.txtPatientIllness.BackColor = System.Drawing.Color.SpringGreen;
            this.txtPatientIllness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientIllness.Location = new System.Drawing.Point(991, 148);
            this.txtPatientIllness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientIllness.Name = "txtPatientIllness";
            this.txtPatientIllness.Size = new System.Drawing.Size(261, 27);
            this.txtPatientIllness.TabIndex = 27;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.SpringGreen;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(991, 194);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(261, 27);
            this.txtContactNumber.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(765, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patient Illness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Patient Name";
            // 
            // data
            // 
            this.data.AutoGenerateColumns = false;
            this.data.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientIllnessDataGridViewTextBoxColumn,
            this.patientcontactNumberDataGridViewTextBoxColumn,
            this.patientgenderDataGridViewTextBoxColumn});
            this.data.DataSource = this.patientBindingSource;
            this.data.Location = new System.Drawing.Point(21, 102);
            this.data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(677, 487);
            this.data.TabIndex = 21;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "patient_Name";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientIllnessDataGridViewTextBoxColumn
            // 
            this.patientIllnessDataGridViewTextBoxColumn.DataPropertyName = "patient_Illness ";
            this.patientIllnessDataGridViewTextBoxColumn.HeaderText = "patient_Illness ";
            this.patientIllnessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIllnessDataGridViewTextBoxColumn.Name = "patientIllnessDataGridViewTextBoxColumn";
            this.patientIllnessDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientcontactNumberDataGridViewTextBoxColumn
            // 
            this.patientcontactNumberDataGridViewTextBoxColumn.DataPropertyName = "patient_contactNumber";
            this.patientcontactNumberDataGridViewTextBoxColumn.HeaderText = "patient_contactNumber";
            this.patientcontactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientcontactNumberDataGridViewTextBoxColumn.Name = "patientcontactNumberDataGridViewTextBoxColumn";
            this.patientcontactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientgenderDataGridViewTextBoxColumn
            // 
            this.patientgenderDataGridViewTextBoxColumn.DataPropertyName = "patient_gender ";
            this.patientgenderDataGridViewTextBoxColumn.HeaderText = "patient_gender ";
            this.patientgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientgenderDataGridViewTextBoxColumn.Name = "patientgenderDataGridViewTextBoxColumn";
            this.patientgenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.patientListDBDataSet;
            // 
            // patientListDBDataSet
            // 
            this.patientListDBDataSet.DataSetName = "PatientListDBDataSet";
            this.patientListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addSinglePatient
            // 
            this.addSinglePatient.BackColor = System.Drawing.Color.SkyBlue;
            this.addSinglePatient.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSinglePatient.Location = new System.Drawing.Point(599, 71);
            this.addSinglePatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSinglePatient.Name = "addSinglePatient";
            this.addSinglePatient.Size = new System.Drawing.Size(101, 32);
            this.addSinglePatient.TabIndex = 20;
            this.addSinglePatient.Text = "Add New";
            this.addSinglePatient.UseVisualStyleBackColor = false;
            this.addSinglePatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add New Patient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Patient List";
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.SpringGreen;
            this.gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.gen.Location = new System.Drawing.Point(991, 245);
            this.gen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(261, 28);
            this.gen.TabIndex = 33;
            // 
            // dsp
            // 
            this.dsp.AutoSize = true;
            this.dsp.Location = new System.Drawing.Point(987, 404);
            this.dsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dsp.Name = "dsp";
            this.dsp.Size = new System.Drawing.Size(0, 16);
            this.dsp.TabIndex = 34;
            this.dsp.Click += new System.EventHandler(this.label7_Click);
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 597);
            this.Controls.Add(this.dsp);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPatientIllness);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.addSinglePatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientList";
            this.Text = "PatientList";
            this.Load += new System.EventHandler(this.PatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientIllness;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button addSinglePatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PatientListDBDataSet patientListDBDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PatientListDBDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIllnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientcontactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.Label dsp;
    }
}

