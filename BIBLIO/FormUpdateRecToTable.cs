using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIO
{
    public partial class FormUpdateRecToTable : Form
    {
        public FormUpdateRecToTable()
        {
            InitializeComponent();
        }

        private void buttUpdateRecCancel_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttUpdateRec_Click(object sender, EventArgs e)
        {
            string sqlStr;
            if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                sqlStr = "UPDATE catalog_of_users SET " + tbSetToUpdate.Text +
                                 " WHERE " + tbWhereToUpdate.Text;
                if (MessageBox.Show("Ви впевнені, що хочете змінити дані?", "Заміна",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }
            if ((checkBox1.Checked == false) && (checkBox2.Checked == true))
            {
                int FileSize;
                byte[] masBytes;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToPhoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                masBytes = new byte[FileSize];
                fs.Read(masBytes, 0, FileSize);
                fs.Close();

                sqlStr = "UPDATE catalog_of_users SET photo = @File Where " + tbWhereToUpdate.Text;

                if (MessageBox.Show("Ви впевнені що хочете змінити дані?", "Заміна пройшла успішно",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File", masBytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }

            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                int FileSize;
                byte[] rawData;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToPhoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                sqlStr = "UPDATE catalog_of_users SET " + tbSetToUpdate.Text +
                    ", photo = @File" +
                    " Where " + tbWhereToUpdate.Text;

                if (MessageBox.Show("Ви впевнені що хочете змінити дані?", "Заміна пройшла успішно",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        cmd.Parameters.AddWithValue("@File", rawData);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }

            this.Close();
        }

        private void FormUpdateRecToTable_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "photo2.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Visible = true;
                tbSetToUpdate.Visible = true;
                buttUpdateRec.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                label1.Visible = false;
                tbSetToUpdate.Visible = false;
                if (checkBox2.Checked == false)
                {
                    buttUpdateRec.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panel2.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
                pictureBox1.Visible = true;
                buttUpdateRec.Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                panel2.Visible = false;
                label3.Visible = false;
                button3.Visible = false;
                pictureBox1.Visible = false;
                if (checkBox1.Checked == false)
                {
                    buttUpdateRec.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Виберіть файл";
            OFD.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            OFD.InitialDirectory = Application.StartupPath;

            if (OFD.ShowDialog() != DialogResult.OK) return;
            {
                h.pathToPhoto = OFD.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            }
        }
    }
}
