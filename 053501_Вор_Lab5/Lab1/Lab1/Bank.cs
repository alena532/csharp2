using System;
namespace Lab1
{
    public class Bank
    {
        MyCustomCollection<Person> people=new();
        MyCustomCollection<Tarif> tarifs=new();
        public delegate void Del(string description, string name);
        public event Del NotifyList;
        public event Del NotifyRegistr;
       
        public Bank()
        {
        }

        public void Add<T>(T item)where T:class
        {
            if (item is Person)
            {
                Person a = item as Person;
                people.Add(a);
                NotifyList?.Invoke("addPeson", a.Name);

            }else if(item is Tarif)
            {
                Tarif a = item as Tarif;
                tarifs.Add(a);
                NotifyList?.Invoke("addTarif", a.Deposit);
            }
            else
            {
                throw new InvalidCastException() ;
            }    
        }

        public void RegistrationTarif(Person a,Tarif Dep, int Sum)
        {
            a.Registration(Dep, Sum);
            NotifyRegistr?.Invoke("addDeposit", Dep.Deposit);
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
