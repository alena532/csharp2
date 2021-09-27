using System;
namespace Lab1
{
    public class Journal
    {
        private class DescribeEvent
        {
            public string description;
            public string name;
            public DescribeEvent(string description,string name)
            {
                this.description = description;
                this.name = name;
            }
        }

        MyCustomCollection<DescribeEvent> ListEvents = new();
        public Journal()
        {
        }
 
        public void RegistrationEvent(string description,string name)
        {
            DescribeEvent a = new DescribeEvent(description, name);
            ListEvents.Add(a);
        }

        public void EvInf()
        {
            for(int i = 0; i < ListEvents.Count; i++)
            {
                Console.WriteLine(ListEvents[i].description);
                Console.WriteLine(ListEvents[i].name);
               
            }
        }
    }
}
