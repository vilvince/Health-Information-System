namespace Naje_HealthInformationSystem
{
    partial class form_View_Patient_Table
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
            this.grid_Patient_Table = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Patient_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grid_Patient_Table
            // 
            this.grid_Patient_Table.AllowUserToAddRows = false;
            this.grid_Patient_Table.AllowUserToDeleteRows = false;
            this.grid_Patient_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Patient_Table.Location = new System.Drawing.Point(44, 151);
            this.grid_Patient_Table.Name = "grid_Patient_Table";
            this.grid_Patient_Table.ReadOnly = true;
            this.grid_Patient_Table.RowHeadersWidth = 51;
            this.grid_Patient_Table.RowTemplate.Height = 24;
            this.grid_Patient_Table.Size = new System.Drawing.Size(716, 150);
            this.grid_Patient_Table.TabIndex = 1;
            this.grid_Patient_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(729, 423);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 22);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            // 
            // form_View_Patient_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 502);
            this.Controls.Add(this.back);
            this.Controls.Add(this.grid_Patient_Table);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_View_Patient_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_View_Patient_Table";
            this.Load += new System.EventHandler(this.form_View_Patient_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Patient_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Patient_Table;
        private System.Windows.Forms.Label back;
    }
}