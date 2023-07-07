namespace BDSchol
{
    partial class Parents
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
            groupBox1 = new GroupBox();
            button_add = new Button();
            button_delete = new Button();
            button_dowln = new Button();
            dataGridView1 = new DataGridView();
            idParen = new DataGridViewTextBoxColumn();
            namePare = new DataGridViewTextBoxColumn();
            dateBir = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            idStudent = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            классыToolStripMenuItem = new ToolStripMenuItem();
            опекуныToolStripMenuItem = new ToolStripMenuItem();
            ученикиToolStripMenuItem = new ToolStripMenuItem();
            отчисленныеToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(button_delete);
            groupBox1.Controls.Add(button_dowln);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(28, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 102);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "действия";
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.ActiveCaptionText;
            button_add.ForeColor = SystemColors.ButtonHighlight;
            button_add.Location = new Point(251, 24);
            button_add.Name = "button_add";
            button_add.Size = new Size(133, 29);
            button_add.TabIndex = 3;
            button_add.Text = "Добавить данные";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ActiveCaptionText;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(494, 24);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(133, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Удалить данные";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_dowln
            // 
            button_dowln.BackColor = SystemColors.ActiveCaptionText;
            button_dowln.Location = new Point(24, 24);
            button_dowln.Name = "button_dowln";
            button_dowln.Size = new Size(133, 29);
            button_dowln.TabIndex = 2;
            button_dowln.Text = "Загрузить данные";
            button_dowln.UseVisualStyleBackColor = false;
            button_dowln.Click += button_dowln_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idParen, namePare, dateBir, phone, idStudent });
            dataGridView1.Location = new Point(22, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1079, 278);
            dataGridView1.TabIndex = 7;
            // 
            // idParen
            // 
            idParen.HeaderText = "id Опекуна";
            idParen.MinimumWidth = 6;
            idParen.Name = "idParen";
            idParen.Width = 180;
            // 
            // namePare
            // 
            namePare.HeaderText = "ФИО Опекуна";
            namePare.MinimumWidth = 6;
            namePare.Name = "namePare";
            namePare.Width = 180;
            // 
            // dateBir
            // 
            dateBir.HeaderText = "дата рождения";
            dateBir.MinimumWidth = 6;
            dateBir.Name = "dateBir";
            dateBir.Width = 180;
            // 
            // phone
            // 
            phone.HeaderText = "телефон";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 180;
            // 
            // idStudent
            // 
            idStudent.HeaderText = "id ученика";
            idStudent.MinimumWidth = 6;
            idStudent.Name = "idStudent";
            idStudent.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(778, 453);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 18;
            label2.Text = "критерии";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id родителя", "ФИО родителя", "дата рождения", "id ученика" });
            comboBox1.Location = new Point(847, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(778, 401);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 16;
            label1.Text = "Поиск по";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1043, 449);
            button1.Name = "button1";
            button1.Size = new Size(58, 25);
            button1.TabIndex = 15;
            button1.Text = "поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(847, 449);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 14;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ButtonHighlight;
            menuStrip2.ImageScalingSize = new Size(18, 18);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1146, 25);
            menuStrip2.TabIndex = 19;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 21);
            toolStripMenuItem1.Text = "Информация";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { классыToolStripMenuItem, опекуныToolStripMenuItem, ученикиToolStripMenuItem, отчисленныеToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(72, 21);
            toolStripMenuItem2.Text = "Таблицы";
            // 
            // классыToolStripMenuItem
            // 
            классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            классыToolStripMenuItem.Size = new Size(198, 24);
            классыToolStripMenuItem.Text = "Классы";
            классыToolStripMenuItem.Click += классыToolStripMenuItem_Click;
            // 
            // опекуныToolStripMenuItem
            // 
            опекуныToolStripMenuItem.Name = "опекуныToolStripMenuItem";
            опекуныToolStripMenuItem.Size = new Size(198, 24);
            опекуныToolStripMenuItem.Text = "Опекуны";
            опекуныToolStripMenuItem.Click += опекуныToolStripMenuItem_Click;
            // 
            // ученикиToolStripMenuItem
            // 
            ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            ученикиToolStripMenuItem.Size = new Size(198, 24);
            ученикиToolStripMenuItem.Text = "Ученики";
            ученикиToolStripMenuItem.Click += ученикиToolStripMenuItem_Click;
            // 
            // отчисленныеToolStripMenuItem
            // 
            отчисленныеToolStripMenuItem.Name = "отчисленныеToolStripMenuItem";
            отчисленныеToolStripMenuItem.Size = new Size(198, 24);
            отчисленныеToolStripMenuItem.Text = "Отчисленные";
            отчисленныеToolStripMenuItem.Click += отчисленныеToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(55, 21);
            toolStripMenuItem3.Text = "Выйти";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(221, 24);
            toolStripMenuItem5.Text = "Выйти на рабочий стол";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(221, 24);
            toolStripMenuItem6.Text = "Выйти из акаунта";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // Parents
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1146, 491);
            Controls.Add(menuStrip2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Parents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Опекуны";
            FormClosing += Parents_FormClosing;
            Load += Parents_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_add;
        private Button button_delete;
        private Button button_dowln;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem классыToolStripMenuItem;
        private ToolStripMenuItem ученикиToolStripMenuItem;
        private ToolStripMenuItem отчисленныеToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem опекуныToolStripMenuItem;
        private DataGridViewTextBoxColumn idParen;
        private DataGridViewTextBoxColumn namePare;
        private DataGridViewTextBoxColumn dateBir;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn idStudent;
    }
}