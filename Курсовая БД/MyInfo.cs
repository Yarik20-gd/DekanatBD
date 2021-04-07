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
   

    public partial class MyInfo : Form
    {

        SqlConnection sqlConnection;

        public MyInfo()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM[Student] WHERE [Id] = @Id", sqlConnection);

            command.Parameters.AddWithValue("Id", textBox1.Text);

            try
            {


                sqlReader = await command.ExecuteReaderAsync();
                listBox1.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество        " + "\t" + "|" + "\t" + "Дата рождения " + "\t" + "|" + "\t" + "Домашний адрес" + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t" + "Вид обучения          " + "\t" + "|" + "\t" + "Кафедра" + "\t" + "|" + "\t" + "Специальность" + "\t" + "|" + "\t" + "Группа" + "\t" + "|" + "\t" + "N зачетной книжки" + "|");

                while (await sqlReader.ReadAsync())
                {

                    listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox1.Items.Add("|" + "\t" + Convert.ToString(sqlReader["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Фамилия_имя_отчество"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Дата_рождения "]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Домашний_адрес"] + "       ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Год_поступления"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Вид_обучения "]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Специальность"] + "            ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Группа"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["N_зачетной_книжки "] + "           ") + "\t" + "|");
                }


            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message.ToString(), ex2.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow yuich = new MainWindow();
            yuich.Show();
            this.Close();
        }
    }
}
