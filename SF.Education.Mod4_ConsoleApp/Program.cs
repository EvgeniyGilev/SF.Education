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
            Console.ReadKey();

        }
    }

    
}
