using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Задача
{
    class number
    {
        private double numb;

        public double Numb { get => numb; set => numb = value; }

        public bool IsEven()
        {
            return numb % 2 == 0;
        }

        public bool IsPrime()
        {
            if (IsEven() && numb > 2)
                return false;
            int buf = 3;
            while (buf * buf <= numb && numb % buf != 0 && numb != 0)
            {
                buf += 2;
            }
            return !(buf * buf < numb);
        }

        public number(double number)
        {
            this.numb = number;
        }
    }
}
