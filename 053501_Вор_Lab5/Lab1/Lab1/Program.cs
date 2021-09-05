using System;

namespace Lab1
{
    class Program
    {
        public static void infClient(MyCustomCollection<Person> a)
        {
            for (int i=0;i<a.Count;i++)
            {
                Console.WriteLine(a[i].Name);
            }

        }
        public static void incrDeposit(Person a)
        {
            Console.WriteLine("Enter your increasing sum:");
            string input = Console.ReadLine();
            int number;
            bool result = int.TryParse(input, out number);
            if (result == true)
            {
                a.Sum += number;
                Console.WriteLine($"Successfully.Total:{a.Sum}");
            }   
            else
                throw new Exception("Please,inter number");
        }
        public static int totalPayments()
        {

        }
       
        static void Main(string[] args)
        {
            Person f = new Person();
            f.Name = "Vasya";
            Person s = new Person();
            s.Name = "kostya";
            Person t = new Person();
            t.Name = "kolya";

            MyCustomCollection<Person> a = new MyCustomCollection<Person>(f);
            a.Add(s);
            a.Add(t);

            inf(a);
            



        }
    }
}
