using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    public static void Main(string[] args)
    {
        Contact con = new Contact("Victor", 333222, "victor@mail.ru");
        BinaryFormatter form = new BinaryFormatter();
        using (FileStream fs = new FileStream("Victor.dat", FileMode.OpenOrCreate)) 
        {
            form.Serialize(fs, con);
            Console.WriteLine("Объект сериализован");
        }
        using (FileStream fs = new FileStream("Victor.dat", FileMode.OpenOrCreate)) 
        {
            Contact newCon = (Contact)form.Deserialize(fs);
            Console.WriteLine("Объект десериализован");
            Console.WriteLine(newCon); 
        }
    }
    [Serializable]
    class Contact
    {
        private string Name { get; set; }
        private long PhoneNumber { get; set; }
        private string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString() 
        {
            string result = $"имя - {Name}\nтелефон - {PhoneNumber}\nемейл - {Email}";
            return result; 
        }
    }

   
}

