using BDScholPeredel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSchol
{
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }

        private void exitpaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }

        private void exithomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void students_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int a = 0;
        int b = 0;
        private void button_dowln_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
            if (b > 0)
            {
                while (dataGridView2.Rows.Count > 1)
                {
                    dataGridView2.Rows.RemoveAt(0);
                }
            }
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM students";
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
            string CCconnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection DDdbConnection = new OleDbConnection(CCconnectionString);

            DDdbConnection.Open();
            string QQquery = "SELECT * FROM parents";
            OleDbCommand DDdbCommand = new OleDbCommand(QQquery, DDdbConnection);
            OleDbDataReader DDdbReader = DDdbCommand.ExecuteReader();
            while (DDdbReader.Read())
            {
                // Выводим данные
                dataGridView2.Rows.Add(DDdbReader["idParen"], DDdbReader["namePare"], DDdbReader["dateBir"], DDdbReader["phone"], DDdbReader["idStudent"]);
            }
            a++;
            b++;
            DDdbConnection.Close();
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
            string idStudents = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string studName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string dateBir = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Phone = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string SNILS = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string IdClas = dataGridView1.Rows[index].Cells[5].Value.ToString();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO students VALUES (" + idStudents + ", '" + studName + "', '" + dateBir + "'," + Phone + ", " + SNILS + "," + IdClas + ")";
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

            string idStudents = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string studName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string dateBir = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Phone = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string SNILS = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string IdClas = dataGridView1.Rows[index].Cells[5].Value.ToString();

            string search = idStudents;

            string connectionSString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deduct.mdb";
            OleDbConnection dbCConnection = new OleDbConnection(connectionSString);
            dbCConnection.Open();
            string Qquery = "INSERT INTO StudentsD VALUES (" + idStudents + ", '" + studName + "', '" + dateBir + "'," + Phone + ", " + SNILS + "," + IdClas + ")";
            OleDbCommand ddbCommand = new OleDbCommand(Qquery, dbCConnection);
            // Выполняем запрос
            if (ddbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Ученик отчислен", "Внимание!");

            //закрытие БД
            dbCConnection.Close();


            //Удаление записи
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            string query = "DELETE FROM students WHERE idStudents = " + idStudents;       // строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда

            // Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные перенесены из таблицы!", "Внимание!");
                // Удаляем данные из таблицы в форме
                dataGridView1.Rows.RemoveAt(index);
            }
            dbConnection.Close();
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
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM students WHERE idStudents=" + search;
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
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM students WHERE studName like '%" + search + "%'";
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
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM students WHERE dateBir like '%" + search + "%'";
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
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM students WHERE SNILS like '%" + search + "%'";
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
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = "SELECT * FROM students WHERE IdClas like '%" + search + "%'";
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

        private void опекуныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents();
            parents.Show();
            this.Hide();
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDhome bDhome = new BDhome();
            bDhome.Show();
            this.Hide();
        }

        private void зачислитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();
            enroll.Show();
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

        private void exithomeToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }
    }
}
