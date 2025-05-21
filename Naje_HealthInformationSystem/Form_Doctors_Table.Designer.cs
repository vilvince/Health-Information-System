namespace Naje_HealthInformationSystem
{
    partial class Form_Doctors_Table
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
            this.Back = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_DoctorDetails = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_ContactNumber = new System.Windows.Forms.TextBox();
            this.textBox_Specialty = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Specialty = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_ContactNumber = new System.Windows.Forms.Label();
            this.button_Addd = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_DoctorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors Table";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(687, 839);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 22);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 530);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 292);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_DoctorDetails
            // 
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_Email);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_ContactNumber);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_Specialty);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_LastName);
            this.groupBox_DoctorDetails.Controls.Add(this.textBox_FirstName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Email);
            this.groupBox_DoctorDetails.Controls.Add(this.label_Specialty);
            this.groupBox_DoctorDetails.Controls.Add(this.label_LastName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_FirstName);
            this.groupBox_DoctorDetails.Controls.Add(this.label_ContactNumber);
            this.groupBox_DoctorDetails.Location = new System.Drawing.Point(82, 162);
            this.groupBox_DoctorDetails.Name = "groupBox_DoctorDetails";
            this.groupBox_DoctorDetails.Size = new System.Drawing.Size(655, 264);
            this.groupBox_DoctorDetails.TabIndex = 3;
            this.groupBox_DoctorDetails.TabStop = false;
            this.groupBox_DoctorDetails.Text = "Doctor Details";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(232, 223);
            this.textBox_Email.Multiline = true;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(148, 25);
            this.textBox_Email.TabIndex = 9;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // textBox_ContactNumber
            // 
            this.textBox_ContactNumber.Location = new System.Drawing.Point(230, 178);
            this.textBox_ContactNumber.Multiline = true;
            this.textBox_ContactNumber.Name = "textBox_ContactNumber";
            this.textBox_ContactNumber.Size = new System.Drawing.Size(150, 25);
            this.textBox_ContactNumber.TabIndex = 8;
            this.textBox_ContactNumber.TextChanged += new System.EventHandler(this.textBox_ContactNumber_TextChanged);
            // 
            // textBox_Specialty
            // 
            this.textBox_Specialty.Location = new System.Drawing.Point(230, 126);
            this.textBox_Specialty.Multiline = true;
            this.textBox_Specialty.Name = "textBox_Specialty";
            this.textBox_Specialty.Size = new System.Drawing.Size(150, 33);
            this.textBox_Specialty.TabIndex = 7;
            this.textBox_Specialty.TextChanged += new System.EventHandler(this.textBox_Specialty_TextChanged);
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
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(28, 219);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(66, 25);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Email:";
            this.label_Email.Click += new System.EventHandler(this.label_Email_Click);
            // 
            // label_Specialty
            // 
            this.label_Specialty.AutoSize = true;
            this.label_Specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Specialty.Location = new System.Drawing.Point(28, 134);
            this.label_Specialty.Name = "label_Specialty";
            this.label_Specialty.Size = new System.Drawing.Size(98, 25);
            this.label_Specialty.TabIndex = 2;
            this.label_Specialty.Text = "Specialty:";
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
            this.label_FirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_ContactNumber
            // 
            this.label_ContactNumber.AutoSize = true;
            this.label_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContactNumber.Location = new System.Drawing.Point(25, 178);
            this.label_ContactNumber.Name = "label_ContactNumber";
            this.label_ContactNumber.Size = new System.Drawing.Size(160, 25);
            this.label_ContactNumber.TabIndex = 3;
            this.label_ContactNumber.Text = "Contact Number:";
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(147, 445);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 5;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button_Addd_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(285, 444);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 42);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(424, 444);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(564, 444);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_Doctors_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 891);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.groupBox_DoctorDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Doctors_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Doctors_Table";
            this.Load += new System.EventHandler(this.Form_Doctors_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_DoctorDetails.ResumeLayout(false);
            this.groupBox_DoctorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_DoctorDetails;
        private System.Windows.Forms.Label label_ContactNumber;
        private System.Windows.Forms.Label label_Specialty;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_ContactNumber;
        private System.Windows.Forms.TextBox textBox_Specialty;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Button button_Addd;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
    }
}