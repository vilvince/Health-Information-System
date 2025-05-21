namespace Naje_HealthInformationSystem
{
    partial class form_View_Patient_Table
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
            this.dataGridView_Patients = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Addd = new System.Windows.Forms.Button();
            this.groupBox_DoctorDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_ContactNumber = new System.Windows.Forms.TextBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_ContactNumber = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.comboBox_FilterStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patients)).BeginInit();
            this.groupBox_DoctorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_Patients
            // 
            this.dataGridView_Patients.AllowUserToAddRows = false;
            this.dataGridView_Patients.AllowUserToDeleteRows = false;
            this.dataGridView_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patients.Location = new System.Drawing.Point(44, 601);
            this.dataGridView_Patients.Name = "dataGridView_Patients";
            this.dataGridView_Patients.ReadOnly = true;
            this.dataGridView_Patients.RowHeadersWidth = 51;
            this.dataGridView_Patients.RowTemplate.Height = 24;
            this.dataGridView_Patients.Size = new System.Drawing.Size(716, 215);
            this.dataGridView_Patients.TabIndex = 1;
            this.dataGridView_Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(710, 875);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 22);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(568, 482);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 13;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(428, 482);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(289, 482);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 42);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(151, 483);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 10;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button_Addd_Click);
            // 
            // groupBox_DoctorDetails
            // 
            this.groupBox_DoctorDetails.Controls.Add(this.label2);
            this.groupBox_DoctorDetails.Controls.Add(this.comboBox_Status);
            this.groupBox_DoctorDetails.Controls.Add(this.dateTimePicker_Birthdate);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_Email);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Email);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_Address);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Address);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_ContactNumber);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_Gender);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_LastName);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_FirstName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_ContactNumber);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Birthday);
            this.groupBox_DoctorDetails.Controls.Add(this.label_LastName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_FirstName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Gender);
            this.groupBox_DoctorDetails.Location = new System.Drawing.Point(105, 40);
            this.groupBox_DoctorDetails.Name = "groupBox_DoctorDetails";
            this.groupBox_DoctorDetails.Size = new System.Drawing.Size(655, 413);
            this.groupBox_DoctorDetails.TabIndex = 9;
            this.groupBox_DoctorDetails.TabStop = false;
            this.groupBox_DoctorDetails.Text = "Doctor Details";
            this.groupBox_DoctorDetails.Enter += new System.EventHandler(this.groupBox_DoctorDetails_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(235, 371);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(145, 24);
            this.comboBox_Status.TabIndex = 14;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker_Birthdate
            // 
            this.dateTimePicker_Birthdate.Location = new System.Drawing.Point(235, 142);
            this.dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            this.dateTimePicker_Birthdate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Birthdate.TabIndex = 14;
            this.dateTimePicker_Birthdate.ValueChanged += new System.EventHandler(this.dateTimePicker_Birthdate_ValueChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(234, 327);
            this.textBox_Email.Multiline = true;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(146, 29);
            this.textBox_Email.TabIndex = 13;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(34, 327);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(66, 25);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Email:";
            this.label_Email.Click += new System.EventHandler(this.label_Email_Click_1);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(230, 272);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(152, 32);
            this.textBox_Address.TabIndex = 11;
            this.textBox_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(28, 273);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(91, 25);
            this.label_Address.TabIndex = 10;
            this.label_Address.Text = "Address:";
            this.label_Address.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_ContactNumber
            // 
            this.textBox_ContactNumber.Location = new System.Drawing.Point(232, 223);
            this.textBox_ContactNumber.Multiline = true;
            this.textBox_ContactNumber.Name = "textBox_ContactNumber";
            this.textBox_ContactNumber.Size = new System.Drawing.Size(148, 25);
            this.textBox_ContactNumber.TabIndex = 9;
            this.textBox_ContactNumber.TextChanged += new System.EventHandler(this.textBox_ContactNumber_TextChanged);
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(230, 178);
            this.textBox_Gender.Multiline = true;
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(150, 25);
            this.textBox_Gender.TabIndex = 8;
            this.textBox_Gender.TextChanged += new System.EventHandler(this.textBox_Gender_TextChanged);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(231, 84);
            this.textBox_LastName.Multiline = true;
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(151, 29);
            this.textBox_LastName.TabIndex = 6;
            this.textBox_LastName.TextChanged += new System.EventHandler(this.textBox_LastName_TextChanged);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(232, 33);
            this.textBox_FirstName.Multiline = true;
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(149, 31);
            this.textBox_FirstName.TabIndex = 5;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox_FirstName_TextChanged);
            // 
            // label_ContactNumber
            // 
            this.label_ContactNumber.AutoSize = true;
            this.label_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContactNumber.Location = new System.Drawing.Point(25, 219);
            this.label_ContactNumber.Name = "label_ContactNumber";
            this.label_ContactNumber.Size = new System.Drawing.Size(160, 25);
            this.label_ContactNumber.TabIndex = 4;
            this.label_ContactNumber.Text = "Contact Number:";
            this.label_ContactNumber.Click += new System.EventHandler(this.label_Email_Click);
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birthday.Location = new System.Drawing.Point(28, 134);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(89, 25);
            this.label_Birthday.TabIndex = 2;
            this.label_Birthday.Text = "Birthday:";
            this.label_Birthday.Click += new System.EventHandler(this.label_Specialty_Click);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(25, 88);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(112, 25);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(25, 39);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(112, 25);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(25, 178);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(83, 25);
            this.label_Gender.TabIndex = 3;
            this.label_Gender.Text = "Gender:";
            this.label_Gender.Click += new System.EventHandler(this.label_Gender_Click);
            // 
            // comboBox_FilterStatus
            // 
            this.comboBox_FilterStatus.FormattingEnabled = true;
            this.comboBox_FilterStatus.Location = new System.Drawing.Point(637, 562);
            this.comboBox_FilterStatus.Name = "comboBox_FilterStatus";
            this.comboBox_FilterStatus.Size = new System.Drawing.Size(108, 24);
            this.comboBox_FilterStatus.TabIndex = 14;
            this.comboBox_FilterStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterStatus_SelectedIndexChanged);
            // 
            // form_View_Patient_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 918);
            this.Controls.Add(this.comboBox_FilterStatus);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.groupBox_DoctorDetails);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView_Patients);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_View_Patient_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_View_Patient_Table";
            this.Load += new System.EventHandler(this.form_View_Patient_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patients)).EndInit();
            this.groupBox_DoctorDetails.ResumeLayout(false);
            this.groupBox_DoctorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Patients;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Addd;
        private System.Windows.Forms.GroupBox groupBox_DoctorDetails;
        private System.Windows.Forms.TextBox textBox_ContactNumber;
        private System.Windows.Forms.TextBox textBox_Gender;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_ContactNumber;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthdate;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_FilterStatus;
    }
}