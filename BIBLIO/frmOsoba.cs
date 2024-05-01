using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace BIBLIO
{
    using System.IO;
    public partial class frmOsoba : Form
    {
        string path = Path.GetFullPath(@"C:\Users\admin\Desktop\desktop\ОБДЗ\BIBLIO\BIBLIO\bin\Debug\Report\");
        DataTable dt;
        public frmOsoba()
        {
            InitializeComponent();

        }

        private void frmOsoba_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(h.typeUser) && int.Parse(h.typeUser) == 3)

            {
                AddNew.Visible = false;
                delete.Visible = false;
                bindingNamvigatorUpdateItem_Click.Visible = false;
                dataGridView1.ReadOnly = true;
            }


            this.Height = 400;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("Select * from catalog_of_users  ");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

           

            dt = (DataTable)h.bs1.DataSource;

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
                this.Height = 550;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 420;
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rIndx = dataGridView1.CurrentCell.RowIndex;


            if (dataGridView1.Rows[rIndx].Cells[7].Value.ToString().Length > 0)
            {
                byte[] a = (byte[])dataGridView1.Rows[rIndx].Cells[7].Value;
                MemoryStream memImage = new MemoryStream(a);
                pictureBox1.Image = Image.FromStream(memImage);
                memImage.Close();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\admin\Desktop\desktop\ОБДЗ\BIBLIO\BIBLIO\bin\Debug\no image.jpeg");
            }
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            var srcEncoding = Encoding.GetEncoding(1251);

            //Вибір типу файлу
            string extend;

            if (rdobtn_tsv.Checked)
                extend = "tsv";
            else if (rdobtn_doc.Checked)
                extend = "doc";
            else if (rdobtn_xls.Checked)
                extend = "xls";
            else
                extend = "txt";

            string fileName = path+ @"Osoba_Stream." + extend;

            if (File.Exists(fileName))File.Delete(fileName);

            //оголошення потоку
            StreamWriter wr = new StreamWriter(fileName, false, encoding: srcEncoding);

            //вивід у файл
            try
            {
                //Вивід назви полів
                //можна вказати для користувача
                wr.Write("" + "\t" + "Прізвище" + "\t" + "Дата народи." + "\t" + "Адреса" + "\t" + "Вуз" + "\t");
                wr.WriteLine();

                // АБО вивести назви стовпців у відповідній таблиці
                for (int i = 0; i < dt.Columns.Count; i++)
                    wr.Write(dt.Columns[i] + "\t");

                wr.WriteLine();

                //Вивід даних (записів)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j] != null)
                        {
                            // У Steran вивід ФОТО не реалізується
                            if (dt.Columns[j].DataType.ToString() == "System.Byte[]")
                                wr.Write("OTO" + "\t");

                            // якщо тип даних ДАТА, тоді конвертуємо у формат день місяць-рік
                            else if (dt.Columns[j].DataType.ToString() == "System.DateTime")
                                wr.Write(Convert.ToDateTime(dt.Rows[i][j]).ToString("dd/MM/yyyy") + "\t");

                            // якщо тип даних DOUBLE (дійсне число), тоді конвертуєно в дійсне
                            else if (dt.Columns[j].DataType.ToString() == "System.Double")
                                wr.Write(Convert.ToDouble(dt.Rows[i][j]).ToString() + "\t");

                            // решту виводимо вк текст
                            else
                                wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                        }
                        else
                            wr.Write("\t");
                    }

                    wr.WriteLine();
                }

                wr.Close(); //close file
            }
            catch (Exception ex)
            {
                throw ex;
            }

            MessageBox.Show("Export in Stream Ok");
        }

        private void btnOLEDB_Click(object sender, EventArgs e)
        {
            // Отримання шляху до файлу Excel
            string fileName = path + @"Osoba_OLEDB.xlsx";

            // Видалення існуючого файлу Excel
            if (File.Exists(fileName))File.Delete(fileName);

            // Створення рядка з'єднання з таблицею БД в Excel
            string connectionString = $" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = { fileName }; Extended Properties = \"Excel 12.0 Xml;HDR=YES;\";";
           


            // Створення команди CREATE TABLE для створення таблиці в Excel
            string commandCreateOleDb = $"CREATE TABLE [MySheet] ([{dt.Columns[0].ColumnName}] int";

            for (int i = 1; i < dt.Columns.Count; i++)
                commandCreateOleDb += $", [{dt.Columns[i].ColumnName}] string";

            commandCreateOleDb += ")";

            // Створення з'єднання з БД в Excel
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                // Створення команди на створення таблиці
                using (OleDbCommand cmd = new OleDbCommand(commandCreateOleDb, conn))
                {
                    try
                    {
                        // Відкриття з'єднання
                        conn.Open();

                        // Створення таблиці Excel
                        cmd.ExecuteNonQuery();

                        // Генерація команд INSERT для додавання записів у створену таблицю Excel
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cmd.CommandText = $"INSERT INTO [MySheet$] VALUES({Convert.ToString(dt.Rows[i][0])}";

                            for (int j = 1; j < dt.Columns.Count; j++)
                            {
                                switch (dt.Columns[j].DataType.ToString())
                                {
                                    case "System.String":
                                        cmd.CommandText += $", '{Convert.ToString(dt.Rows[i][j])}'";
                                        break;
                                    case "System.Int32":
                                        cmd.CommandText += $", {Convert.ToInt32(dt.Rows[i][j])}";
                                        break;
                                    case "System.Decimal":
                                        cmd.CommandText += $", {Convert.ToDecimal(dt.Rows[i][j])}";
                                        break;
                                    case "System.DateTime":
                                        cmd.CommandText += $", '{Convert.ToDateTime(dt.Rows[i][j]).ToString("dd/MM/yyyy")}'";
                                        break;
                                    default:
                                        cmd.CommandText += ", 'не конвертовано'";
                                        break;
                                }
                            }

                            cmd.CommandText += ")";

                            // Виконання згенерованої команди INSERT
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при створенні таблиці або додаванні записів: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            MessageBox.Show("Export dt to file as OLEDB Ok");
        }


        private void format_Osoba_com(Excel.Application excel, Excel.Worksheet sheet)
        {
            int r1, c1, r2, c2;
            r1 = 1;
            c1 = 1;
            r2= dt.Rows.Count+1;
            c2 = dt.Columns.Count;

            Excel.Range rangeO = (Excel.Range)sheet.Range[sheet.Cells[9, 2], sheet.Cells[9, 2]];
            Excel.Range range1 = (Excel.Range)sheet.Range[sheet.Cells[r1, c1], sheet.Cells[r2, c2]];
            Excel.Range range2 = (Excel.Range)sheet.Range[sheet.Cells[10, 1], sheet.Cells[10, 5]];

            range1.Font.Background = true; //po6vo mpudr xpam

            range1.Font.Size = 12; //posmip 20

            range1.Font.Color = ColorTranslator.ToOle(Color.Black);  //xomip - wopxuit
            range1.Font.Name = "Arial"; //"Times New Roman’



            range1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous; //pamxa ninia
            range1.Borders.Weight = Excel.XlBorderWeight.xlThin; //touxa
            range1.Borders.Color = ColorTranslator.ToOle(Color.Red);

            //Bupismonanua B Hianasoui 3ananTSca TAK:
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;


           range1.ColumnWidth = 20;
           rangeO.RowHeight = 35;



            range1.EntireColumn.AutoFit();  //asro mpuny i sucoTy
            range1.EntireRow.AutoFit();

            // Konip samen
            range1.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
            range2.Merge(Type.Missing); //o8'enuanua miu mianasony

        }
        private void btnComObject_Click(object sender, EventArgs e)
        {
            // Отримання шляху до файлу
            string fileName = Path.Combine(path, "Osoba_COM.xls");

            // Перевірка існування файлу та його видалення, якщо він вже існує
            if (File.Exists(fileName))
                File.Delete(fileName);

            // Створення об'єкта Excel та робочої книги
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Worksheets[1];
            sheet.Name = "Читачі";

            // Запис назв стовпців
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                sheet.Cells[1, j + 1].Value = dt.Columns[j].ColumnName;
            }

            // Запис даних
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    // Перевірка типу даних та запис даних або тексту "Фото"
                    if (dt.Columns[j].DataType == typeof(byte[]))
                    {
                        sheet.Cells[i + 2, j + 1].Value = "Фото";
                    }
                    else
                    {
                        sheet.Cells[i + 2, j + 1].Value = dt.Rows[i][j];
                    }
                }
            }

            // Форматування файлу Excel
            format_Osoba_com(excel, sheet);

            // Збереження файлу Excel
            workbook.SaveAs(fileName);
            // Закриття робочої книги
            workbook.Close();
            // Закриття Excel
            excel.Quit();

            // Повідомлення користувачеві
            MessageBox.Show("Файл xls створено за допомогою COM-об'єктів Excel");
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            string filename = path + @"\Osoba_XML.xls";
            dt.WriteXml(filename);
            MessageBox.Show("File xls cтворено за допомогою розмітки XML");
        }
    }
}


