using System;

namespace SF_ConsoleAppMod3
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 27 лет");
            Console.WriteLine("\tMy name is\n Jane");
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            Console.ReadKey();
        }
    }
}
