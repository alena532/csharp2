using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab1
{
    public class Bank
    {
        List<Person> people=new();
        Dictionary<string,Tarif> tarifs=new();
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
                tarifs.Add(a.Deposit,a);
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
        public void TarifsNames()
        {
            var selectedNames = from t in tarifs
                                orderby t.Value.Percent
                                select t;
            foreach(var s in selectedNames)
            {
                Console.WriteLine(s.Value.Deposit);
            }

        }
        public int ProcentValue()
        {

          int sum = people.Where(p=>p.Dep!=null).Select(r => r.Dep.Percent).Sum();
          /* var  sum = (from el in people
                        where el.Dep!=null
                      select el.Dep.Percent).Sum();
          */
            return sum;
        }

        public void SumList()
        {
            var sum = people.Where(t => t.Dep != null).GroupBy(t => t.Name);
            foreach(var group in sum)
            {
                foreach(var el  in group)
                {
                    Console.WriteLine(el.Sum);

                }
            }
        }

        public int DepositCount()
        {
            int selectedPercents = (from t in people
                                    where t.Dep != null
                                    select t.Dep).Count();
            return selectedPercents;
        }

        public string ClientName()
        {
            string name = people.Where(p => p.Sum != 0).OrderBy(t => t.Sum).Select(p => p.Name).Last();
            return name;
        }

        public int AboveSum(int sum)
        {
            int amount = people.Where(t => t.Sum >= sum).Count();
            return amount;
        }

        public void InfTarifs()
        {
            foreach (var el in tarifs)
            {
                Console.WriteLine(el.Value.Deposit);
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
