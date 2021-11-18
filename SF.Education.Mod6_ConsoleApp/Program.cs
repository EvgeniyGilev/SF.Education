using System;

namespace SF.Education.Mod6_ConsoleApp
{
    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the.
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human.name = "Дмитрий";
            human.age = 23;
            human.Greetings();

            Animal animal = new Animal {type = "Собака", name = "Вольт", age = 4};
            Console.ReadKey();


            Bus buzzz = new Bus();
            buzzz.Load = null;
            //int a = 5;
    
        }
    }

    /// <summary>
    /// The human.
    /// </summary>
    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        /// <summary>
        /// Greetings the.
        /// </summary>
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
    }

    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        /// <summary>
        /// Infos the.
        /// </summary>
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
        public struct Animal2
        {
            // Поля структуры
            public string type2;
            public string name2;
            public int age2;

            // Метод структуры
            /// <summary>
            /// Infos the.
            /// </summary>
            public void Info()
            {
                Console.WriteLine("Это {0} по кличке {1}, ему {2}", type2, name2, age2);
            }
        }
    }
    /// <summary>
    /// The pen.
    /// </summary>
    class Pen
    {
        public string color;
        public int cost;

        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        Pen()
        {
            color = "Черный";
            cost = 100;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pen"/> class.
        /// </summary>
        /// <param name="penColor">The pen color.</param>
        /// <param name="penCost">The pen cost.</param>
        Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
    /// <summary>
    /// The rectangle.
    /// </summary>
    class Rectangle
    {
        public int a;
        public int b;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="side">The side.</param>
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        /// <summary>
        /// Squares the.
        /// </summary>
        /// <returns>An int.</returns>
        public int Square()
        {
            return a * b;
        }
    }

    /// <summary>
    /// The bus.
    /// </summary>
    class Bus
    {
        public int? Load;


        /// <summary>
        /// Prints the status.
        /// </summary>
        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }

    /// <summary>
    /// The traffic light.
    /// </summary>
    class TrafficLight
    {
        /// <summary>
        /// Changes the color.
        /// </summary>
        /// <param name="color">The color.</param>
        private void ChangeColor(string color)
        {

        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <returns>A string.</returns>
        public string GetColor()
        {
            return "Red";
        }
    }
    /// <summary>
    /// The user.
    /// </summary>
    class User
    {
        private int age;

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }

}
