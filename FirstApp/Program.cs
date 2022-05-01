using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace FirstApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                //Writer Pushkin = new Writer();
                //((IWriter)Pushkin).Write();
                Worker worker = new Worker();
                ((IWorker)worker).Build();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
        }
       
    }
    public interface IWriter
    {
        void Write();
    }
    class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    class Worker : IWorker
    {
        void IWorker.Build()
        {
            throw new NotImplementedException();
        }
    }
    public interface IManager 
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();

    }
}

