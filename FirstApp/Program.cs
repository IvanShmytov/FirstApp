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
                User user = new User();
                Account account = new Account();
                IUpdater<Account> updater = new UserService();
                updater.Update(account);
                UserService US = new UserService();
                US.Update(user);
                US.Update(account);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
        }
       
    }
    class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
}

