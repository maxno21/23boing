using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkStack
{
    class LinkList<T>
        where T: ICloneable
    {
        private Link<T> first; // Ссылка на первый элемент в списке

        //----------------------------------------------------------
        public LinkList() // Конструктор
        {
            first = null; // Список пока не содержит элементов
        }
        //----------------------------------------------------------
        public Boolean isEmpty() // true, если список пуст
        {
            return (first == null);
        }
        //------------------------------------------------
        public void insertFirst(T dd) // Вставка элемента в начало стека
                                      // Создание нового элемента
        {
            Link<T> newLink = new Link<T>(dd);
            newLink.next = first; // newLink --> старое значение first
            first = newLink; // first --> newLink
        }
        //------------------------------------------------
        public T deleteFirst() // Удаление первого элемента
                               // (предполагается, что список не пуст)
        {
            Link<T> temp = first; // Сохранение ссылки
            first = first.next; // Удаление: first --> ссылка на второй элемент
            return temp.dData; // Метод возвращает данные удаленного элемента
        }
        //------------------------------------------------
        public void displayList()
        {
            Link<T> current = first; // От начала списка
            while (current != null) // Перемещение до конца списка
            {
                current.displayLink(); // Вывод данных
                current = current.next; // Переход к следующему элементу
            }
            Console.WriteLine("");
        }
        //------------------------------------------------
        public int Count_1() //  Количество элементов
        {
            int result = 0;
            Link<T> current = first;  // От начала списка
            while (current != null)  // Перемещение до конца списка
            {
                current = current.next;
                ++result;
            }
            return result;
        }
        //------------------------------------------------
        public void displayFirst()
        {
            Link<T> current = first;  // От начала списка
            current.displayLink(); // Вывод данных
            System.Console.WriteLine("");
        }
        //------------------------------------------------
        public T copyFirst() // Извлечение копии вершины стека
        {
            return (T) first.dData.Clone();
        }

        public void displaycopyFirst()
        {
            //Link<T> current = first;  // От начала списка
            //Link<T> current_1;
            //current_1 = ;
            //current.displayLink(); // Вывод данных
            System.Console.WriteLine(first.dData.Clone() + " ");
        }
    }
}
