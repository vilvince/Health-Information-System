namespace Naje_HealthInformationSystem
{
    partial class Patient_Button_Options
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
            this.button_View_Patients_Table = new System.Windows.Forms.Button();
            this.button_Add_Patients = new System.Windows.Forms.Button();
            this.label_Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose preferred action.";
            // 
            // button_View_Patients_Table
            // 
            this.button_View_Patients_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_View_Patients_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_View_Patients_Table.Font = new System.Drawing.Font("LT Saeada", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Patients_Table.Location = new System.Drawing.Point(78, 195);
            this.button_View_Patients_Table.Name = "button_View_Patients_Table";
            this.button_View_Patients_Table.Size = new System.Drawing.Size(216, 61);
            this.button_View_Patients_Table.TabIndex = 1;
            this.button_View_Patients_Table.Text = "View Patients Table";
            this.button_View_Patients_Table.UseVisualStyleBackColor = false;
            this.button_View_Patients_Table.Click += new System.EventHandler(this.button_View_Patients_Table_Click);
            // 
            // button_Add_Patients
            // 
            this.button_Add_Patients.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Add_Patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add_Patients.Font = new System.Drawing.Font("LT Saeada", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Patients.Location = new System.Drawing.Point(78, 282);
            this.button_Add_Patients.Name = "button_Add_Patients";
            this.button_Add_Patients.Size = new System.Drawing.Size(216, 54);
            this.button_Add_Patients.TabIndex = 2;
            this.button_Add_Patients.Text = "Daily Patient Logs";
            this.button_Add_Patients.UseVisualStyleBackColor = false;
            this.button_Add_Patients.Click += new System.EventHandler(this.button_Add_Patients_Click);
            // 
            // label_Back
            // 
            this.label_Back.AutoSize = true;
            this.label_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Back.Location = new System.Drawing.Point(302, 419);
            this.label_Back.Name = "label_Back";
            this.label_Back.Size = new System.Drawing.Size(38, 16);
            this.label_Back.TabIndex = 3;
            this.label_Back.Text = "Back";
            this.label_Back.Click += new System.EventHandler(this.label_Back_Click);
            // 
            // Patient_Button_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.label_Back);
            this.Controls.Add(this.button_Add_Patients);
            this.Controls.Add(this.button_View_Patients_Table);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Patient_Button_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Button_Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_View_Patients_Table;
        private System.Windows.Forms.Button button_Add_Patients;
        private System.Windows.Forms.Label label_Back;
    }
}