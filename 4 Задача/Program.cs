using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string Input_String = Console.ReadLine();
            Console.Write("Введите искомое слово: ");
            string Search_word = Console.ReadLine();
            int count = Regex.Split(Input_String.ToLower(), @"\W+").Count(x => x == Search_word.ToLower());
            Console.WriteLine($"Количество вхождений: {count}");
        }
    }
}
