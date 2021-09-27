using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab1
{
    class Program
    {
        
        public static (int sum,int val) A()
        {
            int el = 6;
            
            return (el1:6, 5);
        }
        static void Main(string[] args)
        {

            Tarif tarif1 = new Tarif("SmartClassic", 5);
            Tarif tarif2 = new Tarif("SmartGold", 15);
            Tarif tarif3 = new Tarif("SmartPlatinum", 14);

            Person pers1 = new Person("Alena", tarif1, 500);
            Person pers2 = new Person("Kristina", tarif2, 600);
            Person pers3 = new Person("Zhanna", tarif3, 800);
            Bank database = new Bank();

            database.Add<Person>(pers1);
            database.Add<Person>(pers2);
            database.Add<Person>(pers3);
            database.Add<Tarif>(tarif1);
            database.Add<Tarif>(tarif2);
            database.Add<Tarif>(tarif3);

            var del = new Journal();
            //database.NotifyList += del.RegistrationEvent;
            // database.NotifyRegistr += (string description, string name) =>
            // {
            //    Console.WriteLine(description);
            //    Console.WriteLine(name);
            //};

            database.Add<Person>(new Person("Rostislav"));

            //del.EvInf();
            //database.RegistrationTarif(pers4, tarif1, 500);
            /* Console.WriteLine(database.ProcentValue());
             Console.WriteLine(database.DepositCount());
             Console.WriteLine(database.ClientName());
             Console.WriteLine(database.AboveSum(900));
             database.SumList();
            */
            //(string name, int sum) a = ("al", 6);
            var a = (name:"al",count: 7);

            a.

            var t = A();
            Console.WriteLine(t.sum);
             






        }







    }
}
