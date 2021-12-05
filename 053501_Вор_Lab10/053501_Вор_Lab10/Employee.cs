using System;
namespace _053501_Вор_Lab10
{
    public class Employee
    {
        public int Age { get; set; }
        public bool AtWork { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(string name, int age, bool atWork)
        {
            Name = name;
            Age = age;
            AtWork = atWork;

        }
    }
}
