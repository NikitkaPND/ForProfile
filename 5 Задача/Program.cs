using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Задача
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество чисел, которое хотите ввести: ");

            int Col = 0;
            do
            {
                if (Col >= 100)
                {
                    Console.Write("Введенное число не должно превышать 100: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Col))
                {
                    Console.Write("Введите число! Повторите ввод: ");
                }
            } while (Col > 100);

            int[] example = new int[Col];

            for (int i = 0; i < Col; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                while (!int.TryParse(Console.ReadLine(), out example[i]))
                {
                    Console.WriteLine("Введите число!");
                }
            }
            List<int> res = new List<int>();
            for (int i = 0; i < Col; i++)
            {
                if (Palindrome(example[i]))
                {
                    res.Add(example[i]);
                }
            }
            foreach (int e in res)
            {
                Console.WriteLine($"Число {e} является палиндромом!");
            }
        }
        public static bool Palindrome(int example)
        {
            int n = example;
            int rev = 0;
            while (example > 0)
            {
                var dig = example % 10;
                rev = rev * 10 + dig;
                example /= 10;
            }
            return n == rev;
        }
    }
}
