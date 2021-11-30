using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkQueue
{
    class Complex
    {
        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
        }

        public double Re { get; set; }
        public double Im { get; set; }

        public override string ToString()
        {
            return $"{Re}+{Im}i";
        }
        //--------------------------------------------
        public void displayLink1() // Вывод содержимого элемента
        {
            System.Console.Write($"{Re}+{Im}i" + " ");
        }
    }
}

