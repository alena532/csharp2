using System;
using System.Collections;
namespace Files
{
    public class Employee
    {
        public string Name { get; }
        public int Age { get; }
        public bool AtWork { get; set; }


        public Employee(string name, int age,bool work)
        {
            Name = name;
            Age = age;
            AtWork = work;
        }
        public void ShowInf()
        {
            Console.WriteLine($"Name:{Name} Age:{Age} At work:{AtWork}");
           
        }

        
    }
}
