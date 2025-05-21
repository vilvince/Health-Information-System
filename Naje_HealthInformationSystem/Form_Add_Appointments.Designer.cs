namespace Naje_HealthInformationSystem
{
    partial class Form_Add_Appointment
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
            this.back = new System.Windows.Forms.Button();
            this.label_ActiveAppointments = new System.Windows.Forms.Label();
            this.dataGridView_ActiveAppointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ActiveAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(801, 496);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 38);
            this.back.TabIndex = 12;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label_ActiveAppointments
            // 
            this.label_ActiveAppointments.AutoSize = true;
            this.label_ActiveAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ActiveAppointments.Location = new System.Drawing.Point(393, 72);
            this.label_ActiveAppointments.Name = "label_ActiveAppointments";
            this.label_ActiveAppointments.Size = new System.Drawing.Size(230, 29);
            this.label_ActiveAppointments.TabIndex = 13;
            this.label_ActiveAppointments.Text = "Active Appointments";
            // 
            // dataGridView_ActiveAppointment
            // 
            this.dataGridView_ActiveAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ActiveAppointment.Location = new System.Drawing.Point(121, 182);
            this.dataGridView_ActiveAppointment.Name = "dataGridView_ActiveAppointment";
            this.dataGridView_ActiveAppointment.RowHeadersWidth = 51;
            this.dataGridView_ActiveAppointment.RowTemplate.Height = 24;
            this.dataGridView_ActiveAppointment.Size = new System.Drawing.Size(797, 233);
            this.dataGridView_ActiveAppointment.TabIndex = 14;
            this.dataGridView_ActiveAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_Add_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 639);
            this.Controls.Add(this.dataGridView_ActiveAppointment);
            this.Controls.Add(this.label_ActiveAppointments);
            this.Controls.Add(this.back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Patients";
            this.Load += new System.EventHandler(this.Form_Add_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ActiveAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label_ActiveAppointments;
        private System.Windows.Forms.DataGridView dataGridView_ActiveAppointment;
    }
}