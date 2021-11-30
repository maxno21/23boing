using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkQueue
{
    class Link
    {
        public Complex dData;    // Данные
        public Link next;     // Следующий элемент в списке
        //--------------------------------------------
        public Link(Complex d) // Конструктор
        {
            dData = d;
        }
        //--------------------------------------------
        public void displayLink() // Вывод содержимого элемента
        {
            System.Console.Write(dData + " ");
        }
    }
}
