namespace MediManage
{
    partial class inventoryForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.catComboBox1 = new System.Windows.Forms.ComboBox();
            this.selectCategorytxt = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.fliter = new System.Windows.Forms.Label();
            this.catComboBox2 = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(736, 119);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(201, 29);
            this.nameLbl.TabIndex = 20;
            this.nameLbl.Text = "Enter Item Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.ForeColor = System.Drawing.Color.White;
            this.nameTxtBox.Location = new System.Drawing.Point(1076, 121);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(376, 34);
            this.nameTxtBox.TabIndex = 21;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(736, 177);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(230, 29);
            this.quantityLbl.TabIndex = 22;
            this.quantityLbl.Text = "Enter Item Quantity";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.quantityTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtBox.ForeColor = System.Drawing.Color.White;
            this.quantityTxtBox.Location = new System.Drawing.Point(1076, 177);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(376, 34);
            this.quantityTxtBox.TabIndex = 23;
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(523, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(357, 38);
            this.header.TabIndex = 24;
            this.header.Text = "MediManage Inventory";
            // 
            // catComboBox1
            // 
            this.catComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.catComboBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catComboBox1.ForeColor = System.Drawing.Color.White;
            this.catComboBox1.FormattingEnabled = true;
            this.catComboBox1.Location = new System.Drawing.Point(1198, 295);
            this.catComboBox1.Name = "catComboBox1";
            this.catComboBox1.Size = new System.Drawing.Size(254, 33);
            this.catComboBox1.TabIndex = 25;
            // 
            // selectCategorytxt
            // 
            this.selectCategorytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCategorytxt.AutoSize = true;
            this.selectCategorytxt.BackColor = System.Drawing.Color.Transparent;
            this.selectCategorytxt.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorytxt.ForeColor = System.Drawing.Color.White;
            this.selectCategorytxt.Location = new System.Drawing.Point(736, 295);
            this.selectCategorytxt.Name = "selectCategorytxt";
            this.selectCategorytxt.Size = new System.Drawing.Size(186, 29);
            this.selectCategorytxt.TabIndex = 26;
            this.selectCategorytxt.Text = "Select Category";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.White;
            this.descriptionLbl.Location = new System.Drawing.Point(736, 233);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(262, 29);
            this.descriptionLbl.TabIndex = 27;
            this.descriptionLbl.Text = "Enter Item Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.descriptionTxtBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxtBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTxtBox.Location = new System.Drawing.Point(1076, 233);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(376, 34);
            this.descriptionTxtBox.TabIndex = 28;
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(1001, 421);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(179, 46);
            this.insertBtn.TabIndex = 29;
            this.insertBtn.Text = "Insert new ";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(1001, 421);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(179, 46);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(1267, 421);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(179, 46);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.quantity,
            this.category});
            this.inventoryDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryDataGridView.Location = new System.Drawing.Point(12, 119);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersWidth = 51;
            this.inventoryDataGridView.RowTemplate.Height = 24;
            this.inventoryDataGridView.Size = new System.Drawing.Size(666, 502);
            this.inventoryDataGridView.TabIndex = 33;
            this.inventoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGridView_CellContentClick);
            // 
            // fliter
            // 
            this.fliter.AutoSize = true;
            this.fliter.BackColor = System.Drawing.Color.Transparent;
            this.fliter.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fliter.ForeColor = System.Drawing.Color.White;
            this.fliter.Location = new System.Drawing.Point(12, 87);
            this.fliter.Name = "fliter";
            this.fliter.Size = new System.Drawing.Size(252, 25);
            this.fliter.TabIndex = 34;
            this.fliter.Text = "Filter Items By Category: ";
            // 
            // catComboBox2
            // 
            this.catComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.catComboBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catComboBox2.ForeColor = System.Drawing.Color.White;
            this.catComboBox2.FormattingEnabled = true;
            this.catComboBox2.Location = new System.Drawing.Point(492, 80);
            this.catComboBox2.Name = "catComboBox2";
            this.catComboBox2.Size = new System.Drawing.Size(186, 33);
            this.catComboBox2.TabIndex = 35;
            this.catComboBox2.SelectedIndexChanged += new System.EventHandler(this.catComboBox2_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(179, 46);
            this.backBtn.TabIndex = 36;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1458, 631);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.catComboBox2);
            this.Controls.Add(this.fliter);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.selectCategorytxt);
            this.Controls.Add(this.catComboBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Name = "inventoryForm";
            this.Text = "InventoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.inventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ComboBox catComboBox1;
        private System.Windows.Forms.Label selectCategorytxt;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Label fliter;
        private System.Windows.Forms.ComboBox catComboBox2;
        private System.Windows.Forms.Button backBtn;
    }
}

