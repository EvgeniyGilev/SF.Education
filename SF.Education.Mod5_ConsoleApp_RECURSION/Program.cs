using System;

namespace SF.Education.Mod5_ConsoleApp_RECURSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу для проверки работы эхо:");
            string phrase = Console.ReadLine();
            Console.WriteLine("Введите глубину эхо:");
            int deep = Int32.Parse(Console.ReadLine());

            Echo(phrase, deep);

            static void Echo(string saidworld, int deep)
            {
                var modif = saidworld;

                if (modif.Length > 2)
                {
                    modif = modif.Remove(0, 2);
                }


                    Console.BackgroundColor = (ConsoleColor) deep;
                    Console.WriteLine("..." + modif);

                if (deep > 1)
                {
                    Echo(modif, deep - 1);
                }

            }
        }
    }
}
