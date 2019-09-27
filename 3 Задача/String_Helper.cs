using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Задача
{
    class String_Helper
    {
        private string[] _String;

        public string[] String { get => _String; set => _String = value; }

        public void Up_1_letter()
        {
            for (int i = 0; i < _String.Length; i++)
            {
                _String[i] = _String[i].Substring(0, 1).ToUpper() + _String[i].Remove(0, 1);
            }
        }

        public void Sorting()
        {
            _String = _String.OrderBy(o => o).ToArray();
        }

        public void print()
        {
            foreach (string print in _String)
            {
                Console.Write($"{print} ");
            }
        }

    }
}
