namespace Naje_HealthInformationSystem
{
    partial class Appointment_Button_Option
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
            this.button_View_Appointment_Table = new System.Windows.Forms.Button();
            this.button_View_ActiveAppointment = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose preferred action.";
            // 
            // button_View_Appointment_Table
            // 
            this.button_View_Appointment_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_View_Appointment_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_View_Appointment_Table.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Appointment_Table.ForeColor = System.Drawing.Color.Transparent;
            this.button_View_Appointment_Table.Location = new System.Drawing.Point(62, 193);
            this.button_View_Appointment_Table.Name = "button_View_Appointment_Table";
            this.button_View_Appointment_Table.Size = new System.Drawing.Size(274, 61);
            this.button_View_Appointment_Table.TabIndex = 1;
            this.button_View_Appointment_Table.Text = "View Appointment Table";
            this.button_View_Appointment_Table.UseVisualStyleBackColor = false;
            this.button_View_Appointment_Table.Click += new System.EventHandler(this.button_View_Appointment_Table_Click);
            // 
            // button_View_ActiveAppointment
            // 
            this.button_View_ActiveAppointment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_View_ActiveAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_View_ActiveAppointment.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_ActiveAppointment.ForeColor = System.Drawing.Color.Transparent;
            this.button_View_ActiveAppointment.Location = new System.Drawing.Point(41, 260);
            this.button_View_ActiveAppointment.Name = "button_View_ActiveAppointment";
            this.button_View_ActiveAppointment.Size = new System.Drawing.Size(316, 65);
            this.button_View_ActiveAppointment.TabIndex = 2;
            this.button_View_ActiveAppointment.Text = "View Active Appointments";
            this.button_View_ActiveAppointment.UseVisualStyleBackColor = false;
            this.button_View_ActiveAppointment.Click += new System.EventHandler(this.button_Add_Appointment_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(319, 441);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Appointment_Button_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 480);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button_View_ActiveAppointment);
            this.Controls.Add(this.button_View_Appointment_Table);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointment_Button_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment_Button_Option";
            this.Load += new System.EventHandler(this.Appointment_Button_Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_View_Appointment_Table;
        private System.Windows.Forms.Button button_View_ActiveAppointment;
        private System.Windows.Forms.Label back;
    }
}