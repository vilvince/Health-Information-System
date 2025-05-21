namespace Naje_HealthInformationSystem
{
    partial class Form_Add_Billing
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
            this.label_AddBilling = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView_BillingSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillingSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AddBilling
            // 
            this.label_AddBilling.AutoSize = true;
            this.label_AddBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddBilling.Location = new System.Drawing.Point(299, 78);
            this.label_AddBilling.Name = "label_AddBilling";
            this.label_AddBilling.Size = new System.Drawing.Size(229, 36);
            this.label_AddBilling.TabIndex = 0;
            this.label_AddBilling.Text = "Billing Summary";
            this.label_AddBilling.Click += new System.EventHandler(this.label_AddBilling_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView_BillingSummary
            // 
            this.dataGridView_BillingSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillingSummary.Location = new System.Drawing.Point(114, 130);
            this.dataGridView_BillingSummary.Name = "dataGridView_BillingSummary";
            this.dataGridView_BillingSummary.RowHeadersWidth = 51;
            this.dataGridView_BillingSummary.RowTemplate.Height = 24;
            this.dataGridView_BillingSummary.Size = new System.Drawing.Size(589, 294);
            this.dataGridView_BillingSummary.TabIndex = 11;
            // 
            // Form_Add_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.dataGridView_BillingSummary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_AddBilling);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Billing";
            this.Load += new System.EventHandler(this.Form_Add_Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillingSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddBilling;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView_BillingSummary;
    }
}