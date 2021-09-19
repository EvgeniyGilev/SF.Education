using System;
using System.ComponentModel;

namespace SF.Education.Mod4_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Пример 1
            /*
            var a = "abc";
            var b = "def";
            bool c;
            c = a != b;
            int A;
            int B;
            double X;
            double Y;

            bool C = (A < B) | (X > Y);
          
            var a = 6;
            var b = 7;
            
            var c = (a < b) ^ (a != b);

            Console.WriteLine(c);
            Console.ReadKey();
              */
            //Пример 2 - 4.1. Условные выражения и конструкции - задание на цвета
            /* Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

             switch (Console.ReadLine())
             {
                 case "red":
                     Console.BackgroundColor = ConsoleColor.Red;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Your color is red!");
                     break;

                 case "green":
                     Console.BackgroundColor = ConsoleColor.Green;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Your color is green!");
                     break;
                 case "cyan":
                     Console.BackgroundColor = ConsoleColor.Cyan;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Your color is cyan!");
                     break;

                 default:
                     Console.BackgroundColor = ConsoleColor.Yellow;
                     Console.ForegroundColor = ConsoleColor.Red;

                     Console.WriteLine("Your color is yellow!");
                     break;
             }
             Console.ReadKey();
            */
            //Пример - 4.2. Циклы
            /*
            Console.WriteLine("Цикл while");
            int k = 0;
            
            while (k < 1)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                k++;
            }

            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 1);
            */
            int K = 0;
            string[] favcolors = new string[3];
            int t = favcolors.Length;

            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы(stop, чтобы пропустить этот шаг");
                Console.WriteLine(K);

                var text = Console.ReadLine();


                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        /* Console.BackgroundColor = ConsoleColor.Yellow;
                         Console.ForegroundColor = ConsoleColor.Red;

                         Console.WriteLine("Your color is yellow!");*/
                        continue;
            
                }

                K++;

            }

            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            //переставляем буквы в имени
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            Console.ReadKey();
            Console.WriteLine("Исходный массив для сортировки: ");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("отсортрованный от меньшего к большему: ");
            //Пузырьком
            var minArr = new int[arr.Length];
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i =0; i < arr.Length -1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var p = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = p;
                    }

                }

            }
            Console.WriteLine();
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.ReadKey();

        }




    }



}
