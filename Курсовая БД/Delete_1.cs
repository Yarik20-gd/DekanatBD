using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД
{
    public partial class Delete_1 : Form
    {

        SqlConnection sqlConnection;
        public Delete_1()
        {
            InitializeComponent();
        }

        private async void  button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [StudDrop] WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox1.Text);

                await command.ExecuteNonQueryAsync();

                this.Close();
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Id должен быть заполнен! ";
            }
        }
    }
}
