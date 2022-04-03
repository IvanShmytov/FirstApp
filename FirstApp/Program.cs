using System;

class MainClass
{
    public static void Main(string[] args)
    {
;
    }

    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;
        public DerivedClass(string name, string descr, int count): this(name, descr) 
        {
            Counter = count;
        }
        public DerivedClass(string name, string descr) : base(name)
        {
            Description = descr;
        }
    }
}

