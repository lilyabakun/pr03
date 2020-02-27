using System;

namespace _03
{
    public class MyApplication
    {
        public void Menu()
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            try
            {
                Console.Write("Введите целую часть первого комплексного числа: ");
                c1.r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите мнимую часть первого комплексного числа: ");
                c1.i = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целую часть второго комплексного числа: ");
                c2.r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите мнимую часть первого комплексного числа: ");
                c2.i = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение" + e.Message);
            }
            Console.Clear();
            Console.WriteLine("Введенные комплексные числа: ");
            //Перегрузка метода ToString
            Console.WriteLine($"{c1.ToString()}");
            Console.WriteLine($"{c2.ToString()}");
            int i1;
            do
            {
                Console.Write("Меню:\n1)Сложить\n2)Вычетать\n3)Умножить\n4)Выход\nЦифра:");
                i1 = Convert.ToInt32(Console.ReadLine());
                switch (i1)
                {
                    case 1:
                        {
                            Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", (c1 + c2).r, (c1 + c2).i);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", (c1 - c2).r, (c1 - c2).i);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", (c1 * c2).r, (c1 * c2).i);
                        }
                        break;
                }
            } while (i1 != 4);
        }
    }
}
