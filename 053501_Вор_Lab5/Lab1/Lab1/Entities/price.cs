using System;
namespace Lab1
{
    public class Tarif
    {
        
        public int Percent { get; set; }
        public string Deposit { get; set; }
        public Tarif(string Deposit, int Percent)
        {
            this.Percent = Percent;
            this.Deposit = Deposit;

        }
    }
}
