using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkQueue
{
    class LinkQueue
    {
        private FirstLastList theList;
        //----------------------------------------
        public LinkQueue() // Конструктор
        {
            theList = new FirstLastList(); // Создание 2-стороннего списка
        }
        //----------------------------------------
        public Boolean isEmpty() // true, если очередь пуста
        {
            return theList.isEmpty();
        }
        //----------------------------------------
        public void Enqueue(Complex j)  //  Вставка элемента в конец очереди
        {
            theList.insertLast(j);
        }
        //----------------------------------------
        public Complex remove()  // Удаление элемента в начале очереди
        {
            return theList.deleteFirst();
        }
        //----------------------------------------
        public void Print() // Распечатка содержимого очереди
        {
            System.Console.Write("Queue (front-->rear): ");
            theList.displayList();
        }

        public void Count()  //  Количество элементов в очереди
        {
            System.Console.WriteLine("Count " + theList.Count_1());
        }

        public void Dequeue() // Получение числа из начала очереди и удаление его
        {
            System.Console.Write("First-->remove): ");
            theList.displayFirst();
            theList.deleteFirst();
        }

        public void Peek() // Получение числа из начала очереди
        {
            System.Console.Write("First-->: ");
            theList.displayFirst();
        }
    }
}
