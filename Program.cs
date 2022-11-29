#define HW4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if HW1
            /* Задание 1
            Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3(делится на 3 без
            остатка) нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 
            3 и 5 нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
            Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке*/

            Console.WriteLine("Введите число от 1 до 100");
            short a = short.Parse(Console.ReadLine());
            while (!(a >= 0 && a <= 100))
            {
                Console.WriteLine("Вы ошиблись, введите число от 1 до 100");
                a = short.Parse(Console.ReadLine());
            }
            if (a % 3 == 0) Console.WriteLine("Fizz");
            if (a % 5 == 0) Console.WriteLine("Buzz");
            if (a % 3 != 0 && a % 5 != 0) Console.WriteLine(a);

#endif

#if HW2
            /*Задание 2
            Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который
            необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10.Требуется вывести на экран 10 процентов
            от 90. Результат: 9. */

            Console.WriteLine("Введите число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент, который необходимо посчитать");
            int c = int.Parse(Console.ReadLine());
            int result = b * c / 100;
            Console.WriteLine(result);

#endif

#if HW3
            /*Задание 3
            Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры.
            Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.*/

            Console.WriteLine("Введите 1 число");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 4 число");
            int num4 = int.Parse(Console.ReadLine());
            int result2 = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            Console.WriteLine(result2);
            Console.ReadLine(); //прописала, чтобы консоль не закрывалась          
#endif

#if HW4

            /*Задание 4
            Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр. 
            Например, если пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую 
            цифры. Число 723895 должно превратиться в 523897. Если пользователь ввел не шестизначное число 
            требуется вывести сообщение об ошибке */

            Console.WriteLine("Введите шестизначное число");
            int q = int.Parse(Console.ReadLine());
            if (q <= 99999 || q > 999999 )
            {
                Console.WriteLine("Вы ввели не 6 значное число, попробуйте ещё");
            }
            else
            {
                Console.WriteLine("Введите итдекс первого числа, для обмена: ");
                int indexI = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите индекс второго числа для обмена: ");
                int indexJ = int.Parse(Console.ReadLine());
                int start = indexI;
                int end = indexJ;
                if (indexI > indexJ)
                {
                    start = indexJ;
                    end = indexI;
                }
                else
                {
                    for (int i = 0; i <= indexI; i++)
                    {
                        for (int j = 7; j => indexJ; j--)
                        {                            
                            q %= 10;
                            q /= 10;
                            int temp = i;               //подзапутолась с задачей не смогла решить
                            i = j;
                            j = temp;
                            q *= 10;             
                        }
                    }
                }
            }
            Console.ReadLine(); //все время закрывается консоль
#endif

#if HW5

            /*Задание 5
            Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
            Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.*/

            DateTime someDate = new DateTime();
            Console.WriteLine("Введите дату в формате дд.мм.гггг");
            someDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(someDate.DayOfWeek);
            Console.ReadLine(); //закрывается консоль
            // не знаю как вывести сезон
#endif

#if HW6

            /*Задание 6
            Пользователь вводит с клавиатуры показания температуры.В зависимости от выбора пользователя программа
            переводит температуру из Фаренгейта в Цельсий или наоборот.*/

            Console.WriteLine("Введите температуру");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите 1 для перевода температуры в цельсий, 2 для перевода в фаренгейт");
            double res =double.Parse(Console.ReadLine());
            switch(res)
            {
                case 1: res = (temp - 32) / 1.8;
                   Console.WriteLine(res); 
                    break;
                case 2: res = temp*1.8 + 32;
                    Console.WriteLine(res); 
                    break;
            }
            Console.ReadLine(); //что бы не закрывалась консоль
#endif

#if HW7

            /*Задание 7
            Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне. Если 
            границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
            ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.*/


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int start = a;
            int end = b;
            if (a > b)
            {
                start = b;
                end = a;
            }
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i}, ");
            }      
            Console.ReadLine();// не знаю постоянно закрывается консоль
#endif
        }
    }
}
