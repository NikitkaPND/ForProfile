using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Задача
{
    class Program
    {

        static void Main(string[] args)
        {
            int Number;
            Console.Write("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out Number))
            {
                Console.WriteLine("Введите целое число!");
            }
            number Number_Example = new number(Number);
            if (Number_Example.IsEven())
            {
                Console.WriteLine("Введенное число четное!");
            }
            else Console.WriteLine("Введенное число нечетное!");
            if (Number_Example.IsPrime())
            {
                Console.WriteLine("Введенное число простое!");
            }
            else Console.WriteLine("Введенное число составное!");
        }
    }
}
