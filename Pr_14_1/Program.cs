using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N = ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Неверное значение");
                    Console.ReadLine();
                    return;
                }
                Stack <int> a = new Stack <int>(n);
                for (int i = 1; i <= n; i++)
                {
                    a.Push(i);
                }
                Console.WriteLine($"Размерность стека: {a.Count}");
                Console.WriteLine($"Верхний элемент стека: {a.Peek()}");
                Console.WriteLine($"Размерность стека: {a.Count}");
                Console.Write("Содержимое стека: ");
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(a.Pop() + " ");

                }
                Console.WriteLine($"\nНовый размер стека {a.Count}");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Неверный формат данных");
            }
        }
    }
    
}
