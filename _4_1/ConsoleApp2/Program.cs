using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkQueue theQueue = new LinkQueue();
            Complex complex1 = new Complex(20, 30);
            Complex complex2 = new Complex(40, 50);
            theQueue.Enqueue(complex1);  // Вставка элементов
            theQueue.Enqueue(complex2);

            theQueue.Print();  // Вывод содержимого очереди
            theQueue.Count(); // Количество элементов в очереди
            theQueue.Dequeue(); // Получает число из начала очереди и удаляет его
            theQueue.Peek();

            Complex complex3 = new Complex(60, 70);
            Complex complex4 = new Complex(80, 90);
            theQueue.Enqueue(complex3);  // Вставка элементов
            theQueue.Enqueue(complex4);

            theQueue.Print();  // Вывод содержимого очереди
            theQueue.Count(); // Количество элементов в очереди

            theQueue.remove();  // Удаление элементов
            theQueue.remove();

            theQueue.Print();  // Вывод содержимого очереди
            theQueue.Count(); // Количество элементов в очереди

            System.Console.ReadLine();
        }
    }
}
