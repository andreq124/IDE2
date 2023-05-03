using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IDEEEEEEEEEEEEEEEEEEE
{
    public partial class Form3 : Form
    {
        public Form1 frm1 { get; set; }
        string q, q1 = "", q2;
        char sl = '\\';
        int t, ch = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader streamReader1 = new StreamReader("tem.txt");
            t = Int32.Parse(streamReader1.ReadLine());
            streamReader1.Close();
            richTextBox1.BorderStyle = BorderStyle.None;
            if (t == -1)
            {
                //общая тема
                BackColor = Color.Black;
                ForeColor = Color.White;
                //тема менюстрип
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.White;
                сохранитьToolStripMenuItem.BackColor = Color.Black;
                сохранитьКакToolStripMenuItem.BackColor = Color.Black;
                закрытьToolStripMenuItem.BackColor = Color.Black;
                сохранитьToolStripMenuItem.ForeColor = Color.White;
                сохранитьКакToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                открытьФайлToolStripMenuItem.BackColor = Color.Black;
                открытьФайлToolStripMenuItem.ForeColor = Color.White;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.White;
            }
            else if (t == 1)
            {
                //общая тема
                BackColor = Color.White;
                ForeColor = Color.Black;
                //тема менюстрип
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                сохранитьToolStripMenuItem.BackColor = Color.White;
                сохранитьКакToolStripMenuItem.BackColor = Color.White;
                закрытьToolStripMenuItem.BackColor = Color.White;
                сохранитьToolStripMenuItem.ForeColor = Color.Black;
                сохранитьКакToolStripMenuItem.ForeColor = Color.Black;
                закрытьToolStripMenuItem.ForeColor = Color.Black;
                открытьФайлToolStripMenuItem.BackColor = Color.White;
                открытьФайлToolStripMenuItem.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
            }
            //StreamReader docOp = new StreamReader(frm1.s);
            //richTextBox1.Text = docOp.ReadToEnd();
            //docOp.Close();
            //lab();
            //openFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
        }

        void tema()
        {
            StreamReader streamReader1 = new StreamReader("tem.txt");
            t = Int32.Parse(streamReader1.ReadLine());
            streamReader1.Close();
            t *= -1;
            System.IO.File.Delete("tem.txt");
            StreamWriter zn;  //Класс для записи в файл
            FileInfo file = new FileInfo("tem.txt");
            zn = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
            zn.WriteLine(t); //Записываем в файл текст из текстового поля
            zn.Close(); // Закрываем файл
            if (t == -1)
            {
                //общая тема
                BackColor = Color.Black;
                ForeColor = Color.White;
                //тема менюстрип
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.White;
                сохранитьToolStripMenuItem.BackColor = Color.Black;
                сохранитьКакToolStripMenuItem.BackColor = Color.Black;
                закрытьToolStripMenuItem.BackColor = Color.Black;
                сохранитьToolStripMenuItem.ForeColor = Color.White;
                сохранитьКакToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                открытьФайлToolStripMenuItem.BackColor = Color.Black;
                открытьФайлToolStripMenuItem.ForeColor = Color.White;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.White;
            }
            else if (t == 1)
            {
                //общая тема
                BackColor = Color.White;
                ForeColor = Color.Black;
                //тема менюстрип
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                сохранитьToolStripMenuItem.BackColor = Color.White;
                сохранитьКакToolStripMenuItem.BackColor = Color.White;
                закрытьToolStripMenuItem.BackColor = Color.White;
                сохранитьToolStripMenuItem.ForeColor = Color.Black;
                сохранитьКакToolStripMenuItem.ForeColor = Color.Black;
                закрытьToolStripMenuItem.ForeColor = Color.Black;
                открытьФайлToolStripMenuItem.BackColor = Color.White;
                открытьФайлToolStripMenuItem.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
            }
        }

        void lab()
        {
            q = frm1.s;
            int ql = q.Length;
            for (int i = ql - 1; ; i--)
            {
                if (String.Equals(q[i], sl))
                {
                    break;
                }
                else
                {
                    q1 += q[i];
                }
            }
            char[] arr = q1.ToCharArray();
            Array.Reverse(arr);
            string q2 = new string(arr);
            label1.Text = q2;
            q2 = String.Empty;
            q1 = String.Empty;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm1.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter docWR = new StreamWriter(frm1.s);
            docWR.WriteLine(richTextBox1.Text);
            docWR.Close();
        }

        private void asdasdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            //frm3.frm2 = this;
            frm3.Show();
        }

        private void сменитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sq;
            saveFileDialog1.ShowDialog(this);
            frm1.s = saveFileDialog1.FileName;
            StreamWriter docWR = new StreamWriter(frm1.s);
            docWR.WriteLine(richTextBox1.Text);
            docWR.Close();
            StreamReader sr = new StreamReader(frm1.s);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            lab();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result, result1;
            result = MessageBox.Show("Вы уверены, что хотите отерыть ноый файл? Подаробится закрыть старый.", "Открыть файл?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                result1 = MessageBox.Show("Нужно сохранить открытый файл?", "Сохраняем?", MessageBoxButtons.YesNo);
                if (result1 == System.Windows.Forms.DialogResult.No)
                {
                    openFileDialog1.ShowDialog();
                    StreamReader docOp = new StreamReader(openFileDialog1.FileName);
                    frm1.s = openFileDialog1.FileName;
                    richTextBox1.Text = docOp.ReadToEnd();
                    docOp.Close();
                    lab();
                }
                else
                {
                    StreamWriter docWR = new StreamWriter(frm1.s);
                    docWR.WriteLine(richTextBox1.Text);
                    docWR.Close();
                    MessageBox.Show("Успешно сохранено!", "Сохранено.", MessageBoxButtons.OK);
                    openFileDialog1.ShowDialog();
                    StreamReader docOp = new StreamReader(openFileDialog1.FileName);
                    frm1.s = openFileDialog1.FileName;
                    richTextBox1.Text = docOp.ReadToEnd();
                    docOp.Close();
                    lab();
                }
            }
        }

        /////////////
        // Цифорки //
        /////////////

        private void updateNumberLabel()
        {
            //we get index of first visible char and number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int firstLine = richTextBox1.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int lastLine = richTextBox1.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll use its Y value for calculating numberLabel size
            pos = richTextBox1.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            int d = richTextBox1.GetPositionFromCharIndex(0).Y %
                                      (richTextBox1.Font.Height + 1);
            numberLabel.Location = new Point(0, d);
            updateNumberLabel();
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
            richTextBox1_VScroll(null, null);
        }
    }
}
