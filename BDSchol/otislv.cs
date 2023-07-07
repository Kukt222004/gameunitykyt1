using BDSchol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDScholPeredel
{
    public partial class otislv : Form
    {
        public otislv()
        {
            InitializeComponent();
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
            students students = new students();
            students.Show();
            this.Hide();
        }

        private void отчисленныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otislv enroll = new otislv();
            enroll.Show();
            this.Hide();
        }

        private void otislv_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM StudentsD";
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
                        dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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

            string idStudents = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            string query = "DELETE FROM StudentsD WHERE idStudents = " + idStudents;       // строка запроса
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


            if (b == "id ученика")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM studentsD WHERE idStudents=" + search;
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
                            dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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

            if (b == "ФИО")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM studentsD WHERE studName like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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

            if (b == "Дата рождения")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM studentsD WHERE dateBir like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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
            }

            if (b == "СНИЛС")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM studentsD WHERE SNILS like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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
            }


            if (b == "id класса")
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM studentsD WHERE IdClas like '%" + search + "%'";
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
                            dataGridView1.Rows.Add(dbReader["idStudents"], dbReader["studName"], dbReader["dateBir"], dbReader["Phone"], dbReader["SNILS"], dbReader["IdClas"]);
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

            }
        }
    }
}

