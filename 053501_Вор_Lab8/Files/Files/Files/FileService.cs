using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    public class FileService:IFileService
    {
        public IEnumerable<Employee> ReadFile(string fileName)
        {
            List <Employee> temp= new List<Employee>();
            try
            {
                if (!File.Exists(fileName))
                    throw new ArgumentException(nameof(fileName));
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    int age = Convert.ToInt32(reader.ReadString());
                    bool atWork  = Convert.ToBoolean(reader.ReadString());
                    temp.Add(new Employee(name, age, atWork));
                }
            }
            return temp;
        }

        public void SaveData(IEnumerable<Employee> data, string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
            using(File.Create(fileName)) { } ; 
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(fileName)))
                {
                    foreach (var s in data)
                    {
                        writer.Write($"{s.Name}");
                        writer.Write($"{s.Age}");
                        writer.Write($"{s.AtWork}"); 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
