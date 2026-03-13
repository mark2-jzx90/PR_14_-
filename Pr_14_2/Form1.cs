using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_14_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string file1 = "tetx1.txt";
                string file2 = "text2.txt";
                Stack<int> stack = new Stack<int>();
                List<int> closingskobka = new List<int>();
                for(int i = 0; i < textBox1.Text.Length; i++)
                {
                    char c = textBox1.Text[i];
                    if (c == '(')
                    {
                        stack.Push(i);
                    }
                    else if(c == ')')
                    {
                        if(stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            closingskobka.Add(i);
                        }
                    }
                    
                }
                if(stack.Count == 0 && closingskobka.Count == 0)
                {
                    MessageBox.Show("Скобки сбалансированы");
                }
                else
                {
                    MessageBox.Show("Скобки не сбалансированы");

                    foreach(int pos in stack)
                    {
                        string proverka = textBox1.Text.Substring(0, pos) + " < " + textBox1.Text[pos] + " > " + textBox1.Text.Substring(pos + 1);
                        MessageBox.Show($"Лишняя скобка  впозции {pos+1}. Выражение: {proverka}");
                    }
                    foreach (int pos in closingskobka)
                    {
                        string proverka = textBox1.Text.Substring(0, pos) + " < " + textBox1.Text[pos] + " > " + textBox1.Text.Substring(pos + 1);
                        MessageBox.Show($"Лишняя скобка  впозции {pos + 1}. Выражение: {proverka}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Напиши выражение");
            }
            File.WriteAllText("text1.txt",textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Stack<int> stack = new Stack<int>();
                List<int> closingskobka = new List<int>();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    char c = textBox1.Text[i];
                    if (c == '(')
                    {
                        stack.Push(i);
                    }
                    else if (c == ')')
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            closingskobka.Add(i);
                        }
                    }
                }
                if (stack.Count == 0 && closingskobka.Count == 0)
                {
                    MessageBox.Show("Исправлять нечего!");
                }
                else
                {
                    MessageBox.Show("Скобки не сбалансированы.");

                    foreach(int pos in stack)
                    {
                        textBox1.Text = textBox1.Text.Remove(pos, 1);
                    }
                    foreach(int pos in closingskobka)
                    {
                        textBox1.Text = textBox1.Text.Remove(pos, 1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите выражение");
            }
            File.WriteAllText("text2.txt", textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
