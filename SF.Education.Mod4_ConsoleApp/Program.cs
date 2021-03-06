using System;
using System.ComponentModel;
using System.Reflection.Metadata;

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
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы(stop, чтобы пропустить этот шаг)");
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
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4,-5 };
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("отсортрованный от меньшего к большему: ");
            //Сортировка Пузырьком 4.3.12
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[j])
                    {
                        var p = arr[i];
                        arr[i] = arr[j];
                        arr[j] = p;
                    }

                }

            }
            Console.WriteLine();
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.ReadKey();
            //Сумма элементов массива
            Console.WriteLine("Ищем сумму элементов массива: ");
            var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var sumarr2 = 0;
            foreach (var el in arr2)
            {
                Console.Write(el + " ");
                sumarr2 = sumarr2 + el;
            }
            Console.WriteLine();
            Console.WriteLine(sumarr2);

            //Пример зубчатый массив, перебор
            Console.WriteLine("Пример зубчатый массив, перебор: ");
            Console.ReadKey();
            int[][] array2 = new int[3][];
            array2[0] = new int[2] { 1, 2 };
            array2[1] = new int[3] { 1, 2, 3 };
            array2[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array2)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            //Пример подсчета положительных элементов в массиве Задание 4.3.15
            Console.WriteLine("Подсчет положительных элементов в массиве");
            int[,] array3 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int cc = 0;
            foreach (var el in array3)
            {
                Console.Write(el + " ");
                if (el > 0)
                    cc++;
            }
            Console.WriteLine();
            Console.WriteLine(cc);
            Console.ReadKey();

            //Пример подсчета положительных элементов в массиве Задание 4.3.15
            Console.WriteLine("на этом же массиве сортировка пузырьком по каждой строке ");
            for (int r = 0; r <= array3.GetUpperBound(0); r++)
            {

                for (int j = 0; j <= array3.GetUpperBound(1); j++)
                {
                    for (int i = j + 1; i <= array3.GetUpperBound(1); i++)
                    {
                        if (array3[r,i] < array3[r,j])
                        {
                            var p = array3[r,i];
                            array3[r,i] = array3[r,j];
                            array3[r,j] = p;
                        }

                    }

                }
            }

            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

            //пример с кортежем
            //(string name, int age) anketa;

            var (name1, age1) = ("Евгений", 34);

            Console.WriteLine("Ваше имя: {0}", name1);
            Console.WriteLine("Ваш возраст: {0}", age1);

            Console.Write("Введите имя: ");
            name1 = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name1);
            Console.WriteLine("Ваш возраст: {0}", age1);

            Console.ReadKey();

            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возраст питомца");
            Pet.Age = double.Parse(Console.ReadLine());
            
            Console.ReadKey();

            //Анкетирование


            Console.WriteLine("Задание на анкетирование:");
            //задание 4.5.6
            for (int i = 0; i < 3; i++)
            {

                //задание 4.5.1
                //(string nameUser, string lastNameUser, string loginUser, int lenghtloginUser, bool isPetExists, int ageUser, string[] favColors) User;
                //задание 4.5.2
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double
                    Age) User;

                Console.WriteLine("Введите имя");

                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                //задание 4.5.3
                User.LoginLength = User.Login.Length;
                Console.WriteLine("длина вашего логина: " + User.LoginLength);

                //задание 4.5.4
                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                User.HasPet = Console.ReadLine() == "да";

                //задание 4.5.5
                Console.WriteLine("Введите возраст пользователя:");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                Console.WriteLine("Цвет 1: ");
                User.favcolors[0] = Console.ReadLine();
                Console.WriteLine("Цвет 2: ");
                User.favcolors[1] = Console.ReadLine();
                Console.WriteLine("Цвет 3: ");
                User.favcolors[2] = Console.ReadLine();
            }
        }


    }




    }




