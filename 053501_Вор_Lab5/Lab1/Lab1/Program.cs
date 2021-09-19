﻿using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Tarif tarif1 = new Tarif("SmartClassic", 5);
            Tarif tarif2 = new Tarif("SmartGold", 15);
            Tarif tarif3 = new Tarif("SmartPlatinum", 14);
         
            Person pers1 = new Person("Alena", tarif1, 500);
            Person pers2 = new Person("Kristina",tarif2,600);
            Person pers3 = new Person("Zhanna",tarif3,800);
            Bank database = new Bank();

            database.Add<Person>(pers1);
            database.Add<Person>(pers2);
            database.Add<Person>(pers3);
            database.Add<Tarif>(tarif1);
            database.Add<Tarif>(tarif2);
            database.Add<Tarif>(tarif3);

            var del = new Journal();
            database.NotifyList += del.RegistrationEvent;
            database.NotifyRegistr += (string description, string name) =>
              {
                  Console.WriteLine(description);
                  Console.WriteLine(name);
              };
            Person pers4 = new Person("Zhanna");
            database.Add<Person>(pers4);
            
            del.EvInf();
            database.RegistrationTarif(pers4, tarif1, 500);
          



            





        }
    }
}
