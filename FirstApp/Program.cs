using System;

class MainClass
{
    public static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
    }
   
    class BaseClass
    {
        protected string Name;
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
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
  
}

