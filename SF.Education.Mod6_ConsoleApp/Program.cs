using System;

namespace SF.Education.Mod6_ConsoleApp
{
    class Program
    {
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
            int a = 5;
    
        }
    }

    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
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
            public void Info()
            {
                Console.WriteLine("Это {0} по кличке {1}, ему {2}", type2, name2, age2);
            }
        }
    }
    class Pen
    {
        public string color;
        public int cost;

        Pen()
        {
            color = "Черный";
            cost = 100;
        }

        Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public int Square()
        {
            return a * b;
        }
    }

    class Bus
    {
        public int? Load;
        
        
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

    class TrafficLight
    {
        private void ChangeColor(string color)
        {

        }

        public string GetColor()
        {
            return "Red";
        }
    }
    class User
    {
        private int age;

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
