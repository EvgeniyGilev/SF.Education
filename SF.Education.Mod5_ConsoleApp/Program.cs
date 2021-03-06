using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml;

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

            // задание 5.2.2

            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.ReadKey();


            static string ShowColor(string username, params string[] favcolors)
            {
                Console.WriteLine("{0}, напишите свой любимый цвет на английском с маленькой буквы", username);
                var color = Console.ReadLine();
                return color;
            }
            #endregion
            #region Задание 5.1.5


            

            string[] favcolors = new string[3];
            for (int j = 0; j < 3; j++)
            {
                favcolors[j] = ShowColor(anketa.name);
            }
            // параметризированный вывод цветов
            static void ShowColors(string username, params string[] favcolors)
            {
                Console.WriteLine("Ваши любимые цвета:");
                foreach (var color in favcolors)
                {
                    Console.WriteLine(color);
                }
            }
            ShowColors(anketa.name = "АБЫРВАЛГ", favcolors);



            Console.WriteLine("Цвета: ");
            foreach (var s in favcolors)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            #endregion

            #region Задание 5.1.6, 5.2.14 -5.2.17

            static int[] GetArrayFromConsole(int num = 5)
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }


            static int[] SortArray(int[] arrayForSort)
            {
                int[] SortedArray = arrayForSort;

                for (int j = 0; j < SortedArray.Length; j++)
                {
                    for (int i = j + 1; i < SortedArray.Length; i++)
                    {
                        if (SortedArray[i] < SortedArray[j])
                        {
                            var p = SortedArray[i];
                            SortedArray[i] = SortedArray[j];
                            SortedArray[j] = p;
                        }

                    }

                }

                return SortedArray;
            }
            //вызов ввода массива размерности 10
            int[] exampleArray = GetArrayFromConsole(10);
            // exampleArray = SortArray(exampleArray);

            static void ShowArray(int[] sArray, bool isSort = false)
            {
                if (isSort) sArray = SortArray(sArray);
                foreach (var el in sArray)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("");

            }

            Console.WriteLine("Вывод массива: ");
            //просто вывод массива
            ShowArray(exampleArray);
            //вывод отсортированного массива
            Console.WriteLine("Вывод отсортированного массива: ");
            ShowArray(exampleArray, true);




            Console.ReadKey();
            #endregion

            #region Задание 5.3.2-5.3.4

            var myAge = 34;
            static void ChangeAge(ref int age)
            {
                Console.WriteLine("Введите возраст: ");
                age = Convert.ToInt32(Console.ReadLine());

            }
            ChangeAge(ref myAge);
            Console.WriteLine(myAge);

            static void BigDataOperation(in int[] arr)
            {
                arr[0] = 4;
            }

            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);

            static void GetName(out string name, out string oldname)
            {
                oldname = "Евгения";
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();

            }

            string _name = "123";
            string _oldname = "345";
            GetName(out _name, out _oldname);
            Console.WriteLine(_name + "   " + _oldname);
            
            int t1 = 3;
            int t2 = 5;
            int SumNumbers(ref int num1, in int num2, out int num3,int num4)
            {
                num3 = num1 + num2;
                return  num3 * num4;
            }
            int res = SumNumbers(ref t1, t2, out int num3, 4);
            Console.WriteLine("Наш результат:" + res);

            

            exampleArray = GetArrayFromConsole(10);
            // exampleArray = SortArray(exampleArray);


            Console.WriteLine("Сортировки");

            static int[] SortArrayAsc(in int[] arrayForSort)
            {
                int[] SortedArray = arrayForSort;

                for (int j = 0; j < SortedArray.Length; j++)
                {
                    for (int i = j + 1; i < SortedArray.Length; i++)
                    {
                        if (SortedArray[i] < SortedArray[j])
                        {
                            var p = SortedArray[i];
                            SortedArray[i] = SortedArray[j];
                            SortedArray[j] = p;
                        }

                    }

                }

                return SortedArray;
            }
            static int[] SortArrayDesc(int[] arrayForSort)
            {
                int[] SortedArray = arrayForSort;

                for (int j = 0; j < SortedArray.Length; j++)
                {
                    for (int i = j + 1; i < SortedArray.Length; i++)
                    {
                        if (SortedArray[i] > SortedArray[j])
                        {
                            var p = SortedArray[i];
                            SortedArray[i] = SortedArray[j];
                            SortedArray[j] = p;
                        }

                    }

                }

                return SortedArray;
            }
            static void SortArray2(in int[] arrayForSort, out int[] sorteddesc, out int[] sortedasc)
            {
                int[] arr1 = new int[arrayForSort.Length];
                int[] arr2 = new int[arrayForSort.Length];
                arrayForSort.CopyTo(arr1,0);
                arrayForSort.CopyTo(arr2, 0);
                sorteddesc  = SortArrayDesc(arr1);

                sortedasc = SortArrayAsc(arr2);

            }
            static void ShowArray2(int[] sArray)
            {
                foreach (var el in sArray)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("");

            }


            Console.WriteLine("Выводим Массив отсортированный по возрастанию");
            SortArray2(exampleArray, out int[] sortd, out int[] srta );
            ShowArray2(srta);
            Console.WriteLine("Выводим Массив отсортированный по убыванию");

            ShowArray2(sortd);
            Console.ReadKey();

            #endregion
        }
    }
}
