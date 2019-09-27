using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _String;
            Console.Write("Введите предложение: ");
            string Input_String = Console.ReadLine();
            _String = Input_String.Split(' ');
            Console.WriteLine($"Количество слов в предложении: {_String.Length}");

            String_Helper @string = new String_Helper();

            @string.String = _String;
            @string.Up_1_letter();
            @string.Sorting();
            @string.print();
            Console.WriteLine();
        }
    }
}
