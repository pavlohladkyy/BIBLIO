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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.curVal10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from catalog_of_users where " + textBox1.Text;

            if (MessageBox.Show("ви впевнені що хочете видалити запис","Видалення",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);
              
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            this.Close();
        }
    }
}
