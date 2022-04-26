using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace FirstApp
{
    class MainClass
    {
        public delegate Car CarDelegate();
        public delegate void ParentDelegate(Parent p);
        public static void Main(string[] args)
        {

            CarDelegate cardel = LexusHandler;
            Child ch = new Child();
            ParentDelegate PD = ParentInfo;
            PD.Invoke(ch);
            Console.Read();
        }
        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }
        public static void ParentInfo(Parent par) 
        {
            Console.WriteLine(par.GetType());
        }
    }
    class Car {}
    class Lexus : Car { }
    class Parent {}
    class Child : Parent { }
}

