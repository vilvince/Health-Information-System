namespace Naje_HealthInformationSystem
{
    partial class Form_Billing_Table
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
            this.label_Billing = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_PaymentStatus = new System.Windows.Forms.ComboBox();
            this.textBox_AmountDue = new System.Windows.Forms.TextBox();
            this.comboBox_AppointmentID = new System.Windows.Forms.ComboBox();
            this.label_PaymentDate = new System.Windows.Forms.Label();
            this.label_PaymentStatus = new System.Windows.Forms.Label();
            this.label_AmountDue = new System.Windows.Forms.Label();
            this.label_AppointmentID = new System.Windows.Forms.Label();
            this.groupBox_BillingDetails = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Addd = new System.Windows.Forms.Button();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.textBox_PatientId = new System.Windows.Forms.TextBox();
            this.button_GetTotalBill = new System.Windows.Forms.Button();
            this.label_TotalBill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ToggleBills = new System.Windows.Forms.Button();
            this.button_ExportToCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_BillingDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Billing
            // 
            this.label_Billing.AutoSize = true;
            this.label_Billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Billing.Location = new System.Drawing.Point(336, 44);
            this.label_Billing.Name = "label_Billing";
            this.label_Billing.Size = new System.Drawing.Size(193, 38);
            this.label_Billing.TabIndex = 0;
            this.label_Billing.Text = "Billing Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 660);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 204);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(687, 920);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 39);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox_PaymentStatus
            // 
            this.comboBox_PaymentStatus.FormattingEnabled = true;
            this.comboBox_PaymentStatus.Location = new System.Drawing.Point(207, 154);
            this.comboBox_PaymentStatus.Name = "comboBox_PaymentStatus";
            this.comboBox_PaymentStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBox_PaymentStatus.TabIndex = 15;
            this.comboBox_PaymentStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_PaymentStatus_SelectedIndexChanged);
            // 
            // textBox_AmountDue
            // 
            this.textBox_AmountDue.Location = new System.Drawing.Point(207, 86);
            this.textBox_AmountDue.Name = "textBox_AmountDue";
            this.textBox_AmountDue.Size = new System.Drawing.Size(121, 22);
            this.textBox_AmountDue.TabIndex = 14;
            this.textBox_AmountDue.TextChanged += new System.EventHandler(this.textBox_AmountDue_TextChanged);
            // 
            // comboBox_AppointmentID
            // 
            this.comboBox_AppointmentID.FormattingEnabled = true;
            this.comboBox_AppointmentID.Location = new System.Drawing.Point(207, 21);
            this.comboBox_AppointmentID.Name = "comboBox_AppointmentID";
            this.comboBox_AppointmentID.Size = new System.Drawing.Size(121, 24);
            this.comboBox_AppointmentID.TabIndex = 13;
            this.comboBox_AppointmentID.SelectedIndexChanged += new System.EventHandler(this.comboBox_AppointmentID_SelectedIndexChanged);
            // 
            // label_PaymentDate
            // 
            this.label_PaymentDate.AutoSize = true;
            this.label_PaymentDate.Location = new System.Drawing.Point(74, 205);
            this.label_PaymentDate.Name = "label_PaymentDate";
            this.label_PaymentDate.Size = new System.Drawing.Size(92, 16);
            this.label_PaymentDate.TabIndex = 12;
            this.label_PaymentDate.Text = "Payment Date";
            // 
            // label_PaymentStatus
            // 
            this.label_PaymentStatus.AutoSize = true;
            this.label_PaymentStatus.Location = new System.Drawing.Point(74, 154);
            this.label_PaymentStatus.Name = "label_PaymentStatus";
            this.label_PaymentStatus.Size = new System.Drawing.Size(100, 16);
            this.label_PaymentStatus.TabIndex = 11;
            this.label_PaymentStatus.Text = "Payment Status";
            // 
            // label_AmountDue
            // 
            this.label_AmountDue.AutoSize = true;
            this.label_AmountDue.Location = new System.Drawing.Point(74, 92);
            this.label_AmountDue.Name = "label_AmountDue";
            this.label_AmountDue.Size = new System.Drawing.Size(80, 16);
            this.label_AmountDue.TabIndex = 10;
            this.label_AmountDue.Text = "Amount Due";
            // 
            // label_AppointmentID
            // 
            this.label_AppointmentID.AutoSize = true;
            this.label_AppointmentID.Location = new System.Drawing.Point(66, 29);
            this.label_AppointmentID.Name = "label_AppointmentID";
            this.label_AppointmentID.Size = new System.Drawing.Size(98, 16);
            this.label_AppointmentID.TabIndex = 9;
            this.label_AppointmentID.Text = "Appointment ID";
            this.label_AppointmentID.Click += new System.EventHandler(this.label_AppointmentID_Click);
            // 
            // groupBox_BillingDetails
            // 
            this.groupBox_BillingDetails.Controls.Add(this.dateTimePicker1);
            this.groupBox_BillingDetails.Controls.Add(this.comboBox_PaymentStatus);
            this.groupBox_BillingDetails.Controls.Add(this.textBox_AmountDue);
            this.groupBox_BillingDetails.Controls.Add(this.comboBox_AppointmentID);
            this.groupBox_BillingDetails.Controls.Add(this.label_PaymentDate);
            this.groupBox_BillingDetails.Controls.Add(this.label_PaymentStatus);
            this.groupBox_BillingDetails.Controls.Add(this.label_AmountDue);
            this.groupBox_BillingDetails.Controls.Add(this.label_AppointmentID);
            this.groupBox_BillingDetails.Location = new System.Drawing.Point(190, 107);
            this.groupBox_BillingDetails.Name = "groupBox_BillingDetails";
            this.groupBox_BillingDetails.Size = new System.Drawing.Size(545, 263);
            this.groupBox_BillingDetails.TabIndex = 17;
            this.groupBox_BillingDetails.TabStop = false;
            this.groupBox_BillingDetails.Text = "Billing Details";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(585, 393);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(459, 393);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(333, 393);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 42);
            this.button_Update.TabIndex = 19;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(190, 393);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 18;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button_Addd_Click);
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Instruction.Location = new System.Drawing.Point(27, 21);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(345, 22);
            this.label_Instruction.TabIndex = 22;
            this.label_Instruction.Text = "Please enter Patient ID to get the total bill.";
            this.label_Instruction.Click += new System.EventHandler(this.label_Instruction_Click);
            // 
            // textBox_PatientId
            // 
            this.textBox_PatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PatientId.Location = new System.Drawing.Point(31, 46);
            this.textBox_PatientId.Multiline = true;
            this.textBox_PatientId.Name = "textBox_PatientId";
            this.textBox_PatientId.Size = new System.Drawing.Size(97, 33);
            this.textBox_PatientId.TabIndex = 23;
            // 
            // button_GetTotalBill
            // 
            this.button_GetTotalBill.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_GetTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetTotalBill.Location = new System.Drawing.Point(31, 95);
            this.button_GetTotalBill.Name = "button_GetTotalBill";
            this.button_GetTotalBill.Size = new System.Drawing.Size(146, 37);
            this.button_GetTotalBill.TabIndex = 24;
            this.button_GetTotalBill.Text = "Get Total Bill";
            this.button_GetTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GetTotalBill.UseVisualStyleBackColor = false;
            // 
            // label_TotalBill
            // 
            this.label_TotalBill.AutoSize = true;
            this.label_TotalBill.Location = new System.Drawing.Point(246, 106);
            this.label_TotalBill.Name = "label_TotalBill";
            this.label_TotalBill.Size = new System.Drawing.Size(98, 16);
            this.label_TotalBill.TabIndex = 25;
            this.label_TotalBill.Text = "Total Bill: ₱0.00";
            this.label_TotalBill.Click += new System.EventHandler(this.label_TotalBill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_GetTotalBill);
            this.groupBox1.Controls.Add(this.label_TotalBill);
            this.groupBox1.Controls.Add(this.textBox_PatientId);
            this.groupBox1.Controls.Add(this.label_Instruction);
            this.groupBox1.Location = new System.Drawing.Point(49, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 159);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Total bill";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_ToggleBills
            // 
            this.button_ToggleBills.Location = new System.Drawing.Point(530, 618);
            this.button_ToggleBills.Name = "button_ToggleBills";
            this.button_ToggleBills.Size = new System.Drawing.Size(124, 36);
            this.button_ToggleBills.TabIndex = 27;
            this.button_ToggleBills.Text = "Show Unpad Bills";
            this.button_ToggleBills.UseVisualStyleBackColor = true;
            this.button_ToggleBills.Click += new System.EventHandler(this.button_ToggleBills_Click);
            // 
            // button_ExportToCSV
            // 
            this.button_ExportToCSV.Location = new System.Drawing.Point(660, 618);
            this.button_ExportToCSV.Name = "button_ExportToCSV";
            this.button_ExportToCSV.Size = new System.Drawing.Size(138, 36);
            this.button_ExportToCSV.TabIndex = 28;
            this.button_ExportToCSV.Text = "Export to CSV";
            this.button_ExportToCSV.UseVisualStyleBackColor = true;
            this.button_ExportToCSV.Click += new System.EventHandler(this.button_ExportToCSV_Click);
            // 
            // Form_Billing_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 1045);
            this.Controls.Add(this.button_ExportToCSV);
            this.Controls.Add(this.button_ToggleBills);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.groupBox_BillingDetails);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Billing);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Billing_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Billing_Table";
            this.Load += new System.EventHandler(this.Form_Billing_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_BillingDetails.ResumeLayout(false);
            this.groupBox_BillingDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Billing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_PaymentStatus;
        private System.Windows.Forms.TextBox textBox_AmountDue;
        private System.Windows.Forms.ComboBox comboBox_AppointmentID;
        private System.Windows.Forms.Label label_PaymentDate;
        private System.Windows.Forms.Label label_PaymentStatus;
        private System.Windows.Forms.Label label_AmountDue;
        private System.Windows.Forms.Label label_AppointmentID;
        private System.Windows.Forms.GroupBox groupBox_BillingDetails;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Addd;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.TextBox textBox_PatientId;
        private System.Windows.Forms.Button button_GetTotalBill;
        private System.Windows.Forms.Label label_TotalBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ToggleBills;
        private System.Windows.Forms.Button button_ExportToCSV;
    }
}