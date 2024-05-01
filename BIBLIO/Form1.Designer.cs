namespace BIBLIO
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableOsoba = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиПарольКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиТипДоступуКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервнеКопіюванняБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервнеВідновленняБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableOsoba,
            this.каталогToolStripMenuItem});
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            // 
            // OpenTableOsoba
            // 
            this.OpenTableOsoba.Name = "OpenTableOsoba";
            this.OpenTableOsoba.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.OpenTableOsoba.Size = new System.Drawing.Size(194, 26);
            this.OpenTableOsoba.Text = "читачі";
            this.OpenTableOsoba.Click += new System.EventHandler(this.OpenTableOsoba_Click);
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.каталогToolStripMenuItem.Text = "каталог";
            this.каталогToolStripMenuItem.Click += new System.EventHandler(this.каталогToolStripMenuItem_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиКористувачаToolStripMenuItem,
            this.видалитиКористувачаToolStripMenuItem,
            this.змінитиПарольКористувачаToolStripMenuItem,
            this.змінитиТипДоступуКористувачаToolStripMenuItem,
            this.резервнеКопіюванняБДToolStripMenuItem,
            this.резервнеВідновленняБДToolStripMenuItem});
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // додатиКористувачаToolStripMenuItem
            // 
            this.додатиКористувачаToolStripMenuItem.Name = "додатиКористувачаToolStripMenuItem";
            this.додатиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.додатиКористувачаToolStripMenuItem.Text = "Додати користувача";
            this.додатиКористувачаToolStripMenuItem.Click += new System.EventHandler(this.додатиКористувачаToolStripMenuItem_Click);
            // 
            // видалитиКористувачаToolStripMenuItem
            // 
            this.видалитиКористувачаToolStripMenuItem.Name = "видалитиКористувачаToolStripMenuItem";
            this.видалитиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.видалитиКористувачаToolStripMenuItem.Text = "Видалити користувача";
            this.видалитиКористувачаToolStripMenuItem.Click += new System.EventHandler(this.видалитиКористувачаToolStripMenuItem_Click);
            // 
            // змінитиПарольКористувачаToolStripMenuItem
            // 
            this.змінитиПарольКористувачаToolStripMenuItem.Name = "змінитиПарольКористувачаToolStripMenuItem";
            this.змінитиПарольКористувачаToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.змінитиПарольКористувачаToolStripMenuItem.Text = "Змінити пароль користувача";
            this.змінитиПарольКористувачаToolStripMenuItem.Click += new System.EventHandler(this.змінитиПарольКористувачаToolStripMenuItem_Click);
            // 
            // змінитиТипДоступуКористувачаToolStripMenuItem
            // 
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Name = "змінитиТипДоступуКористувачаToolStripMenuItem";
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Text = "Змінити тип доступу користувача";
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Click += new System.EventHandler(this.змінитиТипДоступуКористувачаToolStripMenuItem_Click);
            // 
            // резервнеКопіюванняБДToolStripMenuItem
            // 
            this.резервнеКопіюванняБДToolStripMenuItem.Name = "резервнеКопіюванняБДToolStripMenuItem";
            this.резервнеКопіюванняБДToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.резервнеКопіюванняБДToolStripMenuItem.Text = "Резервне копіювання БД";
            this.резервнеКопіюванняБДToolStripMenuItem.Click += new System.EventHandler(this.резервнеКопіюванняБДToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem1});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem1
            // 
            this.проПрограмуToolStripMenuItem1.Name = "проПрограмуToolStripMenuItem1";
            this.проПрограмуToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.проПрограмуToolStripMenuItem1.Text = "про програму ";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // резервнеВідновленняБДToolStripMenuItem
            // 
            this.резервнеВідновленняБДToolStripMenuItem.Name = "резервнеВідновленняБДToolStripMenuItem";
            this.резервнеВідновленняБДToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.резервнеВідновленняБДToolStripMenuItem.Text = "Резервне відновлення БД";
            this.резервнеВідновленняБДToolStripMenuItem.Click += new System.EventHandler(this.резервнеВідновленняБДToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenTableOsoba;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиПарольКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиТипДоступуКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервнеКопіюванняБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервнеВідновленняБДToolStripMenuItem;
    }
}

