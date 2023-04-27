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
    public partial class Form2 : Form
    {
        public Form1 frm1 { get; set; }
        string q, q1 = "", q2;
        char sl = '\\';
        int t, ch = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.BorderStyle = BorderStyle.None;
            tema();
            //try
            //{
                StreamReader docOp = new StreamReader(frm1.s);
                richTextBox1.Text = docOp.ReadToEnd();
                docOp.Close();
            //}
            //catch
            //{
            //}
            lab();
            //openFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
        }

        void tema()
        {
            StreamReader streamReader1 = new StreamReader("tem.txt");
            t = streamReader1.Read();
            streamReader1.Close();
            t *= -1;
            System.IO.File.Delete("tem.txt");
            StreamWriter zn;  //Класс для записи в файл
            FileInfo file = new FileInfo("tem.txt");
            zn = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
            zn.WriteLine(t); //Записываем в файл текст из текстового поля
            zn.Close(); // Закрываем файл
            StreamReader streamReader = new StreamReader("tem.txt"); //Открываем файл для чтения
            t = Int32.Parse(streamReader.ReadLine());
            streamReader.Close();
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
                //button1.BackColor = Color.Black;
                //button2.BackColor = Color.Black;
                //button3.BackColor = Color.Black;
                //button4.BackColor = Color.Black;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сменитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sq;
            saveFileDialog1.ShowDialog(this);
            sq = saveFileDialog1.FileName;
            StreamWriter docWR = new StreamWriter(saveFileDialog1.FileName);
            docWR.WriteLine(richTextBox1.Text);
            docWR.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}
