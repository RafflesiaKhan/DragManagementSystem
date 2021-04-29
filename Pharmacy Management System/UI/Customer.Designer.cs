namespace UI
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Subtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cId = new System.Windows.Forms.TextBox();
            this.dataGridView_Sell = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_DrugQuantity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Drug = new System.Windows.Forms.ComboBox();
            this.tblDrugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_DemoDataSet = new UI.Pharmacy_DemoDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_cSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_Customer = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbl_DrugTableAdapter = new UI.Pharmacy_DemoDataSetTableAdapters.tbl_DrugTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_CheckOut);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_Subtotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_cId);
            this.panel1.Controls.Add(this.dataGridView_Sell);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_DrugQuantity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.comboBox_Drug);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_cSex);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_cContact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_cName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTime_Customer);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 497);
            this.panel1.TabIndex = 2;
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CheckOut.Location = new System.Drawing.Point(582, 258);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(110, 28);
            this.button_CheckOut.TabIndex = 35;
            this.button_CheckOut.Text = "Check Out";
            this.button_CheckOut.UseVisualStyleBackColor = false;
            this.button_CheckOut.Click += new System.EventHandler(this.OnCheckOutClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Subtotal :";
            // 
            // textBox_Subtotal
            // 
            this.textBox_Subtotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Subtotal.Location = new System.Drawing.Point(540, 455);
            this.textBox_Subtotal.Name = "textBox_Subtotal";
            this.textBox_Subtotal.Size = new System.Drawing.Size(152, 26);
            this.textBox_Subtotal.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID :";
            // 
            // textBox_cId
            // 
            this.textBox_cId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_cId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cId.Location = new System.Drawing.Point(392, 90);
            this.textBox_cId.Name = "textBox_cId";
            this.textBox_cId.Size = new System.Drawing.Size(110, 26);
            this.textBox_cId.TabIndex = 31;
            // 
            // dataGridView_Sell
            // 
            this.dataGridView_Sell.AllowUserToAddRows = false;
            this.dataGridView_Sell.AllowUserToDeleteRows = false;
            this.dataGridView_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Quantity,
            this.Column_UnitPrice,
            this.Column_Total});
            this.dataGridView_Sell.Location = new System.Drawing.Point(12, 296);
            this.dataGridView_Sell.Name = "dataGridView_Sell";
            this.dataGridView_Sell.ReadOnly = true;
            this.dataGridView_Sell.Size = new System.Drawing.Size(680, 153);
            this.dataGridView_Sell.TabIndex = 30;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.HeaderText = "Drug Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column_Quantity
            // 
            this.Column_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Quantity.HeaderText = "Quantity";
            this.Column_Quantity.Name = "Column_Quantity";
            this.Column_Quantity.ReadOnly = true;
            // 
            // Column_UnitPrice
            // 
            this.Column_UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_UnitPrice.HeaderText = "Unit Price";
            this.Column_UnitPrice.Name = "Column_UnitPrice";
            this.Column_UnitPrice.ReadOnly = true;
            // 
            // Column_Total
            // 
            this.Column_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Total.HeaderText = "Total";
            this.Column_Total.Name = "Column_Total";
            this.Column_Total.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantity :";
            // 
            // comboBox_DrugQuantity
            // 
            this.comboBox_DrugQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_DrugQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_DrugQuantity.FormattingEnabled = true;
            this.comboBox_DrugQuantity.Location = new System.Drawing.Point(305, 220);
            this.comboBox_DrugQuantity.Name = "comboBox_DrugQuantity";
            this.comboBox_DrugQuantity.Size = new System.Drawing.Size(120, 27);
            this.comboBox_DrugQuantity.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Drug :";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add.Location = new System.Drawing.Point(305, 258);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 28);
            this.button_Add.TabIndex = 26;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.OnAddClick);
            // 
            // comboBox_Drug
            // 
            this.comboBox_Drug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_Drug.DataSource = this.tblDrugBindingSource;
            this.comboBox_Drug.DisplayMember = "dName";
            this.comboBox_Drug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Drug.FormattingEnabled = true;
            this.comboBox_Drug.Location = new System.Drawing.Point(76, 220);
            this.comboBox_Drug.Name = "comboBox_Drug";
            this.comboBox_Drug.Size = new System.Drawing.Size(150, 27);
            this.comboBox_Drug.TabIndex = 25;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sex :";
            // 
            // comboBox_cSex
            // 
            this.comboBox_cSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_cSex.FormattingEnabled = true;
            this.comboBox_cSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_cSex.Location = new System.Drawing.Point(76, 122);
            this.comboBox_cSex.Name = "comboBox_cSex";
            this.comboBox_cSex.Size = new System.Drawing.Size(213, 27);
            this.comboBox_cSex.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contact :";
            // 
            // textBox_cContact
            // 
            this.textBox_cContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_cContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cContact.Location = new System.Drawing.Point(76, 155);
            this.textBox_cContact.Name = "textBox_cContact";
            this.textBox_cContact.Size = new System.Drawing.Size(213, 26);
            this.textBox_cContact.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // textBox_cName
            // 
            this.textBox_cName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_cName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cName.Location = new System.Drawing.Point(76, 90);
            this.textBox_cName.Name = "textBox_cName";
            this.textBox_cName.Size = new System.Drawing.Size(213, 26);
            this.textBox_cName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // dateTime_Customer
            // 
            this.dateTime_Customer.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTime_Customer.CustomFormat = "28-Mar-2016";
            this.dateTime_Customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Customer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Customer.Location = new System.Drawing.Point(584, 90);
            this.dateTime_Customer.Name = "dateTime_Customer";
            this.dateTime_Customer.Size = new System.Drawing.Size(110, 26);
            this.dateTime_Customer.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 33);
            this.panel4.TabIndex = 1;
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
            this.label8.Location = new System.Drawing.Point(288, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "Customer";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 36);
            this.panel3.TabIndex = 1;
            // 
            // tbl_DrugTableAdapter
            // 
            this.tbl_DrugTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_Customer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_cSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cContact;
        private System.Windows.Forms.DataGridView dataGridView_Sell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_DrugQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_Drug;
        private Pharmacy_DemoDataSet pharmacy_DemoDataSet;
        private System.Windows.Forms.BindingSource tblDrugBindingSource;
        private Pharmacy_DemoDataSetTableAdapters.tbl_DrugTableAdapter tbl_DrugTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Total;
        private System.Windows.Forms.Button button_CheckOut;
    }
}