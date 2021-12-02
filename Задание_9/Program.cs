using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        //Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
        //После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
        static void Main(string[] args)
        {
            //a - первое число, b - второе число, n - результат вычисления, с - код операции
            Console.WriteLine("Вас приветствует калькулятор!\nВведите последовательно два числа.");
            double n;
            try
            {
                Console.Write("Первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции, которую вы хотите совершить:\n   1 - сложение\n   2 - вычитание\n   3 - произведение\n   4 - деление");
                Console.Write("Ваш выбор: ");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            n = a + b;
                            Console.WriteLine("Результат вычисления равен: {0}", n);
                            break;
                        }
                    case 2:
                        {
                            n = a - b;
                            Console.WriteLine("Результат вычисления равен: {0}", n);
                            break;
                        }
                    case 3:
                        {
                            n = a * b;
                            Console.WriteLine("Результат вычисления равен: {0}", n);
                            break;
                        }
                    case 4:
                        {
                            n = a / b;
                            if (Double.IsInfinity(n) || double.IsNaN(n))
                            {
                                Console.WriteLine("Ошибка! Деление на 0.");
                            }
                            else
                            {
                                Console.WriteLine("Результат вычисления равен: {0:f2}", n);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введенный код операции находится вне диапазона представленных на выбор чисел.");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
