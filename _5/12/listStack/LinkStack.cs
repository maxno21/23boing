using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkStack
{
    public class LinkStack<T> //: ICloneable
    where T:ICloneable
    {
        private LinkList<T> theList;
        //public LinkList<T> theList1;
        //----------------------------
        public LinkStack() // Конструктор
        {
            theList = new LinkList<T>();
        }
        //----------------------------
        public void push(T j) // Размещение элемента на вершине стека
        {
            theList.insertFirst(j);
        }
        //----------------------------
        public T pop() // Извлечение элемента с вершины стека и удаление его
        {
            System.Console.Write("First-->remove): ");
            theList.displayFirst();
            return theList.deleteFirst();
        }
        //----------------------------
        public Boolean isEmpty() // true, если стек пуст
        {
            return (theList.isEmpty());
        }
        //----------------------------
        public void displayStack()
        {
            Console.Write("Stack (top-->bottom): ");
            theList.displayList();
        }
        //----------------------------
        public void Count()  //  Количество элементов в стеке
        {
            System.Console.WriteLine("Count " + theList.Count_1());
        }
        //----------------------------
        public void Top() // Получение числа из вершины стека
        {
            System.Console.Write("First-->): ");

            theList.displaycopyFirst();
        }

        //--------------------------------------
        public static LinkStack<string> pushStack() // Создание и заполнение стека значениями по умолчанию
        {
            LinkStack<string> theList1 = new LinkStack<string>();
            theList1.push("a");  // Вставка элементов
            theList1.push("b");
            theList1.push("c");
            theList1.push("d");
            return theList1;
        }
    }
}
