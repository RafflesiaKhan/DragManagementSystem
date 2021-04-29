namespace UI
{
    partial class MedicalHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_Medic = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mDisease = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pharmacy_DemoDataSet = new UI.Pharmacy_DemoDataSet();
            this.tblMedicalHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MedicalHistoryTableAdapter = new UI.Pharmacy_DemoDataSetTableAdapters.tbl_MedicalHistoryTableAdapter();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDiseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_mDisease);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_mID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTime_Medic);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 404);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID :";
            // 
            // textBox_mID
            // 
            this.textBox_mID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mID.Location = new System.Drawing.Point(78, 90);
            this.textBox_mID.Name = "textBox_mID";
            this.textBox_mID.Size = new System.Drawing.Size(213, 26);
            this.textBox_mID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // dateTime_Medic
            // 
            this.dateTime_Medic.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTime_Medic.CustomFormat = "28-Mar-2016";
            this.dateTime_Medic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Medic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Medic.Location = new System.Drawing.Point(496, 90);
            this.dateTime_Medic.Name = "dateTime_Medic";
            this.dateTime_Medic.Size = new System.Drawing.Size(110, 26);
            this.dateTime_Medic.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(618, 33);
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
            this.panel2.Size = new System.Drawing.Size(618, 50);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "Medical History";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 36);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Disease :";
            // 
            // textBox_mDisease
            // 
            this.textBox_mDisease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mDisease.Location = new System.Drawing.Point(78, 122);
            this.textBox_mDisease.Name = "textBox_mDisease";
            this.textBox_mDisease.Size = new System.Drawing.Size(213, 26);
            this.textBox_mDisease.TabIndex = 12;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Location = new System.Drawing.Point(191, 154);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(100, 28);
            this.button_Save.TabIndex = 27;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.mDateDataGridViewTextBoxColumn,
            this.mDiseaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMedicalHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 204);
            this.dataGridView1.TabIndex = 28;
            // 
            // pharmacy_DemoDataSet
            // 
            this.pharmacy_DemoDataSet.DataSetName = "Pharmacy_DemoDataSet";
            this.pharmacy_DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMedicalHistoryBindingSource
            // 
            this.tblMedicalHistoryBindingSource.DataMember = "tbl_MedicalHistory";
            this.tblMedicalHistoryBindingSource.DataSource = this.pharmacy_DemoDataSet;
            // 
            // tbl_MedicalHistoryTableAdapter
            // 
            this.tbl_MedicalHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "mID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mDateDataGridViewTextBoxColumn
            // 
            this.mDateDataGridViewTextBoxColumn.DataPropertyName = "mDate";
            this.mDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.mDateDataGridViewTextBoxColumn.Name = "mDateDataGridViewTextBoxColumn";
            this.mDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mDiseaseDataGridViewTextBoxColumn
            // 
            this.mDiseaseDataGridViewTextBoxColumn.DataPropertyName = "mDisease";
            this.mDiseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.mDiseaseDataGridViewTextBoxColumn.Name = "mDiseaseDataGridViewTextBoxColumn";
            this.mDiseaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Back.Location = new System.Drawing.Point(506, 154);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(100, 28);
            this.button_Back.TabIndex = 29;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.OnBackClick);
            // 
            // MedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 404);
            this.Controls.Add(this.panel1);
            this.Name = "MedicalHistory";
            this.Text = "Medical History";
            this.Load += new System.EventHandler(this.MedicalHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMedicalHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_Medic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mDisease;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Save;
        private Pharmacy_DemoDataSet pharmacy_DemoDataSet;
        private System.Windows.Forms.BindingSource tblMedicalHistoryBindingSource;
        private Pharmacy_DemoDataSetTableAdapters.tbl_MedicalHistoryTableAdapter tbl_MedicalHistoryTableAdapter;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDiseaseDataGridViewTextBoxColumn;
    }
}