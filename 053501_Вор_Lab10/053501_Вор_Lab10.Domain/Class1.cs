using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using _053501_Вор_Lab10;

namespace _053501_Вор_Lab10.Domain
{
    public class FileService<T> : IFileService<T> where T : class
    {
        public IEnumerable<T> ReadFile(string filename) 
        {
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                T[] employees = (T[])serializer.Deserialize(file, typeof(Employee[]));
                return employees;
            }
        }

        public void Savedata(IEnumerable<T> data, string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }
    }
}
