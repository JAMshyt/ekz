using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string web;

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "html (*.html)|*.html|All files (*.*)|*.*";
            f.ShowDialog();
            if (f.SafeFileName == "1.html" || f.SafeFileName == "2.html")
            {
                webBrowser1.Navigate(f.FileName);
                this.Height += 60;
                web = f.SafeFileName;
            }
            else MessageBox.Show("Неподходящий файл (выберите 1.html или 2.html)");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил Щербаков Захар Михайлович, вариант 16");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            double x = 0, y = 0;
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("В поле \"X\" введено не число");
                flag = false;
            }

            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("В поле \"Y\" введено не число");
                flag = false;
            }

            if (flag)
            {
                if (web == "1.html")//1 функция
                {
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            if (x * x + y * y < 4 * 4)
                            {
                                MessageBox.Show("Внутри области");
                                toolStripStatusLabel1.Text = "Внутри области";
                            }
                            else
                            {
                                if (x * x + y * y > 4 * 4)
                                {
                                    MessageBox.Show("Вне области");
                                    toolStripStatusLabel1.Text = "Вне области";
                                }
                                else
                                {
                                    MessageBox.Show("На границе");
                                    toolStripStatusLabel1.Text = "На границе";
                                }
                            }
                        }
                        if (y == 0)
                        {
                            if (x <= 5)
                            {
                                MessageBox.Show("На границе");
                                toolStripStatusLabel1.Text = "На границе";
                            }
                            else
                            {
                                MessageBox.Show("Вне области");
                                toolStripStatusLabel1.Text = "Вне области";
                            }

                        }
                        if (y < 0)
                        {
                            if (x * x + Math.Pow(y, 2) < 5 * 5)
                            {
                                MessageBox.Show("Внутри области");
                                toolStripStatusLabel1.Text = "Внутри области";
                            }
                            else
                            {
                                if (x * x + y * y == 5 * 5)
                                {
                                    MessageBox.Show("На границе");
                                    toolStripStatusLabel1.Text = "На границе";

                                }
                                else
                                {
                                    MessageBox.Show("Вне области");
                                    toolStripStatusLabel1.Text = "Вне области";
                                }

                            }
                        }
                    }
                    else if (x == 0)
                    {
                        if (y <= 4 | y <= 5)
                        {
                            MessageBox.Show("На границе");
                            toolStripStatusLabel1.Text = "На границе";
                        }
                        else
                        {
                            MessageBox.Show("Вне области");
                            toolStripStatusLabel1.Text = "Вне области";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вне области");
                        toolStripStatusLabel1.Text = "Вне области";
                    }
                }


                if (web == "2.html")//2 функция
                {
                    if (x < 0)
                    {
                        MessageBox.Show("Вне области");
                        toolStripStatusLabel1.Text = "Вне области";
                    }
                    else
                    {
                        if (y == 0)
                        {
                            if (x <= 1 | x >= -1)
                            {
                                MessageBox.Show("На границе");
                                toolStripStatusLabel1.Text = "На границе";
                            }
                            else
                            {
                                MessageBox.Show("Вне области");
                                toolStripStatusLabel1.Text = "Вне области";
                            }
                        }

                        if (x * x + y * y == 1)
                        {
                            MessageBox.Show("На границе"); //если равен радиусу
                            toolStripStatusLabel1.Text = "На границе";
                        }
                        else if (y == x * x)
                        {
                            MessageBox.Show("На границе"); //если равен параболе
                            toolStripStatusLabel1.Text = "На границе";
                        }
                        else
                        {
                            if (x * x + y * y < 1 & y < x * x)
                            {
                                MessageBox.Show("Внутри области");
                                toolStripStatusLabel1.Text = "Внутри области";
                            }
                            if (x * x + y * y > 1 & y > x * x)
                            {
                                MessageBox.Show("Внутри области");
                                toolStripStatusLabel1.Text = "Внутри области";
                            }

                            if (x * x + y * y > 1 & y < x * x)
                            {
                                MessageBox.Show("Вне области");
                                toolStripStatusLabel1.Text = "Вне области";
                            }
                            if (x * x + y * y < 1 & y > x * x)
                            {
                                MessageBox.Show("Вне области");
                                toolStripStatusLabel1.Text = "Вне области";
                            }
                        }
                    }
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }

}

