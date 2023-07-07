namespace BDScholPeredel
{
    partial class otislv
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
            menuStrip1 = new MenuStrip();
            infoToolStripMenuItem = new ToolStripMenuItem();
            scriptToolStripMenuItem = new ToolStripMenuItem();
            классыToolStripMenuItem = new ToolStripMenuItem();
            опекуныToolStripMenuItem = new ToolStripMenuItem();
            ученикиToolStripMenuItem = new ToolStripMenuItem();
            отчисленныеToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            exithomeToolStripMenuItem1 = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button_delete = new Button();
            button_dowln = new Button();
            dataGridView1 = new DataGridView();
            idStudents = new DataGridViewTextBoxColumn();
            studName = new DataGridViewTextBoxColumn();
            dateBir = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            SNILS = new DataGridViewTextBoxColumn();
            IdClas = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, scriptToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1146, 25);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(99, 21);
            infoToolStripMenuItem.Text = "Информация";
            // 
            // scriptToolStripMenuItem
            // 
            scriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { классыToolStripMenuItem, опекуныToolStripMenuItem, ученикиToolStripMenuItem, отчисленныеToolStripMenuItem });
            scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            scriptToolStripMenuItem.Size = new Size(72, 21);
            scriptToolStripMenuItem.Text = "Таблицы";
            // 
            // классыToolStripMenuItem
            // 
            классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            классыToolStripMenuItem.Size = new Size(161, 24);
            классыToolStripMenuItem.Text = "Классы";
            классыToolStripMenuItem.Click += классыToolStripMenuItem_Click;
            // 
            // опекуныToolStripMenuItem
            // 
            опекуныToolStripMenuItem.Name = "опекуныToolStripMenuItem";
            опекуныToolStripMenuItem.Size = new Size(161, 24);
            опекуныToolStripMenuItem.Text = "Опекуны";
            опекуныToolStripMenuItem.Click += опекуныToolStripMenuItem_Click;
            // 
            // ученикиToolStripMenuItem
            // 
            ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            ученикиToolStripMenuItem.Size = new Size(161, 24);
            ученикиToolStripMenuItem.Text = "Ученики";
            ученикиToolStripMenuItem.Click += ученикиToolStripMenuItem_Click;
            // 
            // отчисленныеToolStripMenuItem
            // 
            отчисленныеToolStripMenuItem.Name = "отчисленныеToolStripMenuItem";
            отчисленныеToolStripMenuItem.Size = new Size(161, 24);
            отчисленныеToolStripMenuItem.Text = "Отчисленные";
            отчисленныеToolStripMenuItem.Click += отчисленныеToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exithomeToolStripMenuItem1, homeToolStripMenuItem });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(55, 21);
            exitToolStripMenuItem.Text = "Выйти";
            // 
            // exithomeToolStripMenuItem1
            // 
            exithomeToolStripMenuItem1.Name = "exithomeToolStripMenuItem1";
            exithomeToolStripMenuItem1.Size = new Size(221, 24);
            exithomeToolStripMenuItem1.Text = "Выйти на рабочий стол";
            exithomeToolStripMenuItem1.Click += exithomeToolStripMenuItem1_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(221, 24);
            homeToolStripMenuItem.Text = "Выйти из акаунта";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(778, 459);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 27;
            label2.Text = "критерии";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id ученика", "ФИО", "Дата рождения", "СНИЛС", "id класса" });
            comboBox1.Location = new Point(847, 407);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(778, 407);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 25;
            label1.Text = "Поиск по";
            // 
            // button1
            // 
            button1.Location = new Point(1043, 455);
            button1.Name = "button1";
            button1.Size = new Size(58, 25);
            button1.TabIndex = 24;
            button1.Text = "поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(847, 455);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_delete);
            groupBox1.Controls.Add(button_dowln);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(22, 383);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 102);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "действия";
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ActiveCaptionText;
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(191, 24);
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
            button_dowln.ForeColor = SystemColors.ButtonHighlight;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idStudents, studName, dateBir, Phone, SNILS, IdClas });
            dataGridView1.Location = new Point(22, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1112, 278);
            dataGridView1.TabIndex = 21;
            // 
            // idStudents
            // 
            idStudents.HeaderText = "id ученика";
            idStudents.MinimumWidth = 6;
            idStudents.Name = "idStudents";
            idStudents.Width = 175;
            // 
            // studName
            // 
            studName.HeaderText = "ФИО";
            studName.MinimumWidth = 6;
            studName.Name = "studName";
            studName.Width = 175;
            // 
            // dateBir
            // 
            dateBir.HeaderText = "Дата рождения";
            dateBir.MinimumWidth = 6;
            dateBir.Name = "dateBir";
            dateBir.Width = 175;
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 175;
            // 
            // SNILS
            // 
            SNILS.HeaderText = "СНИЛС";
            SNILS.MinimumWidth = 6;
            SNILS.Name = "SNILS";
            SNILS.Width = 175;
            // 
            // IdClas
            // 
            IdClas.HeaderText = "Id класса";
            IdClas.MinimumWidth = 6;
            IdClas.Name = "IdClas";
            IdClas.Width = 175;
            // 
            // otislv
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1146, 491);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "otislv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "otislv";
            FormClosing += otislv_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
        private ToolStripMenuItem классыToolStripMenuItem;
        private ToolStripMenuItem опекуныToolStripMenuItem;
        private ToolStripMenuItem ученикиToolStripMenuItem;
        private ToolStripMenuItem отчисленныеToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exithomeToolStripMenuItem1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button_delete;
        private Button button_dowln;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idStudents;
        private DataGridViewTextBoxColumn studName;
        private DataGridViewTextBoxColumn dateBir;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn SNILS;
        private DataGridViewTextBoxColumn IdClas;
    }
}