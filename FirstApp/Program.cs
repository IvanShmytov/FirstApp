using System;

class MainClass
{
    public static void Main(string[] args)
    {
        
    }
   
    class BaseClass
    {
        protected string Name;
        public virtual int Counter
        {
            get;
            set;
        }

        public BaseClass(string name)
        {
            Name = name;
        }
        public virtual void Display() 
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;
        private int counter;
        public override int Counter 
        {
            get { return counter; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("число меньше 0");
                }
                else 
                {
                    counter = value;
                }
            }
        
        }
        public DerivedClass(string name, string descr, int count): this(name, descr) 
        {
            Counter = count;
        }
        public DerivedClass(string name, string descr) : base(name)
        {
            Description = descr;
        }
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
  
}

