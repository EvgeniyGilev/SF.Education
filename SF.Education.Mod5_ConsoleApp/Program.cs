using System;
using System.Drawing;

namespace SF.Education.Mod5_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Повторенеи из модуля 4

            

            
            (string Name, string[] diches) User;
            Console.WriteLine("Введите Имя клиента: ");
            User.Name = Console.ReadLine();
            User.diches = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите любимое блюдо №" + (i + 1) + ": ");
                User.diches[i] = Console.ReadLine();
            }

            Console.ReadKey();

            static string ShowColor()
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                var color = Console.ReadLine();
                return color;
            }
            #endregion
            #region Задание 5.1.5




            string[] favcolors = new string[3];
            for (int j = 0; j < 3; j++)
            {
                favcolors[j] = ShowColor();
            }

            Console.WriteLine("Цвета: ");
            foreach (var s in favcolors)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            #endregion

            #region Задание 5.1.6 

            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }
            #endregion


        }
    }
}
