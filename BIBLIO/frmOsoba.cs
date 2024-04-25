using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIO
{
    public partial class frmOsoba : Form
    {
        public frmOsoba()
        {
            InitializeComponent();

        }

        private void frmOsoba_Load(object sender, EventArgs e)
        {

            this.Height = 400;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("Select * from catalog_of_users    ");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;


            h.bs1.Sort = dataGridView1.Columns[2].Name;

            DGWFormat();
            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            dtBorder = h.myfunDt("SELECT min(rating),max(rating),min(DNO),max(DNO) FROM catalog_of_users");
            dtDistinct = h.myfunDt("SELECT distinct Adress from catalog_of_users");

            //записуємо межі у відповідні елементи керування
            txtReitFrom.Text = dtBorder.Rows[0][0].ToString();
            txtReitTo.Text = dtBorder.Rows[0][1].ToString();
            dtpDNOFrom.Value = Convert.ToDateTime(dtBorder.Rows[0][2].ToString());
            DateTime.TryParseExact(dtBorder.Rows[0][2].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dnoFrom);

            //визначаємо перелік можливих значень текстового поля 
            cmbAdres.Items.Add("");
            for (int i = 0; i < dtDistinct.Rows.Count; i++)
            {
                cmbAdres.Items.Add(dtDistinct.Rows[i][0].ToString());
            }
            cmbAdres.DropDownStyle = ComboBoxStyle.DropDownList;

            //ініціалізуємо comboBox фільтр за статтю
            cmbSex.Items.Add("");
            cmbSex.Items.Add("ч");
            cmbSex.Items.Add("ж");
            cmbSex.Text = "ч";
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void DGWFormat()
        {
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[0].HeaderText = "N";
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                }
            }

        }

        private void CancelFind()
        {

            label1.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }
        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            CancelFind();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1);
            gfx.DrawLine(p, 0, 5, 5, 5);
            gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Width - 2, 0, e.ClipRectangle.Height - 2);


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 500;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 350;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "id > 0";
            if (txtPIP.Text != "")
            {
                strFilter += "AND PIPO LIKE '" + txtPIP.Text + "%'";

            }


            h.bs1.Filter = strFilter;
            if ((txtReitFrom.Text != "") && (txtReitTo.Text != ""))
            {
                strFilter += "AND (rating >= '" + txtReitFrom.Text.ToString().Replace('.', ',') + "'" +
                    "AND rating <= '" + txtReitTo.Text.ToString().Replace('.', ',') + "')";
            }
            else if ((txtReitFrom.Text == "") && (txtReitTo.Text != ""))
            {
                strFilter += "AND (rating <= '" + txtReitTo.Text.ToString().Replace('.', ',') + "')";
            }
            else if ((txtReitFrom.Text != "") && (txtReitTo.Text == ""))
            {
                strFilter += "AND (rating >= '" + txtReitFrom.Text.ToString().Replace('.', ',') + "')";
            }
            strFilter += "AND (DNO >= '" + dtpDNOFrom.Value.ToString("yyyy-MM-dd") + "'" + "AND DNO <= '" + dtpDNOTo.Value.ToString("yyyy-MM-dd") + "')";

            if (cmbAdres.Text != "")
            {
                strFilter += "AND (adress  = '" + cmbAdres.Text + "')";
            }
            if (String.Equals(cmbSex.Text, "ч"))
            {
                strFilter += "AND (stat = TRUE)";
            }
            else if (String.Equals(cmbSex.Text, "ж"))
            {
                strFilter += "AND (stat = False)";
            }


            MessageBox.Show(strFilter);

        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            Table1_Insertcs addnew = new Table1_Insertcs();
            addnew.ShowDialog();
            h.bs1.DataSource = h.myfunDt("SELECT *from catalog_of_users ");
            dataGridView1.DataSource = h.bs1;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            h.curVal10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            delete f3 = new delete();
            f3.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * from catalog_of_users");
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            int curColidx = dataGridView1.CurrentCellAddress.X; //індекс стовпця поточної клітинки
            int curRowidx = dataGridView1.CurrentCellAddress.Y; //індекс рядка поточної клітинки
            string curColName0 = dataGridView1.Columns[0].Name; //назва стовпця ключового поля
            string curColName = dataGridView1.Columns[curColidx].Name;//назва поточного стовпця
            h.curVal10 = dataGridView1[0, curRowidx].Value.ToString(); //значення клітинки ключового
                                                                       //поля поточного рядка
            string newCurCellVal = e.Value.ToString(); //нове значення поточної клітинки
            if (curColName == "PIPO" || curColName == "AdresO" || curColName == "PlaceWorkStudyO" || curColName == "Specialty0")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }
            if (curColName == "DNO" || curColName == "DRO")
            {
                newCurCellVal = Convert.ToDateTime(newCurCellVal).ToString("yyyy-MM-dd");
                newCurCellVal = "'" + newCurCellVal + "'";
            }

            if (curColName == "Size")
            {
                newCurCellVal = newCurCellVal.Replace("'", "'");
            }
            //якщо поле дійсне число, тоді в DataGrigView записуємо число з комою, а при запису в БД замінюємо кому на крапку
            string sqlStr = "UPDATE catalog_of_users SET " + curColName + " = " + newCurCellVal +
            " WHERE " + curColName0 + " = " + h.curVal10;
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                con.Open(); //Відкриваємо з'єднання
                cmd.ExecuteNonQuery(); //Виконуємо команду cmd
                con.Close(); //Закриваємо з'єднання
            }
            //тут могло бути оновлення даних з БД
        }

        private void bindingNamvigatorUpdateItem_Click_Click(object sender, EventArgs e)
        {
            h.curVal10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            FormUpdateRecToTable f4 = new FormUpdateRecToTable();
            f4.ShowDialog();

            h.bs1.DataSource = h.myfunDt("Select *from  catalog_of_users");
            dataGridView1.DataSource = h.bs1;

        }
    }
}


