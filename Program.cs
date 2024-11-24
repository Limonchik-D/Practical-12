using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__12
{
    internal class Program
    {
        //Задача 1
        /* static double denominator(int x)                           
         {
             return Math.Sqrt(x) + x / 2;
         }

         static void Main(string[] args)
         {
             double result = denominator(5) + denominator(12) + denominator(19);
             Console.WriteLine($"x = {result}");
             Console.ReadLine();
         }*/



        //Задача 2
        /*static double numerator(double y) 
        {
            return Math.Sqrt(y) + y;

        }

        static double denominator(double x)
        {
            return Math.Sqrt(x) + x;
        }

        static void Main(string[] args)
        {
            // Вычисляем числитель
            double result = numerator(5) + numerator(12) + numerator(19); 

            // Вычисляем знаменатель
            double result1 = denominator(7) + denominator(8) + denominator(2);

            Console.WriteLine($"x = {result / result1}");
            Console.ReadLine();
        }*/



        //Задача 3: Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.

        /*static int variable()
        {
            Console.Write("Введите первое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;

        }

        static int secondVariable()
        {
            Console.Write("Введите второе число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            return number1;
        }

        static void Main(string[] args)
        {
            int number = variable();
            int number1 = secondVariable();

            string result = (number > number1)
                ? $"Максимальное значение {number}"

                : (number1 > number)
                ? $"Максимальное значение {number1}"

                : $"Значения {number} и {number1} равны";


            Console.WriteLine(result);
            Console.ReadLine();*/

        /*if (number > number1)
        {
            Console.WriteLine($"Максимально значение: {number}");
        }
        else if (number1 > number)
        {
            Console.WriteLine($"Максимально значение: {number1}");
        }
        else if (number1 == number) 
        {
            Console.WriteLine($"Значения {number1} и {number} равны"); 
        }
        Console.ReadLine();
    }*/



        //Задача 4. Найти максимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов. 

        /*static int variable()
        {
            Console.Write("Введите первое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;

        }

        static int secondVariable()
        {
            Console.Write("Введите второе число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            return number1;
        }

        static int thirdVariable()
        {
            Console.Write("Введите третье число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            return number2;

        }

        static void Main(string[] args)
        {
            int number = variable();
            int number1 = secondVariable();
            int number2 = thirdVariable();

            string result = (number > number1 && number > number2)
                ? $"Максимальное значение: {number}"

                : (number1 > number && number1 > number2)
                ? $"Максимальное значение: {number1}"

                : (number2 > number && number2 > number1)
                ? $"Максимальное значение: {number2}"

                : (number2 == number && number == number1)
                ? $"Значения: {number}, {number1} и {number2} равны"

                : "Ошибка. Неожиданное сравнение";


            Console.WriteLine(result);
            Console.ReadLine();

        }*/



        //Задача 5. Найти s=max(a, b) + max(c, d), используя вспомогательную функцию (метод).


        /*static int Max(int x, int y)
        {
            return (x > y) 
                ? x //x больше
                : y; // иначе y больше
        }

        static void Main(string[] args) 
        {
            Console.Write("Введите первое число (а): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число (c): ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите четвёртое число (d): ");
            int d = Convert.ToInt32(Console.ReadLine());
            int Max1 = Max(a, b);
            int Max2 = Max(c, d);
            int s = Max(a,b) + Max(c,d);

            //Console.WriteLine($"Максимальное значение из (a и b) = {Max1}"); 
            //Console.WriteLine($"Максимальное значение из (c и d) = {Max2}");
            //Console.WriteLine($"s = {Max1} + {Max2}");
            Console.WriteLine($"Результат: s = {s}");

            Console.ReadLine();

        }*/


        //Задача 6. Вывести дни недели в зависимости от номера дня с использованием вспомогательного метода.


        /*static void days(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;

                case 2:
                    Console.WriteLine("Вторник");
                    break;

                case 3:
                    Console.WriteLine("Среда");
                    break;

                case 4:
                    Console.WriteLine("Четверг");
                    break;

                case 5:
                    Console.WriteLine("Пятница");
                    break;

                case 6:
                    Console.WriteLine("Суббота");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье");
                    break;

                    default:
                    Console.WriteLine("Не верный номер дня");
                    break;

            }

            
        }

        static void Main(string[] args) 
        {
            Console.Write("Введите день недели (1-7): ");
            int result = Convert.ToInt32(Console.ReadLine());

            days(result); //Вызов метода

            Console.ReadLine();

        }*/
    }
}
