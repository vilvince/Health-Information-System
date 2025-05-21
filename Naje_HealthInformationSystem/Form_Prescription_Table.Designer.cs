namespace Naje_HealthInformationSystem
{
    partial class Form_Prescription_Table
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Label();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.textBox_Dosage = new System.Windows.Forms.TextBox();
            this.comboBox_Medication_ID = new System.Windows.Forms.ComboBox();
            this.comboBox_Record_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Addd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prescription Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 494);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(674, 762);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 25);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(311, 209);
            this.textBox_Duration.Multiline = true;
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(143, 27);
            this.textBox_Duration.TabIndex = 16;
            this.textBox_Duration.TextChanged += new System.EventHandler(this.textBox_Duration_TextChanged);
            // 
            // textBox_Dosage
            // 
            this.textBox_Dosage.Location = new System.Drawing.Point(311, 156);
            this.textBox_Dosage.Multiline = true;
            this.textBox_Dosage.Name = "textBox_Dosage";
            this.textBox_Dosage.Size = new System.Drawing.Size(143, 25);
            this.textBox_Dosage.TabIndex = 15;
            this.textBox_Dosage.TextChanged += new System.EventHandler(this.textBox_Dosage_TextChanged);
            // 
            // comboBox_Medication_ID
            // 
            this.comboBox_Medication_ID.FormattingEnabled = true;
            this.comboBox_Medication_ID.Location = new System.Drawing.Point(311, 101);
            this.comboBox_Medication_ID.Name = "comboBox_Medication_ID";
            this.comboBox_Medication_ID.Size = new System.Drawing.Size(143, 24);
            this.comboBox_Medication_ID.TabIndex = 14;
            this.comboBox_Medication_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Medication_ID_SelectedIndexChanged);
            // 
            // comboBox_Record_ID
            // 
            this.comboBox_Record_ID.FormattingEnabled = true;
            this.comboBox_Record_ID.Location = new System.Drawing.Point(311, 38);
            this.comboBox_Record_ID.Name = "comboBox_Record_ID";
            this.comboBox_Record_ID.Size = new System.Drawing.Size(143, 24);
            this.comboBox_Record_ID.TabIndex = 13;
            this.comboBox_Record_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Record_ID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dosage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medication ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Medical Record ID";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(552, 405);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 41);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(411, 405);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 41);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(281, 405);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(120, 41);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Addd
            // 
            this.button_Addd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Addd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addd.Location = new System.Drawing.Point(155, 405);
            this.button_Addd.Name = "button_Addd";
            this.button_Addd.Size = new System.Drawing.Size(120, 41);
            this.button_Addd.TabIndex = 17;
            this.button_Addd.Text = "Add";
            this.button_Addd.UseVisualStyleBackColor = false;
            this.button_Addd.Click += new System.EventHandler(this.button_Addd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Duration);
            this.groupBox1.Controls.Add(this.textBox_Dosage);
            this.groupBox1.Controls.Add(this.comboBox_Medication_ID);
            this.groupBox1.Controls.Add(this.comboBox_Record_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(152, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 259);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription Details";
            // 
            // Form_Prescription_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 833);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Addd);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prescription_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Prescription_Table";
            this.Load += new System.EventHandler(this.Form_Prescription_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.TextBox textBox_Dosage;
        private System.Windows.Forms.ComboBox comboBox_Medication_ID;
        private System.Windows.Forms.ComboBox comboBox_Record_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Addd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}