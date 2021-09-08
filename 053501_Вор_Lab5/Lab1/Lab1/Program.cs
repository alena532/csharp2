using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tarif tarif1 = new Tarif("first", 5);
            Tarif tarif2 = new Tarif("second", 15);
            Tarif tarif3 = new Tarif("third", 14);
            MyCustomCollection<Tarif> tarifs = new MyCustomCollection<Tarif>(tarif1);
            tarifs.Add(tarif2);
            tarifs.Add(tarif3);
            Person pers1 = new Person("Alena", tarif1, 500);
            Person pers2 = new Person("Kristina",tarif2,600);
            Person pers3 = new Person("Zhanna",tarif3,800);
            MyCustomCollection<Person> people = new MyCustomCollection<Person>(pers1);
            people.Add(pers2);
            people.Add(pers3);
            Bank database = new Bank(people, tarifs);
            database.InfPerson();
            database.InfTarifs();

            





        }
    }
}
