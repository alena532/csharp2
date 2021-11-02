using System;
using System.Xml.Serialization;
namespace _053501_Vor_Lab9.Domain
{
    [Serializable]
    public class RunWay
    {
        public int Length { get; set; }
        public RunWay(int length)
        {
            Length = length;
        }
        public RunWay(string length)
        {
            Length = Convert.ToInt32(length);
        }
        public RunWay()
        {
            
        }
    }
}
