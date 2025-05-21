namespace Naje_HealthInformationSystem
{
    partial class Form_Add_MedicalRecord
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
            this.label_Findings = new System.Windows.Forms.Label();
            this.label_AppointID = new System.Windows.Forms.Label();
            this.label_Diagnosis = new System.Windows.Forms.Label();
            this.label_Treatment = new System.Windows.Forms.Label();
            this.textBox_AppointmentID = new System.Windows.Forms.TextBox();
            this.textBox_Diagnosis = new System.Windows.Forms.TextBox();
            this.textBox_Treatment = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Findings
            // 
            this.label_Findings.AutoSize = true;
            this.label_Findings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Findings.Location = new System.Drawing.Point(109, 58);
            this.label_Findings.Name = "label_Findings";
            this.label_Findings.Size = new System.Drawing.Size(231, 29);
            this.label_Findings.TabIndex = 0;
            this.label_Findings.Text = "Medical Consulation";
            this.label_Findings.Click += new System.EventHandler(this.label_Findings_Click);
            // 
            // label_AppointID
            // 
            this.label_AppointID.AutoSize = true;
            this.label_AppointID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AppointID.Location = new System.Drawing.Point(27, 155);
            this.label_AppointID.Name = "label_AppointID";
            this.label_AppointID.Size = new System.Drawing.Size(183, 31);
            this.label_AppointID.TabIndex = 1;
            this.label_AppointID.Text = "Appointment ID";
            // 
            // label_Diagnosis
            // 
            this.label_Diagnosis.AutoSize = true;
            this.label_Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Diagnosis.Location = new System.Drawing.Point(36, 274);
            this.label_Diagnosis.Name = "label_Diagnosis";
            this.label_Diagnosis.Size = new System.Drawing.Size(98, 25);
            this.label_Diagnosis.TabIndex = 2;
            this.label_Diagnosis.Text = "Diagnosis";
            this.label_Diagnosis.Click += new System.EventHandler(this.label_Diagnosis_Click);
            // 
            // label_Treatment
            // 
            this.label_Treatment.AutoSize = true;
            this.label_Treatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Treatment.Location = new System.Drawing.Point(33, 396);
            this.label_Treatment.Name = "label_Treatment";
            this.label_Treatment.Size = new System.Drawing.Size(101, 25);
            this.label_Treatment.TabIndex = 3;
            this.label_Treatment.Text = "Treatment";
            this.label_Treatment.Click += new System.EventHandler(this.label_Treatment_Click);
            // 
            // textBox_AppointmentID
            // 
            this.textBox_AppointmentID.Location = new System.Drawing.Point(57, 189);
            this.textBox_AppointmentID.Multiline = true;
            this.textBox_AppointmentID.Name = "textBox_AppointmentID";
            this.textBox_AppointmentID.Size = new System.Drawing.Size(257, 40);
            this.textBox_AppointmentID.TabIndex = 4;
            // 
            // textBox_Diagnosis
            // 
            this.textBox_Diagnosis.Location = new System.Drawing.Point(57, 313);
            this.textBox_Diagnosis.Multiline = true;
            this.textBox_Diagnosis.Name = "textBox_Diagnosis";
            this.textBox_Diagnosis.Size = new System.Drawing.Size(257, 37);
            this.textBox_Diagnosis.TabIndex = 5;
            // 
            // textBox_Treatment
            // 
            this.textBox_Treatment.Location = new System.Drawing.Point(57, 436);
            this.textBox_Treatment.Multiline = true;
            this.textBox_Treatment.Name = "textBox_Treatment";
            this.textBox_Treatment.Size = new System.Drawing.Size(257, 38);
            this.textBox_Treatment.TabIndex = 6;
            this.textBox_Treatment.TextChanged += new System.EventHandler(this.textBox_Treatment_TextChanged);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(323, 503);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 35);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Submit.Location = new System.Drawing.Point(220, 503);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(90, 35);
            this.button_Submit.TabIndex = 8;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            // 
            // Form_Add_MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 565);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_Treatment);
            this.Controls.Add(this.textBox_Diagnosis);
            this.Controls.Add(this.textBox_AppointmentID);
            this.Controls.Add(this.label_Treatment);
            this.Controls.Add(this.label_Diagnosis);
            this.Controls.Add(this.label_AppointID);
            this.Controls.Add(this.label_Findings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_MedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_MedicalRecord";
            this.Load += new System.EventHandler(this.Form_Add_MedicalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Findings;
        private System.Windows.Forms.Label label_AppointID;
        private System.Windows.Forms.Label label_Diagnosis;
        private System.Windows.Forms.Label label_Treatment;
        private System.Windows.Forms.TextBox textBox_AppointmentID;
        private System.Windows.Forms.TextBox textBox_Diagnosis;
        private System.Windows.Forms.TextBox textBox_Treatment;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Submit;
    }
}