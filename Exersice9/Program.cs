using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора.
            //Программа должна запрашивать 2 числа, а затем – код операции
            //(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
            //После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.

            double a = 0;
            double b = 0;
            try
            {
                Console.Write("Введите число A = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B = ");
                b = Convert.ToInt32(Console.ReadLine());
                double S = 0;
                Console.WriteLine("Введите код операции");
                Console.WriteLine("      1 - сложение");
                Console.WriteLine("      2 - вычитание");
                Console.WriteLine("      3 - произведение");
                Console.WriteLine("      4 - частное");
                Console.Write("Ваш выбор: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            S = a + b;
                            break;
                        }
                    case 2:
                        {
                            S = a - b;
                            break;
                        }
                    case 3:
                        {
                            S = a * b;
                            break;
                        }
                    case 4:
                        {
                            S = a / b;
                            break;
                        }

                }
                if (b == 0 && n == 4)
                {
                    Console.WriteLine("Деление на 0!");
                }
                else if (n < 1 || n > 4)
                {
                    Console.WriteLine("Ошибка! Нет операции с указанным номером");
                }
                else
                {
                    Console.WriteLine("Результат = {0}", S);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}