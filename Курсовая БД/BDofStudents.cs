using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД
{
    public partial class BDofStudents : Form
    {

        SqlConnection sqlConnection;
       

        public BDofStudents()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private async void BDofStudents_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
            

            SqlDataReader sqlReader = null;
            SqlDataReader sqlReader2 = null;
            SqlDataReader sqlReader3 = null;
            SqlDataReader sqlReader4 = null;
            SqlDataReader sqlReader5 = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Student]", sqlConnection);
            SqlCommand command2 = new SqlCommand("SELECT * FROM [StudDrop]", sqlConnection);
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Speci]", sqlConnection);
            SqlCommand command4 = new SqlCommand("SELECT * FROM [Groop]", sqlConnection);
            SqlCommand command5 = new SqlCommand("SELECT * FROM [Departament]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
              
                listBox1.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество        " + "\t" + "|" + "\t" + "Дата рождения " + "\t" + "|" + "\t" + "Домашний адрес" + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t" + "Вид обучения          " + "\t" + "|" + "\t" + "Кафедра" + "\t" + "|" + "\t" + "Специальность" + "\t" + "|" + "\t" + "Группа" + "\t" + "|" + "\t" + "N зачетной книжки" +  "|");
                while (await sqlReader.ReadAsync())
                {
                   
                    listBox1.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox1.Items.Add("|" + "\t" + Convert.ToString(sqlReader["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Фамилия_имя_отчество"]) + "\t" + "|" + "\t" +  Convert.ToString(sqlReader["Дата_рождения "]) + "\t" + "|" + "\t" +  Convert.ToString(sqlReader["Домашний_адрес"]+"                 ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Год_поступления"]) + "\t" + "|" + "\t" +  Convert.ToString(sqlReader["Вид_обучения "] +"               ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Специальность"]+"            ") + "\t" + "|" + "\t" +  Convert.ToString(sqlReader["Группа"]) + "\t" + "|" + "\t" +  Convert.ToString(sqlReader["N_зачетной_книжки "]+"           ")+ "\t" +"|");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }


            try
            {
                sqlReader2 = await command2.ExecuteReaderAsync();

                listBox2.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество         " + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t"  + "Кафедра" + "\t" + "|" + "\t" + "Специальность"  + "\t" + "|" + "\t" + "N зачетной книжки"+ "\t"+"|" + "\t" +"Дата отчисления" + "\t" + "|" + "\t" + "Причина отчисления                " + "\t" + "|" + "\t");
                while (await sqlReader2.ReadAsync())
                {

                    listBox2.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox2.Items.Add("|" + "\t" + Convert.ToString(sqlReader2["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Фамилия_имя_отчество"]+"                 ")  + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Год_поступления"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Специальность"] + "            ")  + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["N_зачетной_книжки"] + "                      ") + "\t" + "|"  + "\t" + Convert.ToString(sqlReader2["Дата_отчисления"] + "           ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Причина_отчисления"] + "                    ") + "\t" + "|");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString(), ex1.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader2 != null)
                {
                    sqlReader2.Close();
                }
            }

            try
            {
                sqlReader3 = await command3.ExecuteReaderAsync();

                listBox3.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                                                                     " + "\t" + "|" + "\t" + "Квалификация" + "\t" + "|");
                while (await sqlReader3.ReadAsync())
                {

                    listBox3.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox3.Items.Add("|" + "\t" + Convert.ToString(sqlReader3["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader3["Название"] + "             ") + "\t\t" + "|" + "\t" + Convert.ToString(sqlReader3["Квалификация"]) + "\t" + "|");
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message.ToString(), ex2.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader3 != null)
                {
                    sqlReader3.Close();
                }
            }

            try
            {
                sqlReader4 = await command4.ExecuteReaderAsync();

                listBox5.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                      " + "\t" + "|");
                while (await sqlReader4.ReadAsync())
                {

                    listBox5.Items.Add("--------------------------------------------------------------------------------------------------------");
                    listBox5.Items.Add("|" + "\t" + Convert.ToString(sqlReader4["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader4["Название"] + "             ") + "\t\t" + "|");
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message.ToString(), ex3.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader4 != null)
                {
                    sqlReader4.Close();
                }
            }

            try
            {
                sqlReader5 = await command5.ExecuteReaderAsync();

                listBox6.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                         " + "\t" + "|");
                while (await sqlReader5.ReadAsync())
                {

                    listBox6.Items.Add("--------------------------------------------------------------------------------------------------------");
                    listBox6.Items.Add("|" + "\t" + Convert.ToString(sqlReader5["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader5["Название"] + "             ") + "\t\t" + "|");
                }
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message.ToString(), ex4.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader5 != null)
                {
                    sqlReader5.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add z = new Add();
            z.Show();
        }

        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            SqlDataReader sqlReader = null;
            SqlDataReader sqlReader2 = null;
            SqlDataReader sqlReader3 = null;
            SqlDataReader sqlReader4 = null;
            SqlDataReader sqlReader5 = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Student]", sqlConnection);
            SqlCommand command2 = new SqlCommand("SELECT * FROM [StudDrop]", sqlConnection);
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Speci]", sqlConnection);
            SqlCommand command4 = new SqlCommand("SELECT * FROM [Groop]", sqlConnection);
            SqlCommand command5 = new SqlCommand("SELECT * FROM [Departament]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                listBox1.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество        " + "\t" + "|" + "\t" + "Дата рождения " + "\t" + "|" + "\t" + "Домашний адрес" + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t" + "Вид обучения          " + "\t" + "|" + "\t" + "Кафедра" + "\t" + "|" + "\t" + "Специальность" + "\t" + "|" + "\t" + "Группа" + "\t" + "|" + "\t" + "N зачетной книжки" + "|");
                while (await sqlReader.ReadAsync())
                {

                    listBox1.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox1.Items.Add("|" + "\t" + Convert.ToString(sqlReader["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Фамилия_имя_отчество"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Дата_рождения "]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Домашний_адрес"] + "                ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Год_поступления"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Вид_обучения "] + "               ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Специальность"] + "            ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Группа"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["N_зачетной_книжки "] + "           ") + "\t" + "|");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }

            try
            {
                sqlReader2 = await command2.ExecuteReaderAsync();

                listBox2.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество         " + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t" + "Кафедра" + "\t" + "|" + "\t" + "Специальность" + "\t" + "|" + "\t" + "N зачетной книжки" + "\t" + "|" + "\t" + "Дата отчисления" + "\t" + "|" + "\t" + "Причина отчисления                " + "\t" + "|" + "\t");
                while (await sqlReader2.ReadAsync())
                {

                    listBox2.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox2.Items.Add("|" + "\t" + Convert.ToString(sqlReader2["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Фамилия_имя_отчество"] + "                 ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Год_поступления"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Специальность"] + "            ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["N_зачетной_книжки"] + "                      ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Дата_отчисления"] + "           ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader2["Причина_отчисления"] + "                    ") + "\t" + "|");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString(), ex1.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader2 != null)
                {
                    sqlReader2.Close();
                }
            }

            try
            {
                sqlReader3 = await command3.ExecuteReaderAsync();

                listBox3.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                                                                     " + "\t" + "|" + "\t" + "Квалификация" + "\t" + "|");
                while (await sqlReader3.ReadAsync())
                {

                    listBox3.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox3.Items.Add("|" + "\t" + Convert.ToString(sqlReader3["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader3["Название"] + "             ") + "\t\t" + "|" + "\t" + Convert.ToString(sqlReader3["Квалификация"]) + "\t" + "|");
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message.ToString(), ex2.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader3 != null)
                {
                    sqlReader3.Close();
                }
            }

            try
            {
                sqlReader4 = await command4.ExecuteReaderAsync();

                listBox5.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                         " + "\t" + "|" );
                while (await sqlReader4.ReadAsync())
                {

                    listBox5.Items.Add("--------------------------------------------------------------------------------------------------");
                    listBox5.Items.Add("|" + "\t" + Convert.ToString(sqlReader4["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader4["Название"] + "             ") + "\t\t" + "|");
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message.ToString(), ex3.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader4 != null)
                {
                    sqlReader4.Close();
                }
            }

            try
            {
                sqlReader5 = await command5.ExecuteReaderAsync();

                listBox6.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Название                         " + "\t" + "|");
                while (await sqlReader5.ReadAsync())
                {

                    listBox6.Items.Add("---------------------------------------------------------------------------------------------");
                    listBox6.Items.Add("|" + "\t" + Convert.ToString(sqlReader5["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader5["Название"] + "             ") + "\t\t" + "|");
                }
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message.ToString(), ex4.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader5 != null)
                {
                    sqlReader5.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete io = new Delete();
            io.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update ioq = new Update();
            ioq.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_1 ty = new Add_1();
            ty.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update_1 tyy = new Update_1();
            tyy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Delete_1 chui = new Delete_1();
            chui.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add_2 qw = new Add_2();
            qw.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update_2 wert = new Update_2();
            wert.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Delete_2 pio = new Delete_2();
            pio.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM[Student] WHERE [Группа] = @Группа", sqlConnection);

            command.Parameters.AddWithValue("Группа", textBox1.Text);

            try 
            {
                

                sqlReader = await command.ExecuteReaderAsync();
                listBox4.Items.Add("|" + "\t" + "Id" + "\t" + "|" + "\t" + "Фамилия, имя, отчество        " + "\t" + "|" + "\t" + "Дата рождения " + "\t" + "|" + "\t" + "Домашний адрес" + "\t" + "|" + "\t" + "Год поступления" + "\t" + "|" + "\t" + "Вид обучения          " + "\t" + "|" + "\t" + "Кафедра" + "\t" + "|" + "\t" + "Специальность" + "\t" + "|" + "\t" + "Группа" + "\t" + "|" + "\t" + "N зачетной книжки" + "|");

                while (await sqlReader.ReadAsync())
                {

                    listBox4.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox4.Items.Add("|" + "\t" + Convert.ToString(sqlReader["Id"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Фамилия_имя_отчество"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Дата_рождения "]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Домашний_адрес"] + "       ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Год_поступления"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Вид_обучения "]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Кафедра"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Специальность"] + "            ") + "\t" + "|" + "\t" + Convert.ToString(sqlReader["Группа"]) + "\t" + "|" + "\t" + Convert.ToString(sqlReader["N_зачетной_книжки "] + "           ") + "\t" + "|");
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

        private void button11_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yarik\source\repos\Курсовая\Курсовая\Database1.mdf;Integrated Security=True";

            //sqlConnection = new SqlConnection(connectionString);

            /*await sqlConnection.OpenAsync();

           

            SqlCommand command = new SqlCommand("SELECT COUNT([Вид_обучения]) FROM [Student] WHERE [Вид_обучения] = @Заочное ", sqlConnection);

            textBox2.Text = "Заочное ";

            textBox3.Text = Convert.ToString (await command.ExecuteNonQueryAsync()); 

            */
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow_Admin_ ytre = new MainWindow_Admin_();
            ytre.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Add_3 lp = new Add_3();
            lp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Update_3 mn = new Update_3();
            mn.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Delete_3 bg = new Delete_3();
            bg.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Add_4 kira = new Add_4();
            kira.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Update_4 loli = new Update_4();
            loli.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Delete_4 poki = new Delete_4();
            poki.Show();
        }
    }
}
