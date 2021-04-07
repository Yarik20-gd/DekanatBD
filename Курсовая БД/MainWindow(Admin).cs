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
    public partial class MainWindow_Admin_ : Form
    {
        public MainWindow_Admin_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDofStudents c = new BDofStudents();
            c.Show();
            this.Hide();
        }
    }
}
