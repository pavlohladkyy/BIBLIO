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
    public partial class EditUserPassword : Form
    {
        public EditUserPassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditPasswordUser_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtPassword1User.Text, txtPassword2User.Text)
               && txtPassword1User.Text != "")
            {
                string sqlcmd = "UPDATE Users SET Password = '" +
                    h.EncriptedPassword_MD5(txtPassword1User.Text) +
                    "' WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пароль користувача '" + cmbNameUser.Text +
                    "'\n успішно змінено!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Паролі не співпадають \n або не введені!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1User.Focus();
            }

        }
    }
}
