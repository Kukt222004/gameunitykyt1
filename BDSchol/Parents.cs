using BDScholPeredel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSchol
{
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
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
            string query = "SELECT * FROM parents";
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
                        dataGridView1.Rows.Add(dbReader["idParen"], dbReader["namePare"], dbReader["dateBir"], dbReader["phone"], dbReader["idStudent"]);
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

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа позволяющая удобно хранить информацию о родителях учащихся", "Внимание!");

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
            string idParen = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string namePare = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string DateBir = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string phone = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string idStudent = dataGridView1.Rows[index].Cells[4].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO parents VALUES (" + idParen + ", '" + namePare + "', '" + DateBir + "'," + phone + ", " + idStudent + ")";
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

            string idParen = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            string query = "DELETE FROM parents WHERE idParen = " + idParen;       // строка запроса
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

        private void exitpaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exithomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }

        private void Parents_FormClosing(object sender, FormClosingEventArgs e)
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

            if (b == "id родителя")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM parents WHERE idParen=" + search;
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
                            dataGridView1.Rows.Add(dbReader["idParen"], dbReader["namePare"], dbReader["dateBir"], dbReader["phone"], dbReader["idStudent"]);
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

            if (b == "ФИО родителя")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM parents WHERE namePare like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idParen"], dbReader["namePare"], dbReader["dateBir"], dbReader["phone"], dbReader["idStudent"]);
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

            if (b == "дата рождения")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM parents WHERE dateBir like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idParen"], dbReader["namePare"], dbReader["dateBir"], dbReader["phone"], dbReader["idStudent"]);
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

            if (b == "id ученика")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM parents WHERE idStudent=" + search;
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
                            dataGridView1.Rows.Add(dbReader["idParen"], dbReader["namePare"], dbReader["dateBir"], dbReader["phone"], dbReader["idStudent"]);
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

        private void Parents_Load(object sender, EventArgs e)
        {

        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDhome bDhome = new BDhome();
            bDhome.Show();
            this.Hide();
        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students stud = new students();
            stud.Show();
            this.Hide();
        }

        private void опекуныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents();
            parents.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
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
