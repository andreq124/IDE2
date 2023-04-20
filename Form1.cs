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
using System.Threading;
using FastTreeNS;

namespace IDEEEEEEEEEEEEEEEEEEE
{
    public partial class Form1 : Form
    {
        int t; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("tem.txt"); //Открываем файл для чтения
            t = Int32.Parse(streamReader.ReadLine());
            streamReader.Close();
            label1.Text = "RykoYoki C±#";
            if (t == -1)
            {
                BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                ForeColor = Color.White;
            }
            button1.Text = "Создать новый файл";
            button2.Text = "Открыть файл";
            button3.Text = "Прекратить сеанс сатанизма";
            button4.Text = "Сменить тему";
            openFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t *= -1;
            System.IO.File.Delete("tem.txt");
            StreamWriter zn;  //Класс для записи в файл
            FileInfo file = new FileInfo("tem.txt");
            zn = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
            zn.WriteLine(t); //Записываем в файл текст из текстового поля
            zn.Close(); // Закрываем файл
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.FileName = openFileDialog1.FileName;
            saveFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}