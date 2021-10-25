using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Employee>();
            data.Add(new Employee("Anton", 25,true));
            data.Add(new Employee("Vasya", 27, true));
            data.Add(new Employee("Petya", 28, true));
            data.Add(new Employee("Kristina", 30, true));
            data.Add(new Employee("Maya", 19, true));
            data.Add(new Employee("Alena", 18, true));
            FileService service = new FileService();
            service.SaveData(data, "./employees2.txt");
            File.Move("./employees2.txt", "myfile");
            List<Employee> data2 = new List<Employee>(service.ReadFile("myfile"));
            //1 collection
            foreach(var t in data)
            {
                t.ShowInf();
            }
            Console.WriteLine();
            var linq = data2.OrderBy(t => t, new EmployeeComparer_Employee_());
            //sorted collection    
            foreach(var el in linq)
            {
                el.ShowInf();
            }


                     





        }
    }
}
