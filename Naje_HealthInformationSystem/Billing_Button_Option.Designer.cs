﻿namespace Naje_HealthInformationSystem
{
    partial class Billing_Button_Option
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
            this.button_View_Billing_Table = new System.Windows.Forms.Button();
            this.button_Add_Billing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Billing_History = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose preferred action.";
            // 
            // button_View_Billing_Table
            // 
            this.button_View_Billing_Table.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_View_Billing_Table.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Billing_Table.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_View_Billing_Table.Location = new System.Drawing.Point(94, 159);
            this.button_View_Billing_Table.Name = "button_View_Billing_Table";
            this.button_View_Billing_Table.Size = new System.Drawing.Size(262, 52);
            this.button_View_Billing_Table.TabIndex = 1;
            this.button_View_Billing_Table.Text = "View Billing Table";
            this.button_View_Billing_Table.UseVisualStyleBackColor = false;
            // 
            // button_Add_Billing
            // 
            this.button_Add_Billing.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Add_Billing.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Billing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Add_Billing.Location = new System.Drawing.Point(94, 226);
            this.button_Add_Billing.Name = "button_Add_Billing";
            this.button_Add_Billing.Size = new System.Drawing.Size(262, 47);
            this.button_Add_Billing.TabIndex = 2;
            this.button_Add_Billing.Text = "Add Billing";
            this.button_Add_Billing.UseVisualStyleBackColor = false;
            this.button_Add_Billing.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Back";
            // 
            // button_Billing_History
            // 
            this.button_Billing_History.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Billing_History.Font = new System.Drawing.Font("LT Saeada", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Billing_History.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Billing_History.Location = new System.Drawing.Point(94, 294);
            this.button_Billing_History.Name = "button_Billing_History";
            this.button_Billing_History.Size = new System.Drawing.Size(262, 44);
            this.button_Billing_History.TabIndex = 4;
            this.button_Billing_History.Text = "Bliing History";
            this.button_Billing_History.UseVisualStyleBackColor = false;
            // 
            // Billing_Button_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 474);
            this.Controls.Add(this.button_Billing_History);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add_Billing);
            this.Controls.Add(this.button_View_Billing_Table);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Billing_Button_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Button_Option";
            this.Load += new System.EventHandler(this.Billing_Button_Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_View_Billing_Table;
        private System.Windows.Forms.Button button_Add_Billing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Billing_History;
    }
}