using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД
{
    public partial class Add : Form
    {
        SqlConnection sqlConnection;

        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && 
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Student] (Фамилия_имя_отчество,Дата_рождения,Домашний_адрес,Год_поступления,Вид_обучения,Кафедра,Специальность,Группа,N_зачетной_книжки )VALUES(@Фамилия_имя_отчество, @Дата_рождения, @Домашний_адрес, @Год_поступления, @Вид_обучения, @Кафедра, @Специальность, @Группа, @N_зачетной_книжки)", sqlConnection);

                command.Parameters.AddWithValue("Фамилия_имя_отчество", textBox1.Text);

                command.Parameters.AddWithValue("Дата_рождения", textBox2.Text);

                command.Parameters.AddWithValue("Домашний_адрес", textBox3.Text);

                command.Parameters.AddWithValue("Год_поступления", textBox4.Text);

                command.Parameters.AddWithValue("Вид_обучения", textBox5.Text);

                command.Parameters.AddWithValue("Кафедра", textBox6.Text);

                command.Parameters.AddWithValue("Специальность", textBox7.Text);

                command.Parameters.AddWithValue("Группа", textBox8.Text);

                command.Parameters.AddWithValue("N_зачетной_книжки", textBox9.Text);

                await command.ExecuteNonQueryAsync();

                this.Close();
            }
            else
            {
                label10.Visible = true;
                label10.Text = "ВСЕ поля должны быть заполнены! ";
            }
        }
    }
}
