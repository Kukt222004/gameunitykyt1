using BDScholPeredel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDSchol
{
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
        }

        private void Enroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        int a = 1;
        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != " " || textBox14.Text != " " || textBox13.Text != " " || textBox12.Text != " ")
            {
                a++;
            }
            else
            {
                MessageBox.Show("Есть пустое поле, заполните его!!!", "Внимание!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idclas = "";
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || comboBox1.Text != "")
            {

                if ("1а" == comboBox1.Text) { idclas = "21"; }
                if ("1б" == comboBox1.Text) { idclas = "20"; }
                if ("2а" == comboBox1.Text) { idclas = "19"; }
                if ("2б" == comboBox1.Text) { idclas = "18"; }
                if ("3а" == comboBox1.Text) { idclas = "17"; }
                if ("3б" == comboBox1.Text) { idclas = "16"; }
                if ("4а" == comboBox1.Text) { idclas = "15"; }
                if ("4б" == comboBox1.Text) { idclas = "14"; }
                if ("5а" == comboBox1.Text) { idclas = "12"; }
                if ("5б" == comboBox1.Text) { idclas = "11"; }
                if ("6а" == comboBox1.Text) { idclas = "10"; }
                if ("6б" == comboBox1.Text) { idclas = "9"; }
                if ("7а" == comboBox1.Text) { idclas = "8"; }
                if ("7б" == comboBox1.Text) { idclas = "7"; }
                if ("8а" == comboBox1.Text) { idclas = "6"; }
                if ("8б" == comboBox1.Text) { idclas = "5"; }
                if ("9а" == comboBox1.Text) { idclas = "4"; }
                if ("9б" == comboBox1.Text) { idclas = "3"; }
                if ("10" == comboBox1.Text) { idclas = "2"; }
                if ("11" == comboBox1.Text) { idclas = "1"; }
                //зачисление ученика начало
                string idStudents = textBox1.Text;
                string studName = textBox2.Text;
                string dateBir = textBox3.Text;
                string Phone = textBox4.Text;
                string SNILS = textBox5.Text;
                string IdClas = idclas;

                string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection dbconnection = new OleDbConnection(ConnectionString);

                dbconnection.Open();
                string Query = "INSERT INTO students VALUES (" + idStudents + ", '" + studName + "', '" + dateBir + "'," + Phone + ", " + SNILS + "," + IdClas + ")";
                OleDbCommand dbcommand = new OleDbCommand(Query, dbconnection);
                // Выполняем запрос
                if (dbcommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные о ученике добавлены!", "Внимание!");
                //закрытие БД
                dbconnection.Close();
                //конец зачисления ученика

            }
            else
            {
                MessageBox.Show("Есть пустое поле, заполните его!!!", "Внимание!");
            }

            string idParen = textBox10.Text;
            string namePare = textBox9.Text;
            string DateBir = textBox8.Text;
            string phone = textBox7.Text;
            string idStudent = textBox1.Text;




            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO parents VALUES (" + idParen + ", '" + namePare + "', '" + DateBir + "'," + phone + ", " + idStudent + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            // Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
                MessageBox.Show("Данные о родители 1 добавлены!", "Внимание!");
            //закрытие БД
            dbConnection.Close();

            if (a == 2)
            {
                string idparen = textBox15.Text;
                string namepare = textBox14.Text;
                string Datebir = textBox13.Text;
                string pphone = textBox12.Text;


                string cconnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDsc.mdb";
                OleDbConnection ddbConnection = new OleDbConnection(cconnectionString);

                ddbConnection.Open();
                string qquery = "INSERT INTO parents VALUES (" + idparen + ", '" + namepare + "', '" + Datebir + "'," + pphone + ", " + idStudent + ")";
                OleDbCommand ddbCommand = new OleDbCommand(qquery, ddbConnection);
                // Выполняем запрос
                if (ddbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные о родители 2 добавлены!", "Внимание!");
                //закрытие БД
                dbConnection.Close();
            }

            students stud = new students();
            stud.Show();
            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || comboBox1.Text != "")
            {
                MessageBox.Show("Есть заполненное поле, отчистите его!!!", "Внимание!");
            }
            else
            {
                students stud = new students();
                stud.Show();
                this.Hide();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }
    }

}
