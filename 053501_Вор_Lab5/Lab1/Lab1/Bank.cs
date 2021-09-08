using System;
namespace Lab1
{
    public class Bank
    {
        MyCustomCollection<Person> people;
        MyCustomCollection<Tarif> tarifs;

       
        public Bank(MyCustomCollection<Person> people, MyCustomCollection<Tarif> tarifs)
        {
            this.people = people;
            this.tarifs = tarifs;
        }
        public void  InfPerson()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Name);
            }
        }
        public void InfTarifs()
        {
            for (int i = 0; i < tarifs.Count; i++)
            {
                Console.WriteLine(tarifs[i].Deposit);
            }
        }
        public void IncDeposit(string Names,int sum)
        {
            Person temp;
            for(int i = 0; i < people.Count; i++)
            {

                if (people[i].Name == Names)
                {
                    temp = people[i];
                    temp.Sum += sum;
                }
            }
            throw new Exception("person not found");

        }
        public int TotalSum()
        {
            int totalSum=0;
            for (int i = 0; i < people.Count; i++)
            {
                totalSum+=people[i].Dep.Percent/365*30* people[i].Sum/100;
                
            }
            return totalSum;

        }
    }
}
