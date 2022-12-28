using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            webBrowser1.AllowWebBrowserDrop = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.html)|*.html|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            DialogResult result = openFileDialog.ShowDialog();
            webBrowser1.Navigate(openFileDialog.FileName);
            //Form1.Size = new System.Drawing.Size(100, 100);
            Size = new Size(600, 600);
            Label label1 = new Label();
            label1.Size = new Size(200, 20);
            label1.Location = new Point(40, 350);
            label1.Text = "Введите координату х: ";
            Controls.Add(label1);


            Label label2 = new Label();
            label2.Size = new Size(200, 20);
            label2.Location = new Point(40, 370);
            label2.Text = "Введите координату y: ";
            Controls.Add(label2);


            Button btn = new Button();
            btn.Text = "выполнить";
            btn.Location = new Point(20, 400);
            string a = openFileDialog.FileName;
            string[] b = a.Split('\\');
            if (b[b.Length-1] == "1.html")
            { btn.Click += new EventHandler(btn_Click); }
            else if (b[b.Length - 1] == "2.html")
            { btn.Click += new EventHandler(btn_Click1); }
            else
            {
                this.Close();
            }
            Controls.Add(btn);


            textBox1.Size = new Size(50, 20);
            textBox1.Location = new Point(260, 350);
            Controls.Add(textBox1);


            textBox2.Size = new Size(50, 20);
            textBox2.Location = new Point(260, 370);
            Controls.Add(textBox2);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(this.textBox1.Text);
                int y = Convert.ToInt32(this.textBox2.Text);
                if ((x < 5 && x > -4 && y < 0 && y > -3) || (x > -2 && x < 2 && y < 4 && y >= 0))
                {
                    MessageBox.Show("Находится внутри функций");
                    this.toolStripStatusLabel1.Text = "Находится внутри функций";

                }
                else if ((y == -3 & x >= -4 & x <= 5) || (x == -1 || x == 5 & y <= 0 & y >= -3) || (x >= -4 & x <= -2 & y == 0) || (x >= -2 & x <= -5 & y == 0) || (y >= 0 & x <= 4 & x == -2 || x == 2) || (x >= -2 & x <= 2 & y == 4))
                {
                    MessageBox.Show("На границе");
                    this.toolStripStatusLabel1.Text = "На границе";
                }
                else
                {
                    MessageBox.Show("Находится за пределами функции");
                    this.toolStripStatusLabel1.Text = "Находится за пределами функции";
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!!!");
            }
        }
        private void btn_Click1(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(this.textBox1.Text);
                double y = Convert.ToDouble(this.textBox2.Text);
                if (y > 0 && y < 1 && x < Math.Sqrt(y) && x > -Math.Sqrt(y))
                {
                    MessageBox.Show("Находится внутри функций");
                    this.toolStripStatusLabel1.Text = "Находится внутри функций";
                }
                else if ((x * x + y * y < 1) && (y < 1 && y >= 0 && x == Math.Sqrt(y)))
                {
                    MessageBox.Show("На границе");
                    this.toolStripStatusLabel1.Text = "На границе";
                }
                else
                {
                    MessageBox.Show("Находится за пределами функции");
                    this.toolStripStatusLabel1.Text = "Находится за пределами функции";
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!!!");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ПКсп-120 Шокина Анастасия Вариант 13");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
    }
