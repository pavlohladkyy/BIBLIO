using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace BIBLIO
{
    public partial class LogIn : Form
    {
        public string[,] matrix;

        DataTable dt;
        public LogIn()
        {
            
            InitializeComponent();
             h.ConStr = "server = 194.44.236.9; database = sqlipz23_1_gpya;" +
                 "user = sqlipz23_1_gpya; password = ipz23_gpya; charset = cp1251;";
             dt = h.myfunDt("SELECT * FROM Users");



             int kilkz = dt.Rows.Count;
             matrix = new string[kilkz, 4];

             for(int i=0; i < kilkz; i++)
             {
                 matrix[i, 0] = dt.Rows[i].Field<int>("id").ToString();
                 matrix[i, 1] = dt.Rows[i].Field<string>("UsersName");
                 matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                 matrix[i, 3] = dt.Rows[i].Field<string>("Password");
                 cbxUser.Items.Add(matrix[i, 1]);
             }
     
            cbxUser.Text = matrix[0, 1];
            txtPassword.UseSystemPasswordChar = true;
            cbxUser.Focus();
        }

        private void Avtorization()
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if (String.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                {
                    if (String.Equals(h.EncriptedPassword_MD5(txtPassword.Text), matrix[i, 3]))
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть проавильний пароль!", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            Avtorization();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Avtorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        
    }
    static class h
    {
        public static BindingSource bs1 { get; set; }
        public static string ConStr { get; set; }
        public static string typeUser { get; set; }
        public static string nameUser { get; set; }
       
        public static string pathToPhoto { get; set; }
        public static string curVal10 { get; set; }
        public static string keyName { get; set; }


        public static string EncriptedPassword_MD5(string s)
        {
            if (string.Compare(s, "null", true) == 0)
                return "HULL";
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHach = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHach)
                hash += String.Format("{0:x2}", b);


            return hash;
        }
       
        public static DataTable myfunDt(string commandString)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(commandString, con);
                try
                {
                    con.Open();
                    using(MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("\aнеможливо зв'язатися з sql-серевером! \nПеревірте наявність інтернету...",
                        ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;

        }
    }
}
