using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _053501_Vor_Lab9.Domain
{
    [Serializable]
    public class Airport
    {
        public List<RunWay> Runways;
        public string Name { get; set; }
        public Airport(string name,List<RunWay> a)
        {
            Name = name;
            Runways = a;
        }
        
        public Airport(string name)
        {
            Name = name;
            Runways = new List<RunWay>();
        }
        public Airport()
        {
         
        }






    }
}
