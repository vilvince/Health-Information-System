namespace Naje_HealthInformationSystem
{
    partial class Form_Add_Prescription
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Record_ID = new System.Windows.Forms.ComboBox();
            this.comboBox_Medication_ID = new System.Windows.Forms.ComboBox();
            this.textBox_Dosage = new System.Windows.Forms.TextBox();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Prescription";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medical Record ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medication ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dosage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration";
            // 
            // comboBox_Record_ID
            // 
            this.comboBox_Record_ID.FormattingEnabled = true;
            this.comboBox_Record_ID.Location = new System.Drawing.Point(313, 161);
            this.comboBox_Record_ID.Name = "comboBox_Record_ID";
            this.comboBox_Record_ID.Size = new System.Drawing.Size(143, 24);
            this.comboBox_Record_ID.TabIndex = 5;
            // 
            // comboBox_Medication_ID
            // 
            this.comboBox_Medication_ID.FormattingEnabled = true;
            this.comboBox_Medication_ID.Location = new System.Drawing.Point(313, 224);
            this.comboBox_Medication_ID.Name = "comboBox_Medication_ID";
            this.comboBox_Medication_ID.Size = new System.Drawing.Size(143, 24);
            this.comboBox_Medication_ID.TabIndex = 6;
            // 
            // textBox_Dosage
            // 
            this.textBox_Dosage.Location = new System.Drawing.Point(313, 279);
            this.textBox_Dosage.Multiline = true;
            this.textBox_Dosage.Name = "textBox_Dosage";
            this.textBox_Dosage.Size = new System.Drawing.Size(143, 25);
            this.textBox_Dosage.TabIndex = 7;
            this.textBox_Dosage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(313, 332);
            this.textBox_Duration.Multiline = true;
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(143, 27);
            this.textBox_Duration.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(296, 397);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(129, 35);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(440, 397);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 35);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form_Add_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox_Duration);
            this.Controls.Add(this.textBox_Dosage);
            this.Controls.Add(this.comboBox_Medication_ID);
            this.Controls.Add(this.comboBox_Record_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Prescription";
            this.Load += new System.EventHandler(this.Form_Add_Prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Record_ID;
        private System.Windows.Forms.ComboBox comboBox_Medication_ID;
        private System.Windows.Forms.TextBox textBox_Dosage;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
    }
}