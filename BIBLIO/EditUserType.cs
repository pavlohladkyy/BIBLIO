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
    public partial class EditUserType : Form
    {
        DataTable dtuserName;

        public EditUserType()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditTypeUser_Click(object sender, EventArgs e)
        {
            int countAdm = 0;
            for (int i = 0; i < dtuserName.Rows.Count; i++)
                if (int.Parse(dtuserName.Rows[i][2].ToString()) == 1)
                    countAdm += 1;

            if (countAdm > 1)
            {
                string sqlcmd = "UPDATE Users SET Type = '" + cmbTypeUser.Text +
                    "' WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Тип користувача '" + cmbNameUser.Text + "'\n успішно змінено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не можете змінити користувача '" +
                    cmbNameUser.Text + "'!\n Це єдиний адміністратор!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTypeUser.Focus();
            }

        }

        private void EditUserType_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDt("SELECT * FROM Users");

            for (int i = 0; i < dtuserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtuserName.Rows[i][1].ToString());
                cmbTypeUser.Items.Add(dtuserName.Rows[i][2].ToString());
            }
            cmbNameUser.Text = dtuserName.Rows[0][1].ToString();
        }
    }
}
