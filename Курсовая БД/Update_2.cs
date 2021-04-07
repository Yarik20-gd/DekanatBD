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
    public partial class Update_2 : Form
    {

        SqlConnection sqlConnection;

        public Update_2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                 !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Speci] SET[Название] = @Название, [Квалификация] = @Квалификация WHERE[Id] = @Id", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox10.Text);

                command.Parameters.AddWithValue("Название", textBox1.Text);

                command.Parameters.AddWithValue("Квалификация", textBox2.Text);

              



                await command.ExecuteNonQueryAsync();

                this.Close();
            }
            else if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                label10.Visible = true;
                label10.Text = "Id должен быть заполнен! ";
            }
            else
            {
                label10.Visible = true;
                label10.Text = "Поля 'Имя' и 'Цена' должны быть заполнены! ";
            }
        }
    }
}
