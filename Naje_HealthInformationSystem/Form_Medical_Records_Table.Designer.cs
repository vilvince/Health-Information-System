namespace Naje_HealthInformationSystem
{
    partial class Form_Medical_Records_Table
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_AppointmentID = new System.Windows.Forms.Label();
            this.label_Diagnosis = new System.Windows.Forms.Label();
            this.label_Treatment = new System.Windows.Forms.Label();
            this.textBox_AppointmentID = new System.Windows.Forms.TextBox();
            this.textBox_Diagnosis = new System.Windows.Forms.TextBox();
            this.textBox_Treatment = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Addd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 512);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients Medical Records";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(711, 805);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 30);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Treatment);
            this.groupBox1.Controls.Add(this.textBox_Diagnosis);
            this.groupBox1.Controls.Add(this.textBox_AppointmentID);
            this.groupBox1.Controls.Add(this.label_Treatment);
            this.groupBox1.Controls.Add(this.label_Diagnosis);
            this.groupBox1.Controls.Add(this.label_AppointmentID);
            this.groupBox1.Location = new System.Drawing.Point(119, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical Records Details";
            // 
            // label_AppointmentID
            // 
            this.label_AppointmentID.AutoSize = true;
            this.label_AppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AppointmentID.Location = new System.Drawing.Point(54, 50);
            this.label_AppointmentID.Name = "label_AppointmentID";
            this.label_AppointmentID.Size = new System.Drawing.Size(190, 31);
            this.label_AppointmentID.TabIndex = 0;
            this.label_AppointmentID.Text = "Appointment ID:";
            // 
            // label_Diagnosis
            // 
            this.label_Diagnosis.AutoSize = true;
            this.label_Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Diagnosis.Location = new System.Drawing.Point(53, 105);
            this.label_Diagnosis.Name = "label_Diagnosis";
            this.label_Diagnosis.Size = new System.Drawing.Size(130, 31);
            this.label_Diagnosis.TabIndex = 1;
            this.label_Diagnosis.Text = "Diagnosis:";
            this.label_Diagnosis.Click += new System.EventHandler(this.label_Diagnosis_Click);
            // 
            // label_Treatment
            // 
            this.label_Treatment.AutoSize = true;
            this.label_Treatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Treatment.Location = new System.Drawing.Point(49, 202);
            this.label_Treatment.Name = "label_Treatment";
            this.label_Treatment.Size = new System.Drawing.Size(107, 25);
            this.label_Treatment.TabIndex = 2;
            this.label_Treatment.Text = "Treatment:";
            // 
            // textBox_AppointmentID
            // 
            this.textBox_AppointmentID.Location = new System.Drawing.Point(240, 50);
            this.textBox_AppointmentID.Multiline = true;
            this.textBox_AppointmentID.Name = "textBox_AppointmentID";
            this.textBox_AppointmentID.Size = new System.Drawing.Size(180, 31);
            this.textBox_AppointmentID.TabIndex = 3;
            this.textBox_AppointmentID.TextChanged += new System.EventHandler(this.textBox_AppointmentID_TextChanged);
            // 
            // textBox_Diagnosis
            // 
            this.textBox_Diagnosis.Location = new System.Drawing.Point(240, 105);
            this.textBox_Diagnosis.Multiline = true;
            this.textBox_Diagnosis.Name = "textBox_Diagnosis";
            this.textBox_Diagnosis.Size = new System.Drawing.Size(212, 61);
            this.textBox_Diagnosis.TabIndex = 4;
            this.textBox_Diagnosis.TextChanged += new System.EventHandler(this.textBox_Diagnosis_TextChanged);
            // 
            // textBox_Treatment
            // 
            this.textBox_Treatment.Location = new System.Drawing.Point(240, 187);
            this.textBox_Treatment.Multiline = true;
            this.textBox_Treatment.Name = "textBox_Treatment";
            this.textBox_Treatment.Size = new System.Drawing.Size(212, 56);
            this.textBox_Treatment.TabIndex = 5;
            this.textBox_Treatment.TextChanged += new System.EventHandler(this.textBox_Treatment_TextChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(571, 431);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(431, 431);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(292, 431);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 42);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(154, 432);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 9;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button_Addd_Click);
            // 
            // Form_Medical_Records_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 854);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Medical_Records_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Medical_Records";
            this.Load += new System.EventHandler(this.Form_Medical_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Treatment;
        private System.Windows.Forms.Label label_Diagnosis;
        private System.Windows.Forms.Label label_AppointmentID;
        private System.Windows.Forms.TextBox textBox_Treatment;
        private System.Windows.Forms.TextBox textBox_Diagnosis;
        private System.Windows.Forms.TextBox textBox_AppointmentID;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Addd;
    }
}