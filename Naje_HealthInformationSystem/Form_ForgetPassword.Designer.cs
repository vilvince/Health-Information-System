namespace Naje_HealthInformationSystem
{
    partial class Form_ForgetPassword
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
            this.label_ForgetPassword = new System.Windows.Forms.Label();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.label_Question = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ForgetPassword
            // 
            this.label_ForgetPassword.AutoSize = true;
            this.label_ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ForgetPassword.Location = new System.Drawing.Point(74, 45);
            this.label_ForgetPassword.Name = "label_ForgetPassword";
            this.label_ForgetPassword.Size = new System.Drawing.Size(301, 42);
            this.label_ForgetPassword.TabIndex = 0;
            this.label_ForgetPassword.Text = "Forget Password";
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Instruction.Location = new System.Drawing.Point(106, 121);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(222, 17);
            this.label_Instruction.TabIndex = 1;
            this.label_Instruction.Text = "Please answer the question below";
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(94, 218);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(247, 25);
            this.label_Question.TabIndex = 2;
            this.label_Question.Text = "What is your favorite color?";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(120, 308);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(221, 22);
            this.textBox_Answer.TabIndex = 3;
            this.textBox_Answer.TextChanged += new System.EventHandler(this.textBox_Answer_TextChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(279, 359);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(79, 26);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(104, 403);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(0, 25);
            this.label_Password.TabIndex = 5;
            this.label_Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(350, 459);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(73, 30);
            this.button_Back.TabIndex = 6;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 511);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.label_Instruction);
            this.Controls.Add(this.label_ForgetPassword);
            this.Name = "Form_ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ForgetPassword";
            this.Load += new System.EventHandler(this.Form_ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ForgetPassword;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Back;
    }
}