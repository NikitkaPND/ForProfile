using System;

namespace _2_Задача
{
    class Math_Operation
    {

        public int gcd(int number1, int number2)
        {
            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }
            return Math.Abs(Math.Max(number1, number2));
        }

        public int lcm(int number1, int number2)
        {
            return Math.Abs(number1 * number2) / gcd(number1, number2);
        }
    }
}
