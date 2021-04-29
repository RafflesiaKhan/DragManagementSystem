namespace UI
{
    partial class Inquiry
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Inquary = new System.Windows.Forms.DataGridView();
            this.button_Details = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Medicine = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inquary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_Details);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_Medicine);
            this.panel1.Controls.Add(this.dataGridView_Inquary);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 488);
            this.panel1.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.Location = new System.Drawing.Point(196, 120);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(59, 28);
            this.button_Search.TabIndex = 30;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Description :";
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Description.Location = new System.Drawing.Point(100, 88);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(155, 26);
            this.textBox_Description.TabIndex = 28;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Back.Location = new System.Drawing.Point(12, 448);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(59, 28);
            this.button_Back.TabIndex = 27;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.OnBackClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 33);
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
            this.panel2.Size = new System.Drawing.Size(815, 50);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "Inquiry";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 36);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView_Inquary
            // 
            this.dataGridView_Inquary.AllowUserToAddRows = false;
            this.dataGridView_Inquary.AllowUserToDeleteRows = false;
            this.dataGridView_Inquary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inquary.Location = new System.Drawing.Point(12, 164);
            this.dataGridView_Inquary.Name = "dataGridView_Inquary";
            this.dataGridView_Inquary.ReadOnly = true;
            this.dataGridView_Inquary.Size = new System.Drawing.Size(791, 278);
            this.dataGridView_Inquary.TabIndex = 31;
            // 
            // button_Details
            // 
            this.button_Details.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Details.Location = new System.Drawing.Point(744, 121);
            this.button_Details.Name = "button_Details";
            this.button_Details.Size = new System.Drawing.Size(59, 28);
            this.button_Details.TabIndex = 34;
            this.button_Details.Text = "Details";
            this.button_Details.UseVisualStyleBackColor = false;
            this.button_Details.Click += new System.EventHandler(this.OnDetailsClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Medicine :";
            // 
            // textBox_Medicine
            // 
            this.textBox_Medicine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Medicine.Location = new System.Drawing.Point(648, 89);
            this.textBox_Medicine.Name = "textBox_Medicine";
            this.textBox_Medicine.Size = new System.Drawing.Size(155, 26);
            this.textBox_Medicine.TabIndex = 32;
            // 
            // Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 488);
            this.Controls.Add(this.panel1);
            this.Name = "Inquiry";
            this.Text = "Inquiry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inquary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.DataGridView dataGridView_Inquary;
        private System.Windows.Forms.Button button_Details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Medicine;
    }
}