namespace BDSchol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkPass = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.ForeColor = SystemColors.ButtonHighlight;
            checkPass.Location = new Point(336, 222);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(128, 21);
            checkPass.TabIndex = 13;
            checkPass.Text = "показать пароль";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8301888F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(63, 191);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 12;
            label2.Text = "Введите пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8301888F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 145);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 11;
            label1.Text = "Введите логин:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 9.830189F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(195, 261);
            button2.Name = "button2";
            button2.Size = new Size(120, 27);
            button2.TabIndex = 10;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 25);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 25);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9.830189F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(344, 261);
            button1.Name = "button1";
            button1.Size = new Size(120, 27);
            button1.TabIndex = 7;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.8301888F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(244, 91);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 14;
            label3.Text = "Введите данные";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(609, 437);
            Controls.Add(label3);
            Controls.Add(checkPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkPass;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
    }
}