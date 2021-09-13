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

            ///
            /// Следующий пример, с перменными разных типов
            /// 
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();

        }
    }
}
