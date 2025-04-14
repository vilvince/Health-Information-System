namespace Naje_HealthInformationSystem
{
    partial class Doctor_Button_OPtions
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
            this.button_Veiw_Doctor_Table = new System.Windows.Forms.Button();
            this.button_Add_New_Doctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Veiw_Doctor_Table
            // 
            this.button_Veiw_Doctor_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Veiw_Doctor_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Veiw_Doctor_Table.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Veiw_Doctor_Table.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Veiw_Doctor_Table.Location = new System.Drawing.Point(31, 223);
            this.button_Veiw_Doctor_Table.Name = "button_Veiw_Doctor_Table";
            this.button_Veiw_Doctor_Table.Size = new System.Drawing.Size(282, 63);
            this.button_Veiw_Doctor_Table.TabIndex = 0;
            this.button_Veiw_Doctor_Table.Text = "View Doctors Table";
            this.button_Veiw_Doctor_Table.UseVisualStyleBackColor = false;
            // 
            // button_Add_New_Doctor
            // 
            this.button_Add_New_Doctor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Add_New_Doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add_New_Doctor.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_New_Doctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add_New_Doctor.Location = new System.Drawing.Point(36, 307);
            this.button_Add_New_Doctor.Name = "button_Add_New_Doctor";
            this.button_Add_New_Doctor.Size = new System.Drawing.Size(277, 57);
            this.button_Add_New_Doctor.TabIndex = 1;
            this.button_Add_New_Doctor.Text = "Add New Doctor";
            this.button_Add_New_Doctor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose preferred actions.";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(269, 435);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 25);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            // 
            // Doctor_Button_OPtions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 512);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add_New_Doctor);
            this.Controls.Add(this.button_Veiw_Doctor_Table);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Doctor_Button_OPtions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Button_OPtions";
            this.Load += new System.EventHandler(this.Doctor_Button_OPtions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Veiw_Doctor_Table;
        private System.Windows.Forms.Button button_Add_New_Doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back;
    }
}