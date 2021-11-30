using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complex
    {
        // Переменые
        private double _Re, _Im;
        private double _r, _Arg;
        
        public Complex(double Re = 0, double Im = 0) // конструктор, задает вещественную и мнимую часть компл. числа
        {
            _Re = Re;
            _Im = Im;
        }


        public double Re // Свойство получения вещественной части компл. числа
        {
            get { return _Re; }
            set
            {
                _Re = value;
                Console.WriteLine("Re set");
            }
        }

        public double Im // Свойство получения мнимой части компл. числа
        {
            get { return _Im; }
            set
            {
                _Im = value;
                Console.WriteLine("Im set");
            }
        }

        public double r // Свойство получения модуля комплексного числа
        {
            get { return _r; }
            set
            {
                _r = value;
                Console.WriteLine("r set");
            }
        }

        public double Arg // Свойство получения аргумента компл. числа
        {
            get { return _Arg; }
            set
            {
                _Arg = value;
                Console.WriteLine("Arg set");
            }
        }

        public static Complex ComplexrA (double r, double Arg)
        {
            return new Complex(r*Math.Cos(Arg), r*Math.Sin(Arg));
        }
        public double Module // Модуль комп. числа. Вычислимое свойство
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im); // Math - пространство имен с математическими функциями. Sqrt - кв.корень
            }
        }

        public double Argument  // Аргумент комплексного числа. Вычислимое свойство
        {
            get
            {
                return Math.Acos(_Re / Math.Sqrt(_Re * _Re + _Im * _Im)); // Math - пространство имен с математическими функциями. Sqrt - кв.корень
            }
        }

        // Перегрузка +
        public static Complex operator +(Complex a, Complex b) // переопределяет также +=
        {
            if (a is null || b is null) return null; // C# 7
            return new Complex(a._Re + b._Re, a._Im + b._Im);
        }
        // Перегрузка -
        public static Complex operator -(Complex a, Complex b) // переопределяет также -=
        {
            if (a is null || b is null) return null; // C# 7
            return new Complex(a._Re - b._Re, a._Im - b._Im);
        }
        // Перегрузка *
        public static Complex operator *(Complex a, Complex b) // переопределяет также -=
        {
            if (a is null || b is null) return null; // C# 7
            return new Complex(a._Re * b.Re - a._Im * b._Im, a._Re * b._Im + a._Im * b._Re);
        }
        // Перегрузка /
        public static Complex operator /(Complex a, Complex b) // переопределяет также -=
        {
            if (a is null || b is null) return null; // C# 7
            return new Complex((a._Re * b.Re + a._Im * b._Im) / (a._Re * a._Re + b._Im * b._Im), (a._Im * b._Re - a._Re * b._Im) / (a._Re * a._Re + b._Im * b._Im));
        }
        // Переопределение операций сравнения
        public static bool operator ==(Complex a, Complex b)
        {
            if (ReferenceEquals(a, null)) // не == null, а именно object.ReferenceEquals(a, null)
            {
                return ReferenceEquals(b, null);
            }
            return a.Equals(b);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return _Im.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex complex) // если obj - null, то тоже вернет false // C# 7
            {
                return _Re == complex._Re && _Im == complex._Im;
            }

            return false;

        }
        // Задание ЯВНОГО преобразования типа Complex в число double. Модуль числа
        public static explicit operator double(Complex v)
        {
            if (v is null) return double.NaN; // C# 7
            return v.Module;
        }
        // Задание НЕЯВНОГО преобразования числа типа int в Complex. Получение Re
        public static implicit operator Complex(int re)
        {
            return new Complex(re, 0);
        }
        // Переопределение метода базового типа System.Object. Строковое представление числа
        //public override string ToString()
        //{
        //    return string.Format(" {0} + {1}i ", _Re, _Im);
        //}
        public override string ToString()
        {
            string complex = ""; // результат в строковую переменную
            if (Re == 0 & Im == 0)
            {
                complex = string.Format(" 0 ", _Re, _Im);
            }
            else if (Re < 0 & Im < 0)
            {
                //Im = -Im;
                complex = string.Format(" {0}{1}i ", _Re, _Im);
            }
            else if (Re > 0 & Im > 0)
            {
                complex = string.Format(" {0}+{1}i ", _Re, _Im);
            }
            else if (Re == 0 & Im != 0)
            {
                complex = string.Format(" {1}i ", _Re, _Im);
            }
            else if (Re != 0 & Im == 0)
            {
                complex = string.Format(" {0}  ", _Re, _Im);
            }
            else if (Re>0 & Im<0)
            {
                complex = string.Format(" {0}{1}i ", _Re, _Im);
            }
            else if (Re < 0 & Im > 0)
            {
                complex = string.Format(" {0}+{1}i ", _Re, _Im);
            }

            return complex;
        }


    }
}

