using System;
using _053501_Vor_Lab9.Domain;
using System.Collections;
using System.Collections.Generic;
using Serializer;


namespace _053501_Vor_Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RunWay> runwaysBelAvia = new List<RunWay>();
            runwaysBelAvia.Add(new RunWay(1000));
            runwaysBelAvia.Add(new RunWay(2000));
            runwaysBelAvia.Add(new RunWay(3000));

            List<RunWay> runwaysUsAvia = new List<RunWay>();
            runwaysUsAvia.Add(new RunWay(1000));
            runwaysUsAvia.Add(new RunWay(2000));
            runwaysUsAvia.Add(new RunWay(3000));

            List<Airport> kontainer = new List<Airport>();
            kontainer.Add(new Airport("belavia", runwaysBelAvia));
            kontainer.Add(new Airport("USAvia", runwaysUsAvia));

            Serializer1 serializer = new Serializer1();
            serializer.SerializeXML(kontainer, "serxml.xml");
            serializer.SerializeJSON(kontainer, "serjson.txt");
            serializer.SerializeByLINQ(kontainer, "serlinq.txt");

            foreach(var el in serializer.DeSerializeXML("serxml.xml"))
            {
                Console.WriteLine($"Airport name:{el.Name}");
                foreach(var rainways in el.Runways)
                {
                    Console.WriteLine($"Rainway length:{rainways.Length}");
                }
            }

            foreach (var el in serializer.DeSerializeJSON("serjson.txt"))
            {
                Console.WriteLine($"Airport name:{el.Name}");
                foreach (var rainways in el.Runways)
                {
                    Console.WriteLine($"Rainway length:{rainways.Length}");
                }
            }

             foreach (var el in serializer.DeSerializeByLINQ("serlinq.txt"))
             {
               Console.WriteLine($"Airport name:{el.Name}");
               foreach (var rainways in el.Runways)
               {
                 Console.WriteLine($"Rainway length:{rainways.Length}");
               }
             }
        }
    }
}
