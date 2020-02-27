using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApplication obj = new MyApplication();
            obj.Menu();
            Console.WriteLine("Клонирование");
            Complex objst = new Complex { r = 5, i = 9 };
            Complex objst1 = (Complex)objst.Clone();
            objst1.i = 4;
            Console.WriteLine($"Клон объекта 1 {objst1.ToString()}");
            Console.WriteLine($"Объект 1 {objst.ToString()}");
            Console.WriteLine("\nДля выхода из программы нажмите [Enter]");
            Console.ReadLine();
        }
    }
}
