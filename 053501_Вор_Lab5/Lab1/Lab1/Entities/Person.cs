﻿using System;
namespace Lab1
{
    public class Person
    {
        public string Name { get; set; }
        public Tarif Dep { get; set; }
        public  int Sum { get; set; }
        public Person(string Name,Tarif Dep,int Sum)
        {
            this.Name = Name;
            this.Dep = Dep;
            this.Sum = Sum;
        }
    }
}
