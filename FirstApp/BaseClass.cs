namespace FirstApp
{
    abstract class BaseClass
    {
        protected int Id;

        protected BaseClass( int id)
        {
            Id = id;
        }

        public void GetId() 
        {
            Console.WriteLine("Создан объект с Id " + Id);
        }
        public abstract BaseClass Clone();
    }
}