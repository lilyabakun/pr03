using System;

namespace _03
{
    /// <summary>
    /// Класс Complex для работы с комплексными числами.
    /// </summary>
    class Complex : ICloneable
    {
        public double r;
        public double i;
        public Complex()
        {
            r = 0.0;
            i = 0.0;
        }
        public Complex(double real, double inag)
        {
            this.r = real;
            this.i = inag;
        }
        /// <summary>
        /// Метод ToString override
        /// </summary>
        /// <returns> Возвращает строку </returns>
        public override string ToString()
        {
            return String.Format("Действительная часть {0}, мнимая {1}i", r, i);
        }

        public object Clone()
        {
            return new Complex { r = this.r, i = this.i };
        }
        public double Re()
        {
            return this.r;
        }
        public double Im()
        {
            return this.i;
        }
        /// <summary>
        /// Сумма 2 комплексных чисел
        /// </summary>
        /// <param name="a">Первое комплексное число</param>
        /// <param name="b">Второе комплексное число</param>
        /// <returns></returns>
        public Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.i;
            res.i = a.i + b.i;
            return res;
        }
        /// <summary>
        /// Произведение комплексных чисео
        /// </summary>
        /// <param name="a"> №1 тип Comlex</param>
        /// <param name="b">№2 тип Comlex</param>
        /// <returns></returns>
        public Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }
        /// <summary>
        /// вычитание комплексных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }
        /// <summary>
        /// Перегрезка оператора +
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator +(Complex a, Complex b)
        {
            Complex complex = new Complex();
            return complex.Sum(a, b);
        }
        /// <summary>
        /// Перегразка оператора -
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator -(Complex a, Complex b)
        {
            Complex complex = new Complex();
            return complex.Subtract(a, b);
        }
        /// <summary>
        /// Перегразка оператора *
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator *(Complex a, Complex b)
        {
            Complex complex = new Complex();
            return complex.Multiplication(a, b);
        }
        public void PrintLine(Complex a)
        {
            Console.WriteLine(a);
        }

    }
}
