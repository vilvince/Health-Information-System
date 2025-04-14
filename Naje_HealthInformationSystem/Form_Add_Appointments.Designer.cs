namespace Naje_HealthInformationSystem
{
    partial class Form_Add_Appointment
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Patient_ID = new System.Windows.Forms.ComboBox();
            this.comboBox_Doctor_ID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Stattus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Saeada", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Apointment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LT Saeada", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reason";
            // 
            // comboBox_Patient_ID
            // 
            this.comboBox_Patient_ID.FormattingEnabled = true;
            this.comboBox_Patient_ID.Location = new System.Drawing.Point(268, 165);
            this.comboBox_Patient_ID.Name = "comboBox_Patient_ID";
            this.comboBox_Patient_ID.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Patient_ID.TabIndex = 6;
            // 
            // comboBox_Doctor_ID
            // 
            this.comboBox_Doctor_ID.FormattingEnabled = true;
            this.comboBox_Doctor_ID.Location = new System.Drawing.Point(268, 219);
            this.comboBox_Doctor_ID.Name = "comboBox_Doctor_ID";
            this.comboBox_Doctor_ID.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Doctor_ID.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 285);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox_Stattus
            // 
            this.comboBox_Stattus.FormattingEnabled = true;
            this.comboBox_Stattus.Location = new System.Drawing.Point(268, 333);
            this.comboBox_Stattus.Name = "comboBox_Stattus";
            this.comboBox_Stattus.Size = new System.Drawing.Size(151, 24);
            this.comboBox_Stattus.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 386);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 27);
            this.textBox1.TabIndex = 10;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(288, 493);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(128, 38);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(422, 493);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 38);
            this.back.TabIndex = 12;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Form_Add_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 556);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_Stattus);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_Doctor_ID);
            this.Controls.Add(this.comboBox_Patient_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Patients";
            this.Load += new System.EventHandler(this.Form_Add_Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Patient_ID;
        private System.Windows.Forms.ComboBox comboBox_Doctor_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Stattus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
    }
}