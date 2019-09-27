using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Задача
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2;
            Console.Write("Введите первое число: ");
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Введите корректное число!");
                Console.Write("Введите первое число: ");
            }
            Console.Write("Введите второе число: ");
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Введите корректное число!");
                Console.Write("Введите второе число: ");
            }
            Math_Operation Example = new Math_Operation();

            Console.Write($"НОД: {Example.gcd(number1, number2)}\nНОК: {Example.lcm(number1, number2)}\n");
        }
    }
}
