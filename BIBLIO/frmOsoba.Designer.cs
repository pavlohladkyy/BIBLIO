using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace BIBLIO
{
    partial class frmOsoba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOsoba));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.bindingNamvigatorUpdateItem_Click = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilterCancel = new System.Windows.Forms.Button();
            this.btnFilterOk = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbAdres = new System.Windows.Forms.ComboBox();
            this.dtpDNOTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDNOFrom = new System.Windows.Forms.DateTimePicker();
            this.txtReitTo = new System.Windows.Forms.TextBox();
            this.txtReitFrom = new System.Windows.Forms.TextBox();
            this.txtPIP = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnOLEDB = new System.Windows.Forms.Button();
            this.btnComObject = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdobtn_tsv = new System.Windows.Forms.RadioButton();
            this.rdobtn_doc = new System.Windows.Forms.RadioButton();
            this.rdobtn_xls = new System.Windows.Forms.RadioButton();
            this.rdobtn_txt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnFind,
            this.btnFilter,
            this.AddNew,
            this.delete,
            this.bindingNamvigatorUpdateItem_Click});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1312, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFind
            // 
            this.btnFind.CheckOnClick = true;
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(29, 24);
            this.btnFind.Text = "FIND";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.CheckOnClick = true;
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(29, 24);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(29, 24);
            this.AddNew.Text = "toolStripButton1";
            this.AddNew.ToolTipText = "add";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // delete
            // 
            this.delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(29, 24);
            this.delete.Text = "toolStripButton1";
            this.delete.ToolTipText = "Remove";
            this.delete.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bindingNamvigatorUpdateItem_Click
            // 
            this.bindingNamvigatorUpdateItem_Click.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNamvigatorUpdateItem_Click.Image = ((System.Drawing.Image)(resources.GetObject("bindingNamvigatorUpdateItem_Click.Image")));
            this.bindingNamvigatorUpdateItem_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNamvigatorUpdateItem_Click.Name = "bindingNamvigatorUpdateItem_Click";
            this.bindingNamvigatorUpdateItem_Click.Size = new System.Drawing.Size(29, 24);
            this.bindingNamvigatorUpdateItem_Click.Text = "Edit";
            this.bindingNamvigatorUpdateItem_Click.Click += new System.EventHandler(this.bindingNamvigatorUpdateItem_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "пошук";
            this.label1.Visible = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(787, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(233, 22);
            this.txtFind.TabIndex = 3;
            this.txtFind.Visible = false;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFilterCancel);
            this.groupBox1.Controls.Add(this.btnFilterOk);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.cmbAdres);
            this.groupBox1.Controls.Add(this.dtpDNOTo);
            this.groupBox1.Controls.Add(this.dtpDNOFrom);
            this.groupBox1.Controls.Add(this.txtReitTo);
            this.groupBox1.Controls.Add(this.txtReitFrom);
            this.groupBox1.Controls.Add(this.txtPIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FITER";
            this.groupBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "від";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "дата народження";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "стать";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "адреса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "від";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Прізвище";
            // 
            // btnFilterCancel
            // 
            this.btnFilterCancel.Location = new System.Drawing.Point(891, 101);
            this.btnFilterCancel.Name = "btnFilterCancel";
            this.btnFilterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFilterCancel.TabIndex = 5;
            this.btnFilterCancel.Text = "відміна";
            this.btnFilterCancel.UseVisualStyleBackColor = true;
            this.btnFilterCancel.Click += new System.EventHandler(this.btnFilterCancel_Click);
            // 
            // btnFilterOk
            // 
            this.btnFilterOk.Location = new System.Drawing.Point(891, 39);
            this.btnFilterOk.Name = "btnFilterOk";
            this.btnFilterOk.Size = new System.Drawing.Size(75, 23);
            this.btnFilterOk.TabIndex = 7;
            this.btnFilterOk.Text = "фільтр";
            this.btnFilterOk.UseVisualStyleBackColor = true;
            this.btnFilterOk.Click += new System.EventHandler(this.btnFilterOk_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(715, 101);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(121, 24);
            this.cmbSex.TabIndex = 6;
            // 
            // cmbAdres
            // 
            this.cmbAdres.FormattingEnabled = true;
            this.cmbAdres.Location = new System.Drawing.Point(715, 39);
            this.cmbAdres.Name = "cmbAdres";
            this.cmbAdres.Size = new System.Drawing.Size(121, 24);
            this.cmbAdres.TabIndex = 5;
            // 
            // dtpDNOTo
            // 
            this.dtpDNOTo.Location = new System.Drawing.Point(430, 99);
            this.dtpDNOTo.Name = "dtpDNOTo";
            this.dtpDNOTo.Size = new System.Drawing.Size(199, 22);
            this.dtpDNOTo.TabIndex = 4;
            // 
            // dtpDNOFrom
            // 
            this.dtpDNOFrom.Location = new System.Drawing.Point(429, 41);
            this.dtpDNOFrom.Name = "dtpDNOFrom";
            this.dtpDNOFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpDNOFrom.TabIndex = 3;
            // 
            // txtReitTo
            // 
            this.txtReitTo.Location = new System.Drawing.Point(236, 101);
            this.txtReitTo.Multiline = true;
            this.txtReitTo.Name = "txtReitTo";
            this.txtReitTo.Size = new System.Drawing.Size(104, 22);
            this.txtReitTo.TabIndex = 2;
            // 
            // txtReitFrom
            // 
            this.txtReitFrom.Location = new System.Drawing.Point(236, 41);
            this.txtReitFrom.Name = "txtReitFrom";
            this.txtReitFrom.Size = new System.Drawing.Size(104, 22);
            this.txtReitFrom.TabIndex = 1;
            // 
            // txtPIP
            // 
            this.txtPIP.Location = new System.Drawing.Point(16, 71);
            this.txtPIP.Name = "txtPIP";
            this.txtPIP.Size = new System.Drawing.Size(142, 22);
            this.txtPIP.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1026, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(12, 53);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(101, 23);
            this.btnStream.TabIndex = 6;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnOLEDB
            // 
            this.btnOLEDB.Location = new System.Drawing.Point(429, 53);
            this.btnOLEDB.Name = "btnOLEDB";
            this.btnOLEDB.Size = new System.Drawing.Size(101, 23);
            this.btnOLEDB.TabIndex = 7;
            this.btnOLEDB.Text = "OLEDB";
            this.btnOLEDB.UseVisualStyleBackColor = true;
            this.btnOLEDB.Click += new System.EventHandler(this.btnOLEDB_Click);
            // 
            // btnComObject
            // 
            this.btnComObject.Location = new System.Drawing.Point(578, 53);
            this.btnComObject.Name = "btnComObject";
            this.btnComObject.Size = new System.Drawing.Size(101, 23);
            this.btnComObject.TabIndex = 8;
            this.btnComObject.Text = "Com Object";
            this.btnComObject.UseVisualStyleBackColor = true;
            this.btnComObject.Click += new System.EventHandler(this.btnComObject_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(727, 53);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(101, 23);
            this.btnXML.TabIndex = 9;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdobtn_tsv);
            this.panel1.Controls.Add(this.rdobtn_doc);
            this.panel1.Controls.Add(this.rdobtn_xls);
            this.panel1.Controls.Add(this.rdobtn_txt);
            this.panel1.Location = new System.Drawing.Point(143, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 55);
            this.panel1.TabIndex = 10;
            // 
            // rdobtn_tsv
            // 
            this.rdobtn_tsv.AutoSize = true;
            this.rdobtn_tsv.Location = new System.Drawing.Point(3, 29);
            this.rdobtn_tsv.Name = "rdobtn_tsv";
            this.rdobtn_tsv.Size = new System.Drawing.Size(45, 20);
            this.rdobtn_tsv.TabIndex = 12;
            this.rdobtn_tsv.Text = "tsv";
            this.rdobtn_tsv.UseVisualStyleBackColor = true;
            // 
            // rdobtn_doc
            // 
            this.rdobtn_doc.AutoSize = true;
            this.rdobtn_doc.Location = new System.Drawing.Point(122, 3);
            this.rdobtn_doc.Name = "rdobtn_doc";
            this.rdobtn_doc.Size = new System.Drawing.Size(51, 20);
            this.rdobtn_doc.TabIndex = 13;
            this.rdobtn_doc.Text = "doc";
            this.rdobtn_doc.UseVisualStyleBackColor = true;
            // 
            // rdobtn_xls
            // 
            this.rdobtn_xls.AutoSize = true;
            this.rdobtn_xls.Location = new System.Drawing.Point(122, 29);
            this.rdobtn_xls.Name = "rdobtn_xls";
            this.rdobtn_xls.Size = new System.Drawing.Size(44, 20);
            this.rdobtn_xls.TabIndex = 14;
            this.rdobtn_xls.Text = "xls";
            this.rdobtn_xls.UseVisualStyleBackColor = true;
            // 
            // rdobtn_txt
            // 
            this.rdobtn_txt.AutoSize = true;
            this.rdobtn_txt.Checked = true;
            this.rdobtn_txt.Location = new System.Drawing.Point(3, 3);
            this.rdobtn_txt.Name = "rdobtn_txt";
            this.rdobtn_txt.Size = new System.Drawing.Size(40, 20);
            this.rdobtn_txt.TabIndex = 11;
            this.rdobtn_txt.TabStop = true;
            this.rdobtn_txt.Text = "txt";
            this.rdobtn_txt.UseVisualStyleBackColor = true;
            // 
            // frmOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnComObject);
            this.Controls.Add(this.btnOLEDB);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmOsoba";
            this.Text = "frmOsoba";
            this.Load += new System.EventHandler(this.frmOsoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpDNOFrom;
        private System.Windows.Forms.TextBox txtReitTo;
        private System.Windows.Forms.TextBox txtReitFrom;
        private System.Windows.Forms.TextBox txtPIP;
        private System.Windows.Forms.Button btnFilterCancel;
        private System.Windows.Forms.Button btnFilterOk;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbAdres;
        private System.Windows.Forms.DateTimePicker dtpDNOTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.ToolStripButton bindingNamvigatorUpdateItem_Click;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnOLEDB;
        private System.Windows.Forms.Button btnComObject;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdobtn_tsv;
        private System.Windows.Forms.RadioButton rdobtn_doc;
        private System.Windows.Forms.RadioButton rdobtn_xls;
        private System.Windows.Forms.RadioButton rdobtn_txt;
    }
}