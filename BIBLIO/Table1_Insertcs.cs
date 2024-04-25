using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIO
{
    public partial class Table1_Insertcs : Form
    {
        public Table1_Insertcs()
        {
            InitializeComponent();


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = textBox5.Text;
                string tb6 = textBox6.Text;
                string tb7 = textBox7.Text;
                string sql = "INSERT INTO catalog_of_users (id, PIPO, adress, DNO, rating, sex, phone_number) VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6, @TK7)";

                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TK1", tb1);
                    cmd.Parameters.AddWithValue("@TK2", tb2);
                    cmd.Parameters.AddWithValue("@TK3", tb3);
                    cmd.Parameters.AddWithValue("@TK4", tb4);
                    cmd.Parameters.AddWithValue("@TK5", tb5);
                    cmd.Parameters.AddWithValue("@TK6", tb6);
                    cmd.Parameters.AddWithValue("@TK7", tb7);

                    cmd.ExecuteNonQuery();
                }
                con.Close();

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close();
        }

    }
}
