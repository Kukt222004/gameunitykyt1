using System.Diagnostics.Eventing.Reader;


namespace BDSchol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string log = "123";
            string pasword = "123";

            if (textBox1.Text == log)
            {

                if (textBox2.Text == pasword)
                {

                    BDhome bDhome = new BDhome();
                    bDhome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль", "Внимание!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль", "Внимание!");
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}