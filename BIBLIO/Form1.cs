using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BIBLIO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculatorForm = new Calculator();
            calculatorForm.ShowDialog();
        }

        private void OpenTableOsoba_Click(object sender, EventArgs e)
        {
            frmOsoba f1 = new frmOsoba();
            f1.ShowDialog();
        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKatalog f2 = new frmKatalog();
            f2.ShowDialog();
        }
    }
}


