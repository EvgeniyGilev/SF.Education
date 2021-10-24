using System;

namespace SF.Education.Mod7_CondolseApp
{
    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();

            DerivedClass obj = new DerivedClass();
            obj.Display();


            Console.ReadKey();

            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();


            Console.ReadKey();

            


        }


    }

    class Generic<T>
    {
        public T Field = default(T); // Поле типа T

    }

    class Record<T1,T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }

    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {


            get { return counter; }
            set
            {
                if (counter < 0)
                {
                    Console.WriteLine("Число должно быть больше 0!");
                }
                else
                {
                    counter = value;
                }
            }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }

    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        // Индексатор по массиву
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }

}




