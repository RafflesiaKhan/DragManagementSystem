namespace UI
{
    partial class Shopping_Cart
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTime_Customer = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label_ShowCustomerName = new System.Windows.Forms.Label();
            this.label_ShowCustomerId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Controls.Add(this.button_CheckOut);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.dataGridView1);
            this.panel10.Controls.Add(this.label_ShowCustomerId);
            this.panel10.Controls.Add(this.label_ShowCustomerName);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.dateTime_Customer);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(671, 502);
            this.panel10.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(322, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 19);
            this.label20.TabIndex = 32;
            this.label20.Text = "ID :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 19);
            this.label25.TabIndex = 11;
            this.label25.Text = "Name :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(500, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 19);
            this.label26.TabIndex = 9;
            this.label26.Text = "Date :";
            // 
            // dateTime_Customer
            // 
            this.dateTime_Customer.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTime_Customer.CustomFormat = "28-Mar-2016";
            this.dateTime_Customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Customer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Customer.Location = new System.Drawing.Point(548, 86);
            this.dateTime_Customer.Name = "dateTime_Customer";
            this.dateTime_Customer.Size = new System.Drawing.Size(110, 26);
            this.dateTime_Customer.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel11.Location = new System.Drawing.Point(0, 47);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(670, 33);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Teal;
            this.panel12.Controls.Add(this.label27);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(670, 50);
            this.panel12.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(268, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 33);
            this.label27.TabIndex = 2;
            this.label27.Text = "Purchase";
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(0, 47);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(662, 36);
            this.panel13.TabIndex = 1;
            // 
            // label_ShowCustomerName
            // 
            this.label_ShowCustomerName.AutoSize = true;
            this.label_ShowCustomerName.Location = new System.Drawing.Point(79, 89);
            this.label_ShowCustomerName.Name = "label_ShowCustomerName";
            this.label_ShowCustomerName.Size = new System.Drawing.Size(140, 19);
            this.label_ShowCustomerName.TabIndex = 33;
            this.label_ShowCustomerName.Text = "ShowCustomerName";
            // 
            // label_ShowCustomerId
            // 
            this.label_ShowCustomerId.AutoSize = true;
            this.label_ShowCustomerId.Location = new System.Drawing.Point(350, 89);
            this.label_ShowCustomerId.Name = "label_ShowCustomerId";
            this.label_ShowCustomerId.Size = new System.Drawing.Size(119, 19);
            this.label_ShowCustomerId.TabIndex = 34;
            this.label_ShowCustomerId.Text = "ShowCustomerID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 296);
            this.dataGridView1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Shopping Cart :";
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.BackColor = System.Drawing.Color.DarkCyan;
            this.button_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CheckOut.Location = new System.Drawing.Point(572, 462);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(87, 28);
            this.button_CheckOut.TabIndex = 37;
            this.button_CheckOut.Text = "Check Out";
            this.button_CheckOut.UseVisualStyleBackColor = false;
            this.button_CheckOut.Click += new System.EventHandler(this.OnCheckOutClick);
            // 
            // Shopping_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 502);
            this.Controls.Add(this.panel10);
            this.Name = "Shopping_Cart";
            this.Text = "Shopping_Cart";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dateTime_Customer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ShowCustomerId;
        private System.Windows.Forms.Label label_ShowCustomerName;
        private System.Windows.Forms.Button button_CheckOut;
    }
}