using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)


            /*
            int x = 1;
            while (x <= 10) {
                Console.WriteLine(x);
                x++;
            }
            */

            /*
             
            
            int x = 1;
            do

            {
                Console.WriteLine(x);

                x++;
            }
            while (x <= 10);
            */

            /*
            for (int x = 1; x <= 10; x++)
                Console.Write(x);

            Console.ReadLine();
            */


            //Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
            /*
            Console.Write("Введите число, до которого от 1 будет идти отсчет: ");
            int numb = int.Parse(Console.ReadLine());
            for (int n = 1; n <= numb; n++)
            {
                Console.WriteLine(n);
            }
            */


            //Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
            /*
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("Привет!");
                x++;
            }
            */


            //Задание 4.С использованием цветового оформления консоли
            //а) вывести на экран горизонтальную строку из 18 символов;
            //б) вывести на экран вертикальную строку из 25 символов.

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Введите символ: ");
            string x = Console.ReadLine();
            for (int i = 0; i < 18; i++)
            {
                Console.Write(x);
            }
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(x);
            }

        }
    }
}
