using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string filePath = @"C:\Users\ivans\Desktop\BinaryFile.bin";
        WriteToFile(filePath);
        ReadFromFile(filePath);
    }
    static void WriteToFile(string filePath) 
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
        }
    }
    static void ReadFromFile(string filePath) 
    {
        if (File.Exists(filePath))
        {
            string stringValue;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                stringValue = reader.ReadString();
            }
            Console.WriteLine("Из файла считано:");
            Console.WriteLine(stringValue);
        }
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
        }
    }
   
}

