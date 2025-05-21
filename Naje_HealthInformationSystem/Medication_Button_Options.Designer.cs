namespace Naje_HealthInformationSystem
{
    partial class Medication_Button_Options
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
            this.button_View_Medicine_Table = new System.Windows.Forms.Button();
            this.button_Add_New_Medicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_View_Medicine_Table
            // 
            this.button_View_Medicine_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_View_Medicine_Table.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Medicine_Table.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_View_Medicine_Table.Location = new System.Drawing.Point(80, 198);
            this.button_View_Medicine_Table.Name = "button_View_Medicine_Table";
            this.button_View_Medicine_Table.Size = new System.Drawing.Size(249, 56);
            this.button_View_Medicine_Table.TabIndex = 0;
            this.button_View_Medicine_Table.Text = "View Medicine Table";
            this.button_View_Medicine_Table.UseVisualStyleBackColor = false;
            this.button_View_Medicine_Table.Click += new System.EventHandler(this.button_View_Medicine_Table_Click);
            // 
            // button_Add_New_Medicine
            // 
            this.button_Add_New_Medicine.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Add_New_Medicine.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_New_Medicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add_New_Medicine.Location = new System.Drawing.Point(80, 287);
            this.button_Add_New_Medicine.Name = "button_Add_New_Medicine";
            this.button_Add_New_Medicine.Size = new System.Drawing.Size(249, 50);
            this.button_Add_New_Medicine.TabIndex = 1;
            this.button_Add_New_Medicine.Text = "Add New Medicine";
            this.button_Add_New_Medicine.UseVisualStyleBackColor = false;
            this.button_Add_New_Medicine.Click += new System.EventHandler(this.button_Add_New_Medicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose preffered action.";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(302, 455);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 22);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Medication_Button_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 512);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add_New_Medicine);
            this.Controls.Add(this.button_View_Medicine_Table);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Medication_Button_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medication_Button_Options";
            this.Load += new System.EventHandler(this.Prescription_Button_Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_View_Medicine_Table;
        private System.Windows.Forms.Button button_Add_New_Medicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label back;
    }
}