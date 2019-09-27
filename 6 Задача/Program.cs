using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, col;
            Console.Write("Введите вместимость рюкзака: ");
            while (!int.TryParse(Console.ReadLine(), out M))
            {
                Console.Write("Вместимость рюкзака может быть только целым числом! Пожалуйста, повторите ввод: ");
            }
            Console.Write("Введите количество грузов: ");
            while (!int.TryParse(Console.ReadLine(), out col))
            {
                Console.Write("Количество грузов может быть только целым числом! Пожалуйста, повторите ввод: ");
            }
            int[] Mas_col = new int[col];
            int[] Price = new int[col];
            for (int i = 0; i < col; i++)
            {
                Console.Write($"Введите массу {i + 1} груза: ");
                while (!int.TryParse(Console.ReadLine(), out Mas_col[i]))
                {
                    Console.Write("Масса груза может быть только целым числом! Пожалуйста, повторите ввод: ");
                }
                Console.Write($"Введите цену {i + 1} груза: ");
                while (!int.TryParse(Console.ReadLine(), out Price[i]))
                {
                    Console.Write("Цена груза может быть только целым числом! Пожалуйста, повторите ввод: ");
                }
            }

            int[,] otvet = new int[col + 1, M + 1];
            for (int i = 0; i < col + 1; i++)
                for (int j = 0; j < M; j++)
                {
                    otvet[i, j] = 0;
                }
            for (int k = 1; k <= col; k++)
                for (int s = 1; s <= M; s++)
                {
                    if (s >= Mas_col[k - 1])
                    {
                        var otl1 = otvet[k - 1, s];
                        var otl2 = otvet[k - 1, s - Mas_col[k - 1]] + Price[k - 1];
                        otvet[k, s] = Math.Max(otl1, otl2);
                    }
                    else
                        otvet[k, s] = otvet[k - 1, s];
                }

            List<int> res = new List<int>();
            for (int i = col; i > 0; i--)
            {
                if (otvet[i, M] == 0)
                {
                    break;
                }
                if (otvet[i - 1, M] == otvet[i, M])
                {
                    continue;
                }
                else
                {
                    M -= Mas_col[i - 1];
                    res.Add(i);
                }
            }

            int ee = 0;
            foreach (int e in res)
            {
                Console.WriteLine($"{++ee}: груз № {e} массой {Mas_col[e - 1]} ");
            }

            if (res.Count == 0)
            {
                Console.WriteLine("Ни один груз не влезает!");
            }
        }
    }
}
