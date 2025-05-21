namespace Naje_HealthInformationSystem
{
    partial class Form_Add_Doctor
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
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_DoctorWorkload = new System.Windows.Forms.DataGridView();
            this.textBox_DoctorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoctorWorkload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada Med", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Overload";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.Control;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(518, 493);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(117, 34);
            this.button_back.TabIndex = 12;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView_DoctorWorkload
            // 
            this.dataGridView_DoctorWorkload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DoctorWorkload.Location = new System.Drawing.Point(17, 155);
            this.dataGridView_DoctorWorkload.Name = "dataGridView_DoctorWorkload";
            this.dataGridView_DoctorWorkload.RowHeadersWidth = 51;
            this.dataGridView_DoctorWorkload.RowTemplate.Height = 24;
            this.dataGridView_DoctorWorkload.Size = new System.Drawing.Size(617, 302);
            this.dataGridView_DoctorWorkload.TabIndex = 13;
            this.dataGridView_DoctorWorkload.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DoctorWorkload_CellContentClick);
            // 
            // textBox_DoctorID
            // 
            this.textBox_DoctorID.Location = new System.Drawing.Point(31, 111);
            this.textBox_DoctorID.Name = "textBox_DoctorID";
            this.textBox_DoctorID.Size = new System.Drawing.Size(105, 22);
            this.textBox_DoctorID.TabIndex = 14;
            this.textBox_DoctorID.TextChanged += new System.EventHandler(this.textBox_DoctorID_TextChanged);
            // 
            // Form_Add_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 558);
            this.Controls.Add(this.textBox_DoctorID);
            this.Controls.Add(this.dataGridView_DoctorWorkload);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Doctor";
            this.Load += new System.EventHandler(this.Form_Add_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DoctorWorkload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_DoctorWorkload;
        private System.Windows.Forms.TextBox textBox_DoctorID;
    }
}