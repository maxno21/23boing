using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkQueue
{
    class FirstLastList
    {
        private Link first; // Ссылка на первый элемент
        private Link last;  // Ссылка на последний элемент
        //----------------------------------------
        public FirstLastList() // Конструктор
        {
            first = null; // Список пока не содержит элементов
            last = null;
        }
        //----------------------------------------
        public Boolean isEmpty()  //  true, если список пуст
        {
            return first == null;
        }
        //----------------------------------------
        public void insertLast(Complex dd) // Вставка элемента в конец списка
        {
            Link newLink = new Link(dd); // Создание нового элемента
            if (isEmpty()) // Если список пуст
                first = newLink;   // first --> newLink
            else
                last.next = newLink;  // Старое значение last --> newLink
            last = newLink;  // newLink <-- last
        }
        //----------------------------------------
        public Complex deleteFirst() // Удаление первого элемента
                                  // (Предполагается, что список не пуст)
        {
            Complex temp = first.dData;
            if (first.next == null) // Сохранение ссылки
                last = null;  // null <-- last
            first = first.next;  // first --> старое значение next
            return temp;
        }
        //----------------------------------------
        public void displayList()
        {
            Link current = first;  // От начала списка
            while (current != null)  // Перемещение до конца списка
            {
                current.displayLink(); // Вывод данных
                current = current.next;  // Переход к следующему элементу
            }
            System.Console.WriteLine("");
        }

        public int Count_1() //  Количество элементов
        {
            int result = 0;
            Link current = first;  // От начала списка
            while (current != null)  // Перемещение до конца списка
            {
                current = current.next;
                ++result;
            }
            return result;
        }

        public void displayFirst()
        {
            Link current = first;  // От начала списка
            current.displayLink(); // Вывод данных
            System.Console.WriteLine("");
        }
    }
}
