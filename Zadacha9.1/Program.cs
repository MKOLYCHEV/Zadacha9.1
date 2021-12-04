using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, ans;
            int num = 0;
            bool f = true;
            bool t = false;
            Console.Write("Введите первое число: ");
            try //Проверка формата первого вводимого числа
            {
                a = Convert.ToDouble(Console.ReadLine());
                f = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            if (!f)
            {
                Console.Write("Введите второе число: ");
                try //Проверка формата второго вводимого числа
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    t = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                }
            }
            if (t)
            {
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("   1 - сложение");
                Console.WriteLine("   2 - вычитание");
                Console.WriteLine("   3 - произведение");
                Console.WriteLine("   4 - частное");
                Console.Write("Ваш выбор: ");
                try //Проверка вводимого кода операции
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    f = true; //Для вывода/невывода сообщения об отсутвии опции с заданным номером
                }
                try
                {
                    if (num == 1)
                    {
                        ans = a + b;
                        Console.WriteLine("Сумма введенных чисел равна {0:N}.", ans);
                    }
                    else if (num == 2)
                    {
                        ans = a - b;
                        Console.WriteLine("Разность введенных чисел равна {0:N}.", ans);
                    }
                    else if (num == 3)
                    {
                        ans = a * b;
                        Console.WriteLine("Произведение введенных чисел равно {0:N}.", ans);
                    }
                    else if (num == 4)
                    {
                        if (b == 0)
                            Console.WriteLine("Ошибка! Деление на ноль.");
                        else
                        {
                            ans = a / b;
                            Console.WriteLine("Частное введенных чисел равно {0:N}.", ans);
                        }
                    }
                    else
                    {
                        if (!f)  //Проверяет выводилось ли сообщение об ошибке ввода номера опции
                            Console.WriteLine("Нет опций с указанным номером.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
