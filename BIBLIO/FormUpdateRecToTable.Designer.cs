namespace BIBLIO
{
    partial class FormUpdateRecToTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttUpdateRecCancel_Click = new System.Windows.Forms.Button();
            this.buttUpdateRec = new System.Windows.Forms.Button();
            this.tbSetToUpdate = new System.Windows.Forms.TextBox();
            this.tbWhereToUpdate = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вкажіть поля та їх нові значення  SET:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запишіть умову для яких записів \n   робити заміну значення WHERE:";
            // 
            // buttUpdateRecCancel_Click
            // 
            this.buttUpdateRecCancel_Click.Location = new System.Drawing.Point(549, 590);
            this.buttUpdateRecCancel_Click.Name = "buttUpdateRecCancel_Click";
            this.buttUpdateRecCancel_Click.Size = new System.Drawing.Size(256, 27);
            this.buttUpdateRecCancel_Click.TabIndex = 2;
            this.buttUpdateRecCancel_Click.Text = "ВІДМІНА";
            this.buttUpdateRecCancel_Click.UseVisualStyleBackColor = true;
            this.buttUpdateRecCancel_Click.Click += new System.EventHandler(this.buttUpdateRecCancel_Click_Click);
            // 
            // buttUpdateRec
            // 
            this.buttUpdateRec.Location = new System.Drawing.Point(231, 590);
            this.buttUpdateRec.Name = "buttUpdateRec";
            this.buttUpdateRec.Size = new System.Drawing.Size(257, 27);
            this.buttUpdateRec.TabIndex = 3;
            this.buttUpdateRec.Text = "ЗАМІНИТИ";
            this.buttUpdateRec.UseVisualStyleBackColor = true;
            this.buttUpdateRec.Visible = false;
            this.buttUpdateRec.Click += new System.EventHandler(this.buttUpdateRec_Click);
            // 
            // tbSetToUpdate
            // 
            this.tbSetToUpdate.Location = new System.Drawing.Point(407, 43);
            this.tbSetToUpdate.Multiline = true;
            this.tbSetToUpdate.Name = "tbSetToUpdate";
            this.tbSetToUpdate.Size = new System.Drawing.Size(366, 30);
            this.tbSetToUpdate.TabIndex = 4;
            this.tbSetToUpdate.Visible = false;
            // 
            // tbWhereToUpdate
            // 
            this.tbWhereToUpdate.Location = new System.Drawing.Point(549, 481);
            this.tbWhereToUpdate.Multiline = true;
            this.tbWhereToUpdate.Name = "tbWhereToUpdate";
            this.tbWhereToUpdate.Size = new System.Drawing.Size(257, 30);
            this.tbWhereToUpdate.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Тестові, числові поля та дата";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(452, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "рисунки";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.tbSetToUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 453);
            this.panel1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Вибрати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "фото";
            this.label3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(375, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 337);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FormUpdateRecToTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbWhereToUpdate);
            this.Controls.Add(this.buttUpdateRec);
            this.Controls.Add(this.buttUpdateRecCancel_Click);
            this.Controls.Add(this.label2);
            this.Name = "FormUpdateRecToTable";
            this.Text = "редагування записів у таблиці catalog_of_users";
            this.Load += new System.EventHandler(this.FormUpdateRecToTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttUpdateRecCancel_Click;
        private System.Windows.Forms.Button buttUpdateRec;
        private System.Windows.Forms.TextBox tbSetToUpdate;
        private System.Windows.Forms.TextBox tbWhereToUpdate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}