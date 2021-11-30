using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стек int:");

            LinkStack<string> theintStack = new LinkStack<string>(); // Создание стека

            theintStack.push("20"); // Вставка элементов
            theintStack.push("40");

            theintStack.displayStack(); // Вывод содержимого стека

            theintStack.push("60"); // Вставка элементов
            theintStack.push("80");
             
            theintStack.displayStack(); // Вывод содержимого стека
            theintStack.Top(); // Возвращение значения из вершины стека
            theintStack.Count();

            theintStack.pop(); // Извлечение элементов
            theintStack.pop();

            theintStack.displayStack(); // Вывод содержимого стека

            //------------------------------
            Console.WriteLine(" ");
            Console.WriteLine("Стек string:");
            LinkStack<string> stringStack = new LinkStack<string>(); // Создание стека

            stringStack.push("Кошка"); // Вставка элементов
            stringStack.push("Собака");

            stringStack.displayStack(); // Вывод содержимого стека

            stringStack.push("Лошадь"); // Вставка элементов
            stringStack.push("Слон");

            stringStack.displayStack(); // Вывод содержимого стека
            stringStack.Top(); // Возвращение значения из вершины стека
            stringStack.Count();

            stringStack.pop(); // Извлечение элементов
            stringStack.pop();

            stringStack.displayStack(); // Вывод содержимого стека

            //---------------------------------
            Console.WriteLine(" ");
            Console.WriteLine("Стек complex:");
            LinkStack<string> complexStack = new LinkStack<string>(); // Создание стека
            Complex complex1 = new Complex(12, 1);
            Complex complex2 = new Complex(2, 13);
            complexStack.push(Convert.ToString(complex1)); // Вставка элементов
            complexStack.push(Convert.ToString(complex2));

            complexStack.displayStack(); // Вывод содержимого стека

            Complex complex3 = new Complex(12, 1);
            Complex complex4 = new Complex(2, 13);
            complexStack.push(Convert.ToString(complex3)); // Вставка элементов
            complexStack.push(Convert.ToString(complex4));

            complexStack.displayStack(); // Вывод содержимого стека
            complexStack.Top(); // Возвращение значения из вершины стека
            complexStack.Count();

            complexStack.pop(); // Извлечение элементов
            complexStack.pop();

            complexStack.displayStack(); // Вывод содержимого стека
            //---------------------------------
            Console.WriteLine(" ");
            Console.WriteLine("АвтоСтек: ");

            LinkStack<string> thelongStack = new LinkStack<string>();

            thelongStack = LinkStack<string>.pushStack();
            thelongStack.displayStack();
            thelongStack.Count();

            Console.ReadLine();
        }
    }
}
