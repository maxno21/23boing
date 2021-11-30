using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkStack
{
    class Link<T>
        //where T : ICloneable
    {
        public T dData; // Данные
        public Link<T> next; // Следующий элемент в списке

        //-------------------------------------------------
        public Link(T dd) // Конструктор
        {
            dData = dd;
        }
        //-------------------------------------------------
        public void displayLink() // Вывод содержимого элемента
        {
            Console.Write(dData + " ");
        }
    }
}
