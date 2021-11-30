using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Program Started");
            // Создание комплексных чисел
            Complex c1 = new Complex(5, -2);

            Console.WriteLine("Создали комплексное число c1 = {0} ", c1); // Здесь у с1 вызовется переопределенный метод ToString()
            
            Console.WriteLine("Пример работы свойств");
            Console.WriteLine("c1.Module = " + c1.Module);
            Console.WriteLine("c1.Argument = " + c1.Argument);
            Console.WriteLine("Задание свойств Re = 12, Im = 13");
            c1.Re = 11;
            c1.Im = 13;
            
            Console.WriteLine("c1 = {0}", c1);
            Console.WriteLine("Чтение свойств");
            Console.WriteLine("Re = {0}, Im = {1}", c1.Re, c1.Im);

            Console.WriteLine("Задание свойств r = 1, Arg = 0.5");

            Complex c5 = Complex.ComplexrA(1, 0.5);
            
            Console.WriteLine("Комплексное число созданное по модулю и аргументу с5 = {0}", c5);
            Console.WriteLine("Проверка");
            Console.WriteLine("c5.Module = " + c5.Module);
            Console.WriteLine("c5.Argument = " + c5.Argument);


            Complex c2 = new Complex(2, -5);
            Console.WriteLine("Создали комплексное число c2 = {0}", c2);

            Complex c3 = c1 + c2;
            Console.WriteLine("Сложили комплексные числа c1 + c2  {0} + {1} = {2}", c1, c2, c3); 


            // Операции сравнения
            Console.WriteLine("Сравнение комплексных чисел c1 и с2");
            Console.WriteLine("{0} = {1} ? {2}", c1, c2, c1 == c2);
            Console.WriteLine("{0} = null ? {1}", c1, c1 == null);
            Console.WriteLine("Одинаковые копмлексные числа равны (комплексные числа, не объекты) ? {0}", new Complex(5, 7) == new Complex(5, 7));

            // Преобразование типов
            Complex c4 = 7; // Используется реализованное НЕЯВНОЕ приведение типов (impicit)
            Console.WriteLine("Создали комплексное число с4 = {0}", c4);
            double f = (double)c1; // Используется реализованное ЯВНОЕ приведение типов (explicit)
            Console.WriteLine("Преобразовали комплексное число с1{0} в число = {1}", c1, f);



            Console.WriteLine("Нажмите Enter для выхода");

            

            Console.ReadLine();
        }

    }
}
