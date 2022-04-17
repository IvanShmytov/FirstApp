using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //Counter();
        Mover();
    }
    public static void Counter() 
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\\");
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length );
            }

            DirectoryInfo newDirectory = new DirectoryInfo(@"D:\\NewDir2");
            if (!newDirectory.Exists)
                newDirectory.Create();

            Console.WriteLine(dirInfo.GetDirectories().Length);
            dirInfo = new DirectoryInfo(@"D:\\NewDir2");
            dirInfo.Delete(true); // Удаление со всем содержимым
            Console.WriteLine("Каталог удален");
            dirInfo = new DirectoryInfo(@"D:\\");
            Console.WriteLine(dirInfo.GetDirectories().Length);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void Mover() 
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\ivans\\Desktop\\testFolder");
            string trashPath = "C:\\Users\\ivans\\Desktop\\trash\\testFolder";

            dirInfo.MoveTo(trashPath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
  
   

