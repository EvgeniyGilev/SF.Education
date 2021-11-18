using System;

namespace SF.Education.Mod7_CondolseApp
{
    /// <summary>
    /// The smart helper.
    /// </summary>
    class SmartHelper
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartHelper"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public SmartHelper(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Greetings the.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
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

    /// <summary>
    /// The generic.
    /// </summary>
    class Generic<T>
    {
        public T Field = default(T); // Поле типа T

    }

    /// <summary>
    /// The record.
    /// </summary>
    class Record<T1,T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }

    /// <summary>
    /// The base class.
    /// </summary>
    class BaseClass
    {
        /// <summary>
        /// Gets or sets the counter.
        /// </summary>
        public virtual int Counter
        {
            get;
            set;
        }
        /// <summary>
        /// Displays the.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }

    }

    /// <summary>
    /// The derived class.
    /// </summary>
    class DerivedClass : BaseClass
    {
        private int counter;
        /// <summary>
        /// Gets or sets the counter.
        /// </summary>
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
        /// <summary>
        /// Displays the.
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }

    }

    /// <summary>
    /// The a.
    /// </summary>
    class A
    {
        /// <summary>
        /// Displays the.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    /// <summary>
    /// The b.
    /// </summary>
    class B : A
    {
        /// <summary>
        /// Displays the.
        /// </summary>
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    /// <summary>
    /// The c.
    /// </summary>
    class C : A
    {
        /// <summary>
        /// Displays the.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    /// <summary>
    /// The d.
    /// </summary>
    class D : B
    {
        /// <summary>
        /// Displays the.
        /// </summary>
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    /// <summary>
    /// The e.
    /// </summary>
    class E : C
    {
        /// <summary>
        /// Displays the.
        /// </summary>
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }

    /// <summary>
    /// The indexing class.
    /// </summary>
    class IndexingClass
    {
        private int[] array;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexingClass"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
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




