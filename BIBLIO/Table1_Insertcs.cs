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

                string strFileName = h.pathToPhoto;
                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                int FileSize = (Int32)fs.Length;
                byte[] rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                string sql = "INSERT INTO catalog_of_users (id, PIPO, adress, DNO, rating, sex, phone_number) VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6, @TK7)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);
                cmd.Parameters.AddWithValue("@TK6", tb6);
                cmd.Parameters.AddWithValue("@TK7", tb7);

                cmd.Parameters.AddWithValue("@FileName", strFileName);
                cmd.Parameters.AddWithValue("@File", rawData);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Додавання запису пройшла вдало");
            }
            this.Close();
        }

        private void Table1_Insertcs_Load(object sender, EventArgs e)
        {
            h.pathToPhoto = Application.StartupPath + @"\" + "no image.jpeg";
            pictureBox1.Image = Image.FromFile(h.pathToPhoto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialig1 = new OpenFileDialog();
            openFileDialig1.Title = "Виберіть файл";
            openFileDialig1.Filter = "img files (*.jpeg)|*.jpeg|bmp file (*.bmp) |*.bmp|All files (*.*)|*.*";
            openFileDialig1.InitialDirectory = Application.StartupPath;
            if (openFileDialig1.ShowDialog() != DialogResult.OK) return;
            {
                h.pathToPhoto = openFileDialig1.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToPhoto);
            }
        }
    }
}
