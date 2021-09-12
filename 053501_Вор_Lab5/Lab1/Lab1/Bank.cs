using System;
namespace Lab1
{
    public class Bank
    {
        public MyCustomCollection<Person> people;
        public MyCustomCollection<Tarif> tarifs;
        public delegate void Del(string description, string name);
        public event Del NotifyList;
        public event Del NotifyRegistr;
       
        public Bank(MyCustomCollection<Person> people, MyCustomCollection<Tarif> tarifs)
        {
            this.people = people;
            this.tarifs = tarifs;
        }
        public void Add<T>(T item)where T:class
        {
            if (item is Person)
            {
                Person a = item as Person;
                people.Add(a);
                NotifyList("addPeson", a.Name);

            }else if(item is Tarif)
            {
                Tarif a = item as Tarif;
                tarifs.Add(a);
                NotifyList("addTarif", a.Deposit);
            }
            else
            {
                throw new Exception();
            }    
        }
        public void RegistrationTarif(Person a,Tarif Dep, int Sum)
        {
            a.Registration(Dep, Sum);
            NotifyRegistr("addDeposit", Dep.Deposit);


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
