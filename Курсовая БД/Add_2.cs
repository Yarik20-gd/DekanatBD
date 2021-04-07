﻿using System;
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
    public partial class Add_2 : Form
    {
        SqlConnection sqlConnection;

        public Add_2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Speci] (Название,Квалификация)VALUES(@Название, @Квалификация)", sqlConnection);

                command.Parameters.AddWithValue("Название", textBox1.Text);

                command.Parameters.AddWithValue("Квалификация", textBox2.Text);

                await command.ExecuteNonQueryAsync();

                this.Close();
            }
            else
            {
                label10.Visible = true;
                label10.Text = "ВСЕ поля должны быть заполнены! ";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
