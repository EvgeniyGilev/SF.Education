using System;

namespace SF_ConsoleAppMod3
{
    class Program
    {
        /// <summary>
        /// Перечисление для задания 3.4.3
        /// </summary>
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }



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


            // Следующий пример, с перменными разных типов

            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();

            //byte age =18;
            //Console.WriteLine($"Мой возраст {age}");

            //Console.ReadKey();

            // код для вывода трех переменых последовательно

            string name = "Jane";
            byte age = 27;
            ConsoleColor favcolor = ConsoleColor.Black;
            Console.WriteLine("{0} \n {1} \n {2}", name, age, favcolor);

            string str = Console.ReadLine();

            // добавим пример с tryParse

            Console.Write("Enter your age: ");
            int myAge;
            bool iscorrect = int.TryParse(Console.ReadLine(), out myAge);
            Console.WriteLine(iscorrect ? "Your age is " + myAge : "Wrong string age ");
            Console.ReadKey();

            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter your age: ");
            try
            {
                byte age1 = checked((byte)int.Parse(Console.ReadLine()));
                Console.WriteLine("Your name is {0} and age is {1} ", name1, age1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Write("What is your favorite day of week?: ");
            string myDay = Console.ReadLine();
            Console.Write("Your favorite day is: " + Enum.Parse(typeof(DayOfWeek),myDay));



            Console.ReadKey();



        }
    }
}
