namespace UI
{
    partial class Working
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Inquiry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_DrugQuantity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ShowSupName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ShowSupPhn = new System.Windows.Forms.Label();
            this.label_ShowSupID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Supply = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_Drug = new System.Windows.Forms.ComboBox();
            this.tblDrugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.pharmacy_DemoDataSet = new UI.Pharmacy_DemoDataSet();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_Owner = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbl_SupplierTableAdapter = new UI.Pharmacy_DemoDataSetTableAdapters.tbl_SupplierTableAdapter();
            this.tbl_DrugTableAdapter = new UI.Pharmacy_DemoDataSetTableAdapters.tbl_DrugTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 50);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "Owner";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 36);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.button_Inquiry);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_DrugQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label_ShowSupName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_ShowSupPhn);
            this.panel1.Controls.Add(this.label_ShowSupID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_Supply);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox_Drug);
            this.panel1.Controls.Add(this.comboBox_Supplier);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTime_Owner);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 416);
            this.panel1.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Location = new System.Drawing.Point(624, 189);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(70, 28);
            this.button_Login.TabIndex = 26;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.OnLoginClick);
            // 
            // button_Inquiry
            // 
            this.button_Inquiry.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Inquiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Inquiry.Location = new System.Drawing.Point(624, 223);
            this.button_Inquiry.Name = "button_Inquiry";
            this.button_Inquiry.Size = new System.Drawing.Size(70, 28);
            this.button_Inquiry.TabIndex = 25;
            this.button_Inquiry.Text = "Inquiry";
            this.button_Inquiry.UseVisualStyleBackColor = false;
            this.button_Inquiry.Click += new System.EventHandler(this.OnInquiryClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity :";
            // 
            // comboBox_DrugQuantity
            // 
            this.comboBox_DrugQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_DrugQuantity.FormattingEnabled = true;
            this.comboBox_DrugQuantity.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.comboBox_DrugQuantity.Location = new System.Drawing.Point(394, 187);
            this.comboBox_DrugQuantity.Name = "comboBox_DrugQuantity";
            this.comboBox_DrugQuantity.Size = new System.Drawing.Size(121, 27);
            this.comboBox_DrugQuantity.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name :";
            // 
            // label_ShowSupName
            // 
            this.label_ShowSupName.AutoSize = true;
            this.label_ShowSupName.Location = new System.Drawing.Point(369, 120);
            this.label_ShowSupName.Name = "label_ShowSupName";
            this.label_ShowSupName.Size = new System.Drawing.Size(131, 19);
            this.label_ShowSupName.TabIndex = 21;
            this.label_ShowSupName.Text = "ShowSupplierName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID :";
            // 
            // label_ShowSupPhn
            // 
            this.label_ShowSupPhn.AutoSize = true;
            this.label_ShowSupPhn.Location = new System.Drawing.Point(369, 154);
            this.label_ShowSupPhn.Name = "label_ShowSupPhn";
            this.label_ShowSupPhn.Size = new System.Drawing.Size(117, 19);
            this.label_ShowSupPhn.TabIndex = 18;
            this.label_ShowSupPhn.Text = "ShowSupplierPhn";
            // 
            // label_ShowSupID
            // 
            this.label_ShowSupID.AutoSize = true;
            this.label_ShowSupID.Location = new System.Drawing.Point(369, 91);
            this.label_ShowSupID.Name = "label_ShowSupID";
            this.label_ShowSupID.Size = new System.Drawing.Size(110, 19);
            this.label_ShowSupID.TabIndex = 17;
            this.label_ShowSupID.Text = "ShowSupplierID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Drug :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Supplier :";
            // 
            // dataGridView_Supply
            // 
            this.dataGridView_Supply.AllowUserToAddRows = false;
            this.dataGridView_Supply.AllowUserToDeleteRows = false;
            this.dataGridView_Supply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_UnitPrice,
            this.Column_Quantity});
            this.dataGridView_Supply.Location = new System.Drawing.Point(12, 260);
            this.dataGridView_Supply.Name = "dataGridView_Supply";
            this.dataGridView_Supply.ReadOnly = true;
            this.dataGridView_Supply.Size = new System.Drawing.Size(682, 144);
            this.dataGridView_Supply.TabIndex = 14;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_UnitPrice
            // 
            this.Column_UnitPrice.HeaderText = "Unit Price";
            this.Column_UnitPrice.Name = "Column_UnitPrice";
            this.Column_UnitPrice.ReadOnly = true;
            // 
            // Column_Quantity
            // 
            this.Column_Quantity.HeaderText = "Quantity";
            this.Column_Quantity.Name = "Column_Quantity";
            this.Column_Quantity.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(200, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnAddClick);
            // 
            // comboBox_Drug
            // 
            this.comboBox_Drug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_Drug.DataSource = this.tblDrugBindingSource;
            this.comboBox_Drug.DisplayMember = "dName";
            this.comboBox_Drug.FormattingEnabled = true;
            this.comboBox_Drug.Location = new System.Drawing.Point(80, 186);
            this.comboBox_Drug.Name = "comboBox_Drug";
            this.comboBox_Drug.Size = new System.Drawing.Size(190, 27);
            this.comboBox_Drug.TabIndex = 12;
            // 
            // tblDrugBindingSource
            // 
            this.tblDrugBindingSource.DataMember = "tbl_Drug";
            this.tblDrugBindingSource.DataSource = this.pharmacy_DemoDataSet;
            // 
            // pharmacy_DemoDataSet
            // 
            this.pharmacy_DemoDataSet.DataSetName = "Pharmacy_DemoDataSet";
            this.pharmacy_DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_Supplier.DataSource = this.tblSupplierBindingSource;
            this.comboBox_Supplier.DisplayMember = "sName";
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(80, 87);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(190, 27);
            this.comboBox_Supplier.TabIndex = 10;
            this.comboBox_Supplier.SelectedValueChanged += new System.EventHandler(this.OnSelectedValueChanged);
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tbl_Supplier";
            this.tblSupplierBindingSource.DataSource = this.pharmacy_DemoDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // dateTime_Owner
            // 
            this.dateTime_Owner.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTime_Owner.CustomFormat = "28-Mar-2016";
            this.dateTime_Owner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Owner.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Owner.Location = new System.Drawing.Point(584, 88);
            this.dateTime_Owner.Name = "dateTime_Owner";
            this.dateTime_Owner.Size = new System.Drawing.Size(110, 26);
            this.dateTime_Owner.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 33);
            this.panel4.TabIndex = 1;
            // 
            // tbl_SupplierTableAdapter
            // 
            this.tbl_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DrugTableAdapter
            // 
            this.tbl_DrugTableAdapter.ClearBeforeFill = true;
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 440);
            this.Controls.Add(this.panel1);
            this.Name = "Owner";
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_Owner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_Drug;
        private System.Windows.Forms.DataGridView dataGridView_Supply;
        private System.Windows.Forms.Label label_ShowSupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_ShowSupPhn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ShowSupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_DrugQuantity;
        private Pharmacy_DemoDataSet pharmacy_DemoDataSet;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private Pharmacy_DemoDataSetTableAdapters.tbl_SupplierTableAdapter tbl_SupplierTableAdapter;
        private System.Windows.Forms.BindingSource tblDrugBindingSource;
        private Pharmacy_DemoDataSetTableAdapters.tbl_DrugTableAdapter tbl_DrugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Quantity;
        private System.Windows.Forms.Button button_Inquiry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Login;
    }
}