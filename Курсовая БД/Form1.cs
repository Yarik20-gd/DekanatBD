using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user1" && textBox2.Text == "12345")
            {



                MainWindow c = new MainWindow();

                c.Show();

                this.Hide();
            }
            else if (textBox1.Text == "user2" && textBox2.Text == "54321")
            {

                MainWindow_Admin_ c = new MainWindow_Admin_();

                c.Show();

                this.Hide();
               
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Неверный логин или пароль");
            }
           

        }
    }
}
