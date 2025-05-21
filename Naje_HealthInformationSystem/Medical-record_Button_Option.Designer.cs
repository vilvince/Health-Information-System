namespace Naje_HealthInformationSystem
{
    partial class Medical_record_Button_Option
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
            this.button_Medical_Record_Table = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Deleted_Medical_Records = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose preffered action.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Medical_Record_Table
            // 
            this.button_Medical_Record_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Medical_Record_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Medical_Record_Table.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Medical_Record_Table.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Medical_Record_Table.Location = new System.Drawing.Point(85, 196);
            this.button_Medical_Record_Table.Name = "button_Medical_Record_Table";
            this.button_Medical_Record_Table.Size = new System.Drawing.Size(314, 57);
            this.button_Medical_Record_Table.TabIndex = 1;
            this.button_Medical_Record_Table.Text = "View Medical Record Table";
            this.button_Medical_Record_Table.UseVisualStyleBackColor = false;
            this.button_Medical_Record_Table.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Deleted_Medical_Records
            // 
            this.button_Deleted_Medical_Records.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Deleted_Medical_Records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Deleted_Medical_Records.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Deleted_Medical_Records.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Deleted_Medical_Records.Location = new System.Drawing.Point(85, 271);
            this.button_Deleted_Medical_Records.Name = "button_Deleted_Medical_Records";
            this.button_Deleted_Medical_Records.Size = new System.Drawing.Size(314, 61);
            this.button_Deleted_Medical_Records.TabIndex = 4;
            this.button_Deleted_Medical_Records.Text = "Deleted Medical Records";
            this.button_Deleted_Medical_Records.UseVisualStyleBackColor = false;
            this.button_Deleted_Medical_Records.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Medical_record_Button_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 513);
            this.Controls.Add(this.button_Deleted_Medical_Records);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Medical_Record_Table);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Medical_record_Button_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical_record_Button_Option";
            this.Load += new System.EventHandler(this.Medical_record_Button_Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Medical_Record_Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Deleted_Medical_Records;
    }
}