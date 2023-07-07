using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System.Reflection;
using BDScholPeredel;

namespace BDSchol
{
    public partial class BDhome : Form
    {
        public BDhome()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа позволяющая удобно хранить информацию о классах", "Внимание!");
        }

        private void exithomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitpaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }

        int a = 0;
        private void button_dowln_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM clas";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            try
            {
                if (dbReader.HasRows == false)
                {
                    MessageBox.Show("Данные не найдены!", "Ошибка!");
                }
                else
                {
                    while (dbReader.Read())
                    {
                        dataGridView1.Rows.Add(dbReader["IdClas"], dbReader["nameClas"], dbReader["startYer"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                dbReader.Close();
                dbConnection.Close();
            }
            a++;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
               dataGridView1.Rows[index].Cells[1].Value == null ||
               dataGridView1.Rows[index].Cells[2].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }
            string IdClas = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string nameClas = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string startYer = dataGridView1.Rows[index].Cells[2].Value.ToString();


            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO clas VALUES (" + IdClas + ", '" + nameClas + "', " + startYer + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            // Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            //закрытие БД
            dbConnection.Close();
        }



        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string IdClas = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            string query = "DELETE FROM clas WHERE IdClas = " + IdClas;       // строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда

            // Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                // Удаляем данные из таблицы в форме
                dataGridView1.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void BDhome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }

            var search = textBox1.Text;
            var b = comboBox1.Text;


            if (b == "id класса")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM clas WHERE IdClas=" + search;
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                try
                {
                    if (dbReader.HasRows == false)
                    {
                        MessageBox.Show("Данные не найдены!", "Ошибка!");
                    }
                    else
                    {
                        // Чтение данных
                        while (dbReader.Read())
                        {
                            // Выводим данные
                            dataGridView1.Rows.Add(dbReader["IdClas"], dbReader["nameClas"], dbReader["startYer"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
                }
                finally
                {
                    dbReader.Close();
                    dbConnection.Close();
                }
                textBox1.Clear();
            }


            if (b == "Начало учёбы")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM clas WHERE startYer=" + search;
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                try
                {
                    if (dbReader.HasRows == false)
                    {
                        MessageBox.Show("Данные не найдены!", "Ошибка!");
                    }
                    else
                    {
                        // Чтение данных
                        while (dbReader.Read())
                        {
                            // Выводим данные
                            dataGridView1.Rows.Add(dbReader["IdClas"], dbReader["nameClas"], dbReader["startYer"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
                }
                finally
                {
                    dbReader.Close();
                    dbConnection.Close();
                }
                textBox1.Clear();
            }



            if (b == "Название класса")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM clas WHERE nameClas like '%" + search + "%'";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                try
                {
                    if (dbReader.HasRows == false)
                    {
                        MessageBox.Show("Данные не найдены!", "Ошибка!");
                    }
                    else
                    {
                        // Чтение данных
                        while (dbReader.Read())
                        {
                            // Выводим данные
                            dataGridView1.Rows.Add(dbReader["IdClas"], dbReader["nameClas"], dbReader["startYer"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
                }
                finally
                {
                    dbReader.Close();
                    dbConnection.Close();
                }
                textBox1.Clear();
            }
        }

        private void exitpaswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void exithomeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDhome bDhome = new BDhome();
            bDhome.Show();
            this.Hide();
        }

        private void опекуныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents();
            parents.Show();
            this.Hide();
        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students stud = new students();
            stud.Show();
            this.Hide();
        }

        private void классыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BDhome bDhome = new BDhome();
            bDhome.Show();
            this.Hide();
        }

        private void отчисленныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otislv enroll = new otislv();
            enroll.Show();
            this.Hide();
        }
    }
}
