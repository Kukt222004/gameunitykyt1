namespace BDSchol
{
    partial class BDhome
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
            dataGridView1 = new DataGridView();
            IdClas = new DataGridViewTextBoxColumn();
            nameClas = new DataGridViewTextBoxColumn();
            startYer = new DataGridViewTextBoxColumn();
            button_dowln = new Button();
            button_add = new Button();
            button_delete = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdClas, nameClas, startYer });
            dataGridView1.Location = new Point(22, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1063, 278);
            dataGridView1.TabIndex = 0;
            // 
            // IdClas
            // 
            IdClas.HeaderText = "id класса";
            IdClas.MinimumWidth = 6;
            IdClas.Name = "IdClas";
            IdClas.Width = 200;
            // 
            // nameClas
            // 
            nameClas.HeaderText = "название класса";
            nameClas.MinimumWidth = 6;
            nameClas.Name = "nameClas";
            nameClas.Width = 200;
            // 
            // startYer
            // 
            startYer.HeaderText = "начало обучения";
            startYer.MinimumWidth = 6;
            startYer.Name = "startYer";
            startYer.Width = 200;
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
            // button_add
            // 
            button_add.BackColor = SystemColors.ActiveCaptionText;
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
            button_delete.Location = new Point(497, 24);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(133, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Удалить данные";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(button_delete);
            groupBox1.Controls.Add(button_dowln);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(28, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 102);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "действия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(831, 441);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1027, 441);
            button1.Name = "button1";
            button1.Size = new Size(58, 25);
            button1.TabIndex = 10;
            button1.Text = "поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(762, 401);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 11;
            label1.Text = "Поиск по";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "id класса", "Название класса", "Начало учёбы" });
            comboBox1.Location = new Point(831, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(762, 445);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 13;
            label2.Text = "критерии";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, scriptToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1146, 25);
            menuStrip1.TabIndex = 14;
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
            классыToolStripMenuItem.Size = new Size(198, 24);
            классыToolStripMenuItem.Text = "Классы";
            классыToolStripMenuItem.Click += классыToolStripMenuItem_Click_1;
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
            exithomeToolStripMenuItem1.Click += exithomeToolStripMenuItem1_Click_1;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(221, 24);
            homeToolStripMenuItem.Text = "Выйти из акаунта";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click_1;
            // 
            // BDhome
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
            MinimizeBox = false;
            Name = "BDhome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Классы";
            FormClosing += BDhome_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_dowln;
        private Button button_add;
        private Button button_delete;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exithomeToolStripMenuItem1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem опекуныToolStripMenuItem;
        private ToolStripMenuItem ученикиToolStripMenuItem;
        private ToolStripMenuItem отчисленныеToolStripMenuItem;
        private DataGridViewTextBoxColumn IdClas;
        private DataGridViewTextBoxColumn nameClas;
        private DataGridViewTextBoxColumn startYer;
        private ToolStripMenuItem классыToolStripMenuItem;
    }
}