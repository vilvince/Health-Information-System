namespace Naje_HealthInformationSystem
{
    partial class Form_Appointment_Table
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Appointments = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Label();
            this.groupBox_Appointment = new System.Windows.Forms.GroupBox();
            this.comboBox_Reason = new System.Windows.Forms.ComboBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.textBox_DoctorID = new System.Windows.Forms.TextBox();
            this.label_Reason = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_PatientID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label_DoctorID = new System.Windows.Forms.Label();
            this.label_DateAndTime = new System.Windows.Forms.Label();
            this.label_PatientID = new System.Windows.Forms.Label();
            this.button_Addd = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).BeginInit();
            this.groupBox_Appointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointments Table";
            // 
            // dataGridView_Appointments
            // 
            this.dataGridView_Appointments.AllowUserToAddRows = false;
            this.dataGridView_Appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Appointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointments.Location = new System.Drawing.Point(79, 549);
            this.dataGridView_Appointments.Name = "dataGridView_Appointments";
            this.dataGridView_Appointments.ReadOnly = true;
            this.dataGridView_Appointments.RowHeadersWidth = 51;
            this.dataGridView_Appointments.RowTemplate.Height = 24;
            this.dataGridView_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Appointments.Size = new System.Drawing.Size(675, 301);
            this.dataGridView_Appointments.TabIndex = 1;
            this.dataGridView_Appointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Appointments_CellContentClick);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(742, 873);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 25);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // groupBox_Appointment
            // 
            this.groupBox_Appointment.Controls.Add(this.comboBox_Reason);
            this.groupBox_Appointment.Controls.Add(this.comboBox_Status);
            this.groupBox_Appointment.Controls.Add(this.textBox_DoctorID);
            this.groupBox_Appointment.Controls.Add(this.label_Reason);
            this.groupBox_Appointment.Controls.Add(this.label_Status);
            this.groupBox_Appointment.Controls.Add(this.textBox_PatientID);
            this.groupBox_Appointment.Controls.Add(this.dateTimePicker_AppointmentDate);
            this.groupBox_Appointment.Controls.Add(this.label_DoctorID);
            this.groupBox_Appointment.Controls.Add(this.label_DateAndTime);
            this.groupBox_Appointment.Controls.Add(this.label_PatientID);
            this.groupBox_Appointment.Location = new System.Drawing.Point(109, 131);
            this.groupBox_Appointment.Name = "groupBox_Appointment";
            this.groupBox_Appointment.Size = new System.Drawing.Size(645, 296);
            this.groupBox_Appointment.TabIndex = 3;
            this.groupBox_Appointment.TabStop = false;
            this.groupBox_Appointment.Text = "Appointment Details";
            // 
            // comboBox_Reason
            // 
            this.comboBox_Reason.FormattingEnabled = true;
            this.comboBox_Reason.Location = new System.Drawing.Point(160, 243);
            this.comboBox_Reason.Name = "comboBox_Reason";
            this.comboBox_Reason.Size = new System.Drawing.Size(184, 24);
            this.comboBox_Reason.TabIndex = 11;
            this.comboBox_Reason.SelectedIndexChanged += new System.EventHandler(this.comboBox_Reason_SelectedIndexChanged);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(160, 195);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(179, 24);
            this.comboBox_Status.TabIndex = 10;
            // 
            // textBox_DoctorID
            // 
            this.textBox_DoctorID.Location = new System.Drawing.Point(155, 90);
            this.textBox_DoctorID.Multiline = true;
            this.textBox_DoctorID.Name = "textBox_DoctorID";
            this.textBox_DoctorID.Size = new System.Drawing.Size(138, 32);
            this.textBox_DoctorID.TabIndex = 7;
            // 
            // label_Reason
            // 
            this.label_Reason.AutoSize = true;
            this.label_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reason.Location = new System.Drawing.Point(36, 243);
            this.label_Reason.Name = "label_Reason";
            this.label_Reason.Size = new System.Drawing.Size(79, 25);
            this.label_Reason.TabIndex = 6;
            this.label_Reason.Text = "Reason";
            this.label_Reason.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(36, 197);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(68, 25);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "Status";
            this.label_Status.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_PatientID
            // 
            this.textBox_PatientID.Location = new System.Drawing.Point(149, 36);
            this.textBox_PatientID.Multiline = true;
            this.textBox_PatientID.Name = "textBox_PatientID";
            this.textBox_PatientID.Size = new System.Drawing.Size(144, 30);
            this.textBox_PatientID.TabIndex = 4;
            this.textBox_PatientID.TextChanged += new System.EventHandler(this.textBox_PatientID_TextChanged);
            // 
            // dateTimePicker_AppointmentDate
            // 
            this.dateTimePicker_AppointmentDate.Location = new System.Drawing.Point(234, 139);
            this.dateTimePicker_AppointmentDate.Name = "dateTimePicker_AppointmentDate";
            this.dateTimePicker_AppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_AppointmentDate.TabIndex = 3;
            // 
            // label_DoctorID
            // 
            this.label_DoctorID.AutoSize = true;
            this.label_DoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DoctorID.Location = new System.Drawing.Point(36, 97);
            this.label_DoctorID.Name = "label_DoctorID";
            this.label_DoctorID.Size = new System.Drawing.Size(93, 25);
            this.label_DoctorID.TabIndex = 2;
            this.label_DoctorID.Text = "Doctor ID";
            // 
            // label_DateAndTime
            // 
            this.label_DateAndTime.AutoSize = true;
            this.label_DateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateAndTime.Location = new System.Drawing.Point(36, 139);
            this.label_DateAndTime.Name = "label_DateAndTime";
            this.label_DateAndTime.Size = new System.Drawing.Size(140, 25);
            this.label_DateAndTime.TabIndex = 1;
            this.label_DateAndTime.Text = "Date and Time";
            // 
            // label_PatientID
            // 
            this.label_PatientID.AutoSize = true;
            this.label_PatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PatientID.Location = new System.Drawing.Point(36, 41);
            this.label_PatientID.Name = "label_PatientID";
            this.label_PatientID.Size = new System.Drawing.Size(102, 25);
            this.label_PatientID.TabIndex = 0;
            this.label_PatientID.Text = "Patient ID:";
            this.label_PatientID.Click += new System.EventHandler(this.label_PatientID_Click);
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(167, 433);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 4;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(293, 433);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 41);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(423, 433);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(564, 433);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_Appointment_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(839, 945);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.groupBox_Appointment);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView_Appointments);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Appointment_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Appointment_Table";
            this.Load += new System.EventHandler(this.Form_Appointment_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).EndInit();
            this.groupBox_Appointment.ResumeLayout(false);
            this.groupBox_Appointment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Appointments;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.GroupBox groupBox_Appointment;
        private System.Windows.Forms.Label label_DoctorID;
        private System.Windows.Forms.Label label_DateAndTime;
        private System.Windows.Forms.Label label_PatientID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AppointmentDate;
        private System.Windows.Forms.TextBox textBox_PatientID;
        private System.Windows.Forms.Button button_Addd;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Reason;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_DoctorID;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_Reason;
    }
}