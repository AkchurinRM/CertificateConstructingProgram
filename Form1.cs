using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ВКР
{
    public partial class Form1 : Form
    {
        List<Label> listoftext = new List<Label>();
        System.Drawing.Point p;
        System.Drawing.Point point;
        Bitmap bm;
        List<PictureBox> listofpb = new List<PictureBox>();
        List<List<string>> listoflistofstring;
        List<List<Label>> listoflistoflabel = new List<List<Label>>();
        bool addingfile = false;
        Label changinglabelnow;
        PictureBox pbo;
        string ImageFileName;
        string[] s;

        public Form1()
        {
            try
            { 
            Location = new Point(0,0);
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimumSize = new Size(175, 60);
            MaximumSize = new Size(175, 60);
            fontDialog1.ShowColor = true;
            numericUpDown2.Minimum = 1;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void buttonaddtext(object sender, EventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
            listoftext.Add(new Label());
            int lastindexoftext = listoftext.Count-1;
            listoftext[lastindexoftext].Text = "Здесь мог бы быть ваш текст!!!";
            listoftext[lastindexoftext].Location = new System.Drawing.Point(180, 40);
            listoftext[lastindexoftext].AutoSize = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            listoftext[lastindexoftext].Parent = pictureBox1;
            listoftext[lastindexoftext].BackColor = Color.LightGoldenrodYellow;
            listoftext[lastindexoftext].MouseDown += DownonLabel;
            listoftext[lastindexoftext].MouseMove += MoveLabel;
            listoftext[lastindexoftext].MouseClick += UpperText;
            listoftext[lastindexoftext].MouseDoubleClick += ChangingText;
            panel1.Controls.Add(listoftext[lastindexoftext]);
            listoftext[lastindexoftext].BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ChangingText(object sender, MouseEventArgs e)
        {
            try
            { 
            changinglabelnow = sender as Label;
            textBox1.Text = changinglabelnow.Text;
            {
                // Ниже - видимость
                {
                    comboBox1.Visible = false;
                    button5.Visible = true;
                    button6.Visible = true;
                    textBox1.Visible = true;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
            }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }
        
        private void ChangingFont(object sender, MouseEventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
            Label l = sender as Label;
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            l.Font = fontDialog1.Font;
            l.ForeColor = fontDialog1.Color;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void UpperText(object sender, MouseEventArgs e)
        {
            try
            {
                // Ниже - видимость
                {
                    comboBox1.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                Label l = sender as Label;
                l.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void DownonLabel(object sender, MouseEventArgs e)
        {
            try
            {
                {
                    comboBox1.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                Label l = sender as Label;
                p = MousePosition;
                point = l.Location;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void MoveLabel(object sender, MouseEventArgs e)
        {
            try
            {
                System.Drawing.Point mousenow = MousePosition;
                Label l = sender as Label;
                if (e.Button == MouseButtons.Left)
                {
                    l.Location = new System.Drawing.Point(point.X + mousenow.X - p.X, point.Y + mousenow.Y - p.Y);
                    if ((l.Location.X > pictureBox1.Location.X + pictureBox1.Width) || (l.Location.Y > pictureBox1.Location.Y + pictureBox1.Height))
                    {
                        l.Visible = false;
                    }
                    else l.Visible = true;
                    if (((l.Location.X < pictureBox1.Location.X) || (l.Location.Y < pictureBox1.Location.Y)) || ((l.Location.X > pictureBox1.Location.X + pictureBox1.Width) || (l.Location.Y > pictureBox1.Location.Y + pictureBox1.Height)))
                    {
                        l.Visible = false;
                    }
                    else l.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void VerticalOrientation(object sender, EventArgs e)
        {
            try
            {
                // Ниже - видимость
                {
                    comboBox1.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                if (listoftext != null)
                {
                    for (int i = 0; i < listoftext.Count; i++)
                    {
                        pictureBox1.Controls.Remove(listoftext[i]);
                    }
                    listoftext.Clear();
                }
                if (listofpb != null)
                {
                    for (int i = 0; i < listofpb.Count; i++)
                    {
                        panel1.Controls.Remove(listofpb[i]);
                    }
                    listofpb.Clear();
                }
                if (listoflistoflabel != null)
                {
                    for (int i = 0; i < listoflistoflabel.Count; i++)
                    {
                        if (listoflistoflabel[i] != null)
                        {
                            for (int j = 0; j < listoflistoflabel[i].Count; j++)
                            {
                                panel1.Controls.Remove(listoflistoflabel[i][j]);
                            }
                            listoflistoflabel[i].Clear();
                        }
                    }
                }
                listofpb.Clear();
                pictureBox1.Visible = true;
                pictureBox1.Size = new Size(620, 877);
                panel1.Location = new System.Drawing.Point(180, 40);
                panel1.Size = new Size(640, 575);
                panel1.Controls.Add(pictureBox1);
                pictureBox1.Location = new System.Drawing.Point(0, 0);
                MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
                MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void GorizontalOrientation(object sender, EventArgs e)
        {
            try
            {
                // Ниже - видимость
                {
                    comboBox1.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                if (listoftext != null)
                {
                    for (int i = 0; i < listoftext.Count; i++)
                    {
                        panel1.Controls.Remove(listoftext[i]);
                    }
                    listoftext.Clear();
                }
                if (listofpb != null)
                {
                    for (int i = 0; i < listofpb.Count; i++)
                    {
                        panel1.Controls.Remove(listofpb[i]);
                    }
                    listofpb.Clear();
                }
                if (listoflistoflabel != null)
                {
                    for (int i = 0; i < listoflistoflabel.Count; i++)
                    {
                        if (listoflistoflabel[i] != null)
                        {
                            for (int j = 0; j < listoflistoflabel[i].Count; j++)
                            {
                                panel1.Controls.Remove(listoflistoflabel[i][j]);
                            }
                            listoflistoflabel[i].Clear();
                        }
                    }
                }
                listofpb.Clear();
                pictureBox1.Visible = true;
                pictureBox1.Size = new Size(877, 620);
                panel1.Size = new Size(895, 575);
                panel1.Location = new System.Drawing.Point(180, 40);
                panel1.Controls.Add(pictureBox1);
                pictureBox1.Location = new System.Drawing.Point(0, 0);
                MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
                MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private System.Drawing.Image CreateImage(int j)
        {
            try
            { 
            bool flag = true;
            bool flag1 = true;
            bool flag2 = true;
            do
            {
                flag = false;
                for (int i = 0; i < listoftext.Count; i++)
                {
                    if (!listoftext[i].Visible)
                    {
                        panel1.Controls.Remove(listoftext[i]);
                        listoftext.Remove(listoftext[i]);
                    }
                }
                for (int i = 0; i < listoftext.Count; i++)
                {
                    if (!listoftext[i].Visible)
                    {
                        flag = true;
                    }
                }
            }
            while (flag);
            do
            {
                flag1 = false;
                for (int i = 0; i < listofpb.Count; i++)
                {
                    if (!listofpb[i].Visible)
                    {
                        panel1.Controls.Remove(listofpb[i]);
                        listofpb.Remove(listofpb[i]);
                    }
                }
                for (int i = 0; i < listofpb.Count; i++)
                {
                    if (!listofpb[i].Visible)
                    {
                        flag1 = true;
                    }
                }
            }
            while (flag1);
            if (listoflistoflabel!=null)
            {
                do
                {
                    flag2 = false;
                    for (int i = 0; i < listoflistoflabel.Count; i++)
                    {
                        for (int k = 0; k < listoflistoflabel[i].Count; k++)
                        {
                            if (!listoflistoflabel[i][k].Visible)
                            {
                                panel1.Controls.Remove(listoflistoflabel[i][k]);
                                listoflistoflabel[i].Remove(listoflistoflabel[i][k]);
                            }
                        }
                    }
                    for (int i = 0; i < listoflistoflabel.Count; i++)
                    {
                        for (int k = 0; k < listoflistoflabel[i].Count; k++)
                        {
                            if (!listoflistoflabel[i][k].Visible)
                            {
                                flag2 = true;
                            }
                        }
                    }
                }
                while (flag2);
            }
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(pictureBox1.BackColor);
                if (pictureBox1.Image != null)
                {
                    g.DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
                for (int i = 0; i < listoftext.Count; i++)
                    {
                        Pen pen = new Pen(listoftext[i].ForeColor);
                        System.Drawing.Point point = new Point(listoftext[i].Location.X, listoftext[i].Location.Y);
                        g.DrawString(listoftext[i].Text, listoftext[i].Font, pen.Brush, point);
                    }
                for (int i = 0; i < listofpb.Count; i++)
                    {
                        System.Drawing.Point point = new Point(listofpb[i].Location.X, listofpb[i].Location.Y);
                        g.DrawImage(listofpb[i].Image, listofpb[i].Location.X, listofpb[i].Location.Y, listofpb[i].Width, listofpb[i].Height);
                    }
                for (int i = 0; i < listoflistoflabel.Count; i++)
                {
                    for (int k = 0; k < listoflistoflabel[i].Count; k++)
                    {
                        Pen pen = new Pen(listoflistoflabel[i][k].ForeColor);
                        System.Drawing.Point point = new Point(listoflistoflabel[i][k].Location.X, listoflistoflabel[i][k].Location.Y);
                        g.DrawString(listoflistofstring[i][j], listoflistoflabel[i][k].Font, pen.Brush, point);
                    }
                }
            }
            return bm;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); return null; }
        }

        private void ConvertToPDFButton(object sender, EventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
            string folder;
            System.Drawing.Image[] images;
                if (listoflistofstring != null)
            {
                images = new System.Drawing.Image[listoflistofstring[0].Count];
            }
            else { ConvertToPDFList(); return; }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                for (int i = 0; i < listoflistofstring[0].Count; i++)
                {
                    images[i] = CreateImage(i);
                }
                ImgToPdf(folder, images);
            }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ConvertToPDFList()
            {
                try
                { 
                // Ниже - видимость
                {
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                string folder;
                System.Drawing.Image[] images = new System.Drawing.Image[1];
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folder = folderBrowserDialog1.SelectedPath;
                    images[0] = CreateImage(0);
                    ImgToPdf(folder, images);
                }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ImgToPdf(string folder, System.Drawing.Image[] images)
        {
            try
            {
                // Создаем документ
                var document = new Document(iTextSharp.text.PageSize.A4,25,25,25,25);
                using (var stream = new FileStream(folder + "\\document.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    // Проходим по всем изображениям в каталоге
                    foreach (var image in images)
                    {
                            var page = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                            // Размеры изображения
                            float width = page.Width;
                            float height = page.Height;
                            if (width < height)
                            {
                                // Книжная
                                document.SetPageSize(iTextSharp.text.PageSize.A4);
                            }
                            else
                            {
                                // Альбомная
                                document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                            }

                            document.NewPage();

                            // Масштабируем размеры изображения под параметры страницы
                            if (width < height)
                            {
                                // Для книжной ориентации
                                if (page.Height > iTextSharp.text.PageSize.A4.Height-50)
                                {
                                    page.ScaleToFit(iTextSharp.text.PageSize.A4.Width-25, iTextSharp.text.PageSize.A4.Height-50);
                                }
                                else if (page.Width > iTextSharp.text.PageSize.A4.Width-25)
                                {
                                    page.ScaleToFit(iTextSharp.text.PageSize.A4.Width-25, iTextSharp.text.PageSize.A4.Height-50);
                                }
                            }
                            else
                            {
                                // Для альбомной ориентации
                                if (page.Height > iTextSharp.text.PageSize.A4.Height-50)
                                {
                                    page.ScaleToFit(iTextSharp.text.PageSize.A4.Height-25, iTextSharp.text.PageSize.A4.Width-50);
                                }
                                else if (page.Width > iTextSharp.text.PageSize.A4.Width-25)
                                {
                                    page.ScaleToFit(iTextSharp.text.PageSize.A4.Height-25, iTextSharp.text.PageSize.A4.Width-50);
                                }
                            }
                            // Добавляем страницу в документ
                            page.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                            document.Add(page);
                    }

                    document.Close();
                }
            }
            catch(IOException ex) { MessageBox.Show("Вы просматриваете данный (.pdf) файл, в связи с этим их обработка не возможна"); }
        
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void AddImage(object sender, EventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
            }
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Image files (*.JPG, *.JPEG, *.PNG)|*.jpg;*.jpeg;*.png" ;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                listofpb.Add(new PictureBox());
                int lastindexofpicturebox = listofpb.Count - 1;
                panel1.Controls.Add(listofpb[lastindexofpicturebox]);
                listofpb[lastindexofpicturebox].Size = new Size(System.Drawing.Image.FromFile(openfile.FileName).Width, System.Drawing.Image.FromFile(openfile.FileName).Height);
                listofpb[lastindexofpicturebox].Image = System.Drawing.Image.FromFile(openfile.FileName);
                listofpb[lastindexofpicturebox].Location = new System.Drawing.Point(180, 40);
                listofpb[lastindexofpicturebox].MouseDown += DownonPictureBox;
                listofpb[lastindexofpicturebox].SizeMode = PictureBoxSizeMode.StretchImage;
                listofpb[lastindexofpicturebox].MouseMove += MovePictureBox;
                listofpb[lastindexofpicturebox].MouseClick += UpperImage;
                listofpb[lastindexofpicturebox].MouseDoubleClick += ChangepicSize;
                listofpb[lastindexofpicturebox].BringToFront();
            }
            else MessageBox.Show("Нужно выбрать  .jpg / .jpeg файл");
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void DownonPictureBox(object sender, MouseEventArgs e)
        {
            try
            {
                // Ниже - видимость
                {
                    comboBox1.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    textBox1.Visible = false;
                    numericUpDown2.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown3.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                PictureBox pb = sender as PictureBox;
                p = MousePosition;
                point = pb.Location;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void MovePictureBox(object sender, MouseEventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                comboBox1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
            }
            System.Drawing.Point mousenow = MousePosition;
            PictureBox pb = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                pb.Location = new System.Drawing.Point(point.X + mousenow.X - p.X, point.Y + mousenow.Y - p.Y);
                if ((pb.Location.X > pictureBox1.Location.X + pictureBox1.Width) || (pb.Location.Y > pictureBox1.Location.Y + pictureBox1.Height))
                {
                    pb.Visible = false;
                }
                else pb.Visible = true;
                if (((pb.Location.X < pictureBox1.Location.X) || (pb.Location.Y < pictureBox1.Location.Y)) || ((pb.Location.X > pictureBox1.Location.X + pictureBox1.Width) || (pb.Location.Y > pictureBox1.Location.Y + pictureBox1.Height)))
                {
                    pb.Visible = false;
                }
                else pb.Visible = true;
            }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void UpperImage(object sender, MouseEventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
            }
            PictureBox pb = sender as PictureBox;
            pb.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ChangepicSize(object sender, MouseEventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = true;
                numericUpDown3.Visible = true;
                label3.Visible = true;
                label2.Visible = true;
                comboBox1.Visible = false;
            }
            pbo = sender as PictureBox;
            numericUpDown1.Maximum = pbo.Width+500;
            numericUpDown1.Value = pbo.Width;
            numericUpDown1.Minimum = 3;
            numericUpDown3.Maximum = pbo.Height+500;
            numericUpDown3.Value = pbo.Height;
            numericUpDown3.Minimum = 3;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void Openfilebutton(object sender, EventArgs e)
        {
            try
            { 
            // Ниже - видимость
            {
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                numericUpDown2.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
            }
            try
            {
                OpenFileDialog fileopening = new OpenFileDialog();
                fileopening.Filter = "CSV Files (*.csv)|*.csv";
                fileopening.DefaultExt = "csv";
                if (fileopening.ShowDialog() == DialogResult.Cancel)
                    return;

                string fileName = fileopening.FileName;
                openfile(fileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void openfile(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.Default);
            string line;
            string Line0 = sr.ReadLine();
            s = Line0.Split(';');
            listoflistofstring = new List<List<string>>();
            for (int i = 0; i < s.Length; i++)
            {
                listoflistofstring.Add(new List<string>());
            }
            numericUpDown2.Maximum = s.Length;
                comboBox1.Items.Clear();
                for (int i = 0; i < s.Length; i++)
                {
                    comboBox1.Items.Add(s[i]);
                }
            while ((line = sr.ReadLine()) != null)
            {
                Toarr(line);
            }
                sr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }

            addingfile = true;
        }

        private void Toarr(string line)
        {
            try { 
            string[] s = line.Split(';');
            if (s.Length != listoflistofstring.Count)
            {
                throw new ArgumentException("Неправильная таблица (кол-во столбцов в одной из строк не совпадает с заявленным)");
            }
            for (int i = 0; i < s.Length; i++)
            {
                listoflistofstring[i].Add(s[i]);
            }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void AddtextfromTabl(object sender, EventArgs e)
        {
            try
            { 
            if (!addingfile)
            {
                MessageBox.Show("Для начала нужно залить .csv файл");
                return;
            }
            // Ниже - видимость
            {
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Visible = false;
                button4.Visible = true;
                label1.Visible = true;
                numericUpDown1.Visible = false;
                numericUpDown3.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = true;
            }
            for (int i = 0; i < listoflistofstring.Count; i++)
            {
                listoflistoflabel.Add(new List<Label>());
            }
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void Addownerstext(object sender, EventArgs e)
        {
            try { 
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите стобец из таблицы");
                return;
            }
            int i = comboBox1.SelectedIndex;
            listoflistoflabel[i].Add(new Label());
            int lastindexoftext = listoflistoflabel[i].Count - 1;
            listoflistoflabel[i][lastindexoftext].Text = comboBox1.SelectedItem.ToString();
            listoflistoflabel[i][lastindexoftext].Location = new System.Drawing.Point(180, 40);
            listoflistoflabel[i][lastindexoftext].AutoSize = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            listoflistoflabel[i][lastindexoftext].Parent = pictureBox1;
            listoflistoflabel[i][lastindexoftext].BackColor = Color.LightYellow;
            listoflistoflabel[i][lastindexoftext].MouseDown += DownonLabel;
            listoflistoflabel[i][lastindexoftext].MouseMove += MoveLabel;
            listoflistoflabel[i][lastindexoftext].MouseClick += UpperText;
            listoflistoflabel[i][lastindexoftext].MouseDoubleClick += ChangingFont;
            panel1.Controls.Add(listoflistoflabel[i][lastindexoftext]);
            listoflistoflabel[i][lastindexoftext].BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ChangingOwnFont(object sender, EventArgs e)
        {
            try
            { 
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            changinglabelnow.Font = fontDialog1.Font;
            changinglabelnow.ForeColor = fontDialog1.Color;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void ChangingTextNow(object sender, EventArgs e)
        {
            try { 
            changinglabelnow.Text = textBox1.Text;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }
        
        private void WidthChangeNumeric(object sender, EventArgs e)
        {
            try { 
            pbo.Width = (int)numericUpDown1.Value;
            pbo.Image = pbo.Image;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void HeightChangeNumeric(object sender, EventArgs e)
        {
            try { 
            pbo.Height = (int)numericUpDown3.Value;
            pbo.Image = pbo.Image;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void AddBackGroundImage(object sender, EventArgs e)
        {
            try { 
            OpenFileDialog openimage = new OpenFileDialog();
            openimage.Filter = "Image files (*.BMP, *.JPG, *.JPEG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.jpeg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                ImageFileName = openimage.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(ImageFileName);
            }
            else return;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void SetBackGroundColor(object sender, EventArgs e)
        {
            try { 
            ColorDialog colorset = new ColorDialog();
            if (colorset.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                pictureBox1.BackColor = colorset.Color;
            }
            else return;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }

        private void SetFormImage(object sender, EventArgs e)
        {
            try { 
            OpenFileDialog openimage = new OpenFileDialog();
            openimage.Filter = "Image files (*.BMP, *.JPG, *.JPEG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.jpeg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                ImageFileName = openimage.FileName;
                this.BackgroundImage = System.Drawing.Image.FromFile(ImageFileName);
            }
            else return;
        }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
}

        private void SetFormColor(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorset = new ColorDialog();
                if (colorset.ShowDialog() == DialogResult.OK)
                {
                    this.BackgroundImage = null;
                    BackColor = colorset.Color;
                }
                else return;
            }
            catch (Exception ex) { MessageBox.Show("Нераспознанная ошибка"); }
        }
    }
}
