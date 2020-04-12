namespace ВКР
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вашСобственныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстИзТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьcsvФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставитьФоновоеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьФоновыйЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фоновоеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьpdfФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗадникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.добавитьКартинкуToolStripMenuItem,
            this.добавитьcsvФайлToolStripMenuItem,
            this.поставитьФоновоеИзображениеToolStripMenuItem,
            this.создатьpdfФайлToolStripMenuItem,
            this.изменитьЗадникToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 29);
            this.toolStripMenuItem2.Text = "Выбрать Ориентацию";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(227, 30);
            this.toolStripMenuItem4.Text = "Вертикальная";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.VerticalOrientation);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(227, 30);
            this.toolStripMenuItem5.Text = "Горизонтальная";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.GorizontalOrientation);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вашСобственныйТекстToolStripMenuItem,
            this.текстИзТаблицыToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 29);
            this.toolStripMenuItem1.Text = "Добавить Текст";
            // 
            // вашСобственныйТекстToolStripMenuItem
            // 
            this.вашСобственныйТекстToolStripMenuItem.Name = "вашСобственныйТекстToolStripMenuItem";
            this.вашСобственныйТекстToolStripMenuItem.Size = new System.Drawing.Size(285, 30);
            this.вашСобственныйТекстToolStripMenuItem.Text = "Ваш собственный текст";
            this.вашСобственныйТекстToolStripMenuItem.Click += new System.EventHandler(this.buttonaddtext);
            // 
            // текстИзТаблицыToolStripMenuItem
            // 
            this.текстИзТаблицыToolStripMenuItem.Name = "текстИзТаблицыToolStripMenuItem";
            this.текстИзТаблицыToolStripMenuItem.Size = new System.Drawing.Size(285, 30);
            this.текстИзТаблицыToolStripMenuItem.Text = "Текст из таблицы";
            this.текстИзТаблицыToolStripMenuItem.Click += new System.EventHandler(this.AddtextfromTabl);
            // 
            // добавитьКартинкуToolStripMenuItem
            // 
            this.добавитьКартинкуToolStripMenuItem.Name = "добавитьКартинкуToolStripMenuItem";
            this.добавитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.добавитьКартинкуToolStripMenuItem.Text = "Добавить картинку";
            this.добавитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.AddImage);
            // 
            // добавитьcsvФайлToolStripMenuItem
            // 
            this.добавитьcsvФайлToolStripMenuItem.Name = "добавитьcsvФайлToolStripMenuItem";
            this.добавитьcsvФайлToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.добавитьcsvФайлToolStripMenuItem.Text = "Добавить (.csv) файл";
            this.добавитьcsvФайлToolStripMenuItem.Click += new System.EventHandler(this.Openfilebutton);
            // 
            // поставитьФоновоеИзображениеToolStripMenuItem
            // 
            this.поставитьФоновоеИзображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьФоновыйЦветToolStripMenuItem,
            this.фоновоеИзображениеToolStripMenuItem});
            this.поставитьФоновоеИзображениеToolStripMenuItem.Name = "поставитьФоновоеИзображениеToolStripMenuItem";
            this.поставитьФоновоеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.поставитьФоновоеИзображениеToolStripMenuItem.Text = "Задать фон";
            // 
            // задатьФоновыйЦветToolStripMenuItem
            // 
            this.задатьФоновыйЦветToolStripMenuItem.Name = "задатьФоновыйЦветToolStripMenuItem";
            this.задатьФоновыйЦветToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.задатьФоновыйЦветToolStripMenuItem.Text = "Задать фоновый цвет";
            this.задатьФоновыйЦветToolStripMenuItem.Click += new System.EventHandler(this.SetBackGroundColor);
            // 
            // фоновоеИзображениеToolStripMenuItem
            // 
            this.фоновоеИзображениеToolStripMenuItem.Name = "фоновоеИзображениеToolStripMenuItem";
            this.фоновоеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.фоновоеИзображениеToolStripMenuItem.Text = "Фоновое изображение";
            this.фоновоеИзображениеToolStripMenuItem.Click += new System.EventHandler(this.AddBackGroundImage);
            // 
            // создатьpdfФайлToolStripMenuItem
            // 
            this.создатьpdfФайлToolStripMenuItem.Name = "создатьpdfФайлToolStripMenuItem";
            this.создатьpdfФайлToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.создатьpdfФайлToolStripMenuItem.Text = "Создать (.pdf) файл";
            this.создатьpdfФайлToolStripMenuItem.Click += new System.EventHandler(this.ConvertToPDFButton);
            // 
            // изменитьЗадникToolStripMenuItem
            // 
            this.изменитьЗадникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.залитьКартинкуToolStripMenuItem,
            this.изменитьЦветToolStripMenuItem});
            this.изменитьЗадникToolStripMenuItem.Name = "изменитьЗадникToolStripMenuItem";
            this.изменитьЗадникToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.изменитьЗадникToolStripMenuItem.Text = "Изменить Интерфейс";
            // 
            // залитьКартинкуToolStripMenuItem
            // 
            this.залитьКартинкуToolStripMenuItem.Name = "залитьКартинкуToolStripMenuItem";
            this.залитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.залитьКартинкуToolStripMenuItem.Text = "Залить картинку";
            this.залитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.SetFormImage);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.изменитьЦветToolStripMenuItem.Text = "Изменить цвет";
            this.изменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.SetFormColor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(214, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 388);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "номер стобца";
            this.label1.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(170, 92);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.Addownerstext);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 65);
            this.button5.TabIndex = 10;
            this.button5.Text = "Выбрать стилистику текста";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.ChangingOwnFont);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 61);
            this.button6.TabIndex = 12;
            this.button6.Text = "Поменять текст на набранный выше\r\n\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.ChangingTextNow);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.WidthChangeNumeric);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(34, 102);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown3.TabIndex = 14;
            this.numericUpDown3.Visible = false;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.HeightChangeNumeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Width";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Height";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Программа по конструированию сертификатов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вашСобственныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстИзТаблицыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem добавитьcsvФайлToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem добавитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem поставитьФоновоеИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьpdfФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьФоновыйЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фоновоеИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗадникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

