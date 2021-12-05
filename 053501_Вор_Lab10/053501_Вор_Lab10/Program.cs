using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace _053501_Вор_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Alena", 25, true));
            employees.Add(new Employee("Gena", 20, true));
            employees.Add(new Employee("Liza", 29, true));
            employees.Add(new Employee("Maya", 20, true));
            employees.Add(new Employee("Valya", 19, true));
            Assembly asm = Assembly.LoadFrom("053501_Вор_Lab10.Domain.dll");
            Console.WriteLine(asm.FullName);

            Type[] types = asm.GetTypes();
            Type my = types[0].MakeGenericType(new Type[] { typeof(Employee) });


            //try
            // {
            // Type type = asm.GetType("FileService`1", true, true).MakeGenericType(new Type[] { typeof(Employee) });
            //}
            //catch (Exception ex)
            //{
            // Console.WriteLine(ex.Message);
            //}
            object obj = Activator.CreateInstance(my);
            
             MethodInfo SaveData = my.GetMethod("Savedata");
            MethodInfo SaveData1 = my.GetMethod("ReadFile");

            SaveData.Invoke(obj, new object[] { employees, "employees.txt" });
            SaveData1.Invoke(obj, new object[] { "employees.txt" });
            
        }
    }
}
