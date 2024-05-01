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
            Application.Exit();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(h.typeUser) && int.Parse(h.typeUser) > 1)

            {
                адмініструванняToolStripMenuItem.Visible = false;
            }
        }

        private void додатиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser f5 = new AddNewUser();
            f5.ShowDialog();
        }

        private void змінитиПарольКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserPassword f6 = new EditUserPassword();
            f6.ShowDialog();
        }

        private void видалитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  DeleteUser f7 = new DeleteUser();
            f7.ShowDialog();
        }

        private void змінитиТипДоступуКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserType f8 = new EditUserType();
            f8.ShowDialog();
        }

        private void резервнеКопіюванняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("call sqlipz23_1_gpya.copyTablesBD();", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Немає зєднання з сервером!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Резервне копіювання успішно завершено!");
        }

        private void резервнеВідновленняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("call sqlipz23_1_gpya.restoreTablesBD();", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Немає зєднання з сервером!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Резервне відновлення успішно завершено!");
        }
    }
}


