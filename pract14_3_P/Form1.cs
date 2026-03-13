using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract14_3_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                int n = Convert.ToInt32(s);
                while (n <= 0)
                {
                    MessageBox.Show("Неверное число, введи заново");
                    s = textBox1.Text;
                    n = Convert.ToInt32(s);
                }
                Queue<int> Queue = new Queue<int>();
                for (int i = 0; i < n; i++)
                {
                    Queue.Enqueue(i);
                }
                string info = $"n = {n}" +
                    $"\nРазмерность очереди = {Queue.Count} " +
                    $"\nВерхний элемент = {Queue.Peek()} " +
                    $"\nРазмерность очереди = {Queue.Count} " +
                    $"\nСодержимое очереди = ";
                while (Queue.Count > 0)
                {
                    int numb = Queue.Dequeue();
                    info += (numb + " ");
                }
                info += $"\nНовое содержимое очереди = {Queue.Count}";
                MessageBox.Show(info);
            }
            catch(Exception)
            {
                MessageBox.Show("Введено неверное значение");
            }
        }
    }
}
