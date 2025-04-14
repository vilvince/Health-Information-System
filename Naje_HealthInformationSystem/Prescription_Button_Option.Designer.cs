namespace Naje_HealthInformationSystem
{
    partial class Prescription_Button_Option
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Add_Prescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose preffered action.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Back";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(81, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Prescription Table";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Add_Prescription
            // 
            this.button_Add_Prescription.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Add_Prescription.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Prescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add_Prescription.Location = new System.Drawing.Point(81, 268);
            this.button_Add_Prescription.Name = "button_Add_Prescription";
            this.button_Add_Prescription.Size = new System.Drawing.Size(282, 56);
            this.button_Add_Prescription.TabIndex = 3;
            this.button_Add_Prescription.Text = "Add Prescription";
            this.button_Add_Prescription.UseVisualStyleBackColor = false;
            // 
            // Prescription_Button_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 522);
            this.Controls.Add(this.button_Add_Prescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prescription_Button_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Prescription Options";
            this.Load += new System.EventHandler(this.Prescription_Button_Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Add_Prescription;
    }
}