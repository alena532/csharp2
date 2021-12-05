using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _053501_Lab11_Domain1
{
    public  class Calculations
    {
        public delegate void res(double res);
        public event res ShowResult;
        
        public void ResultInf(double res)
        {
            Console.WriteLine(res);
        }
        public  void Integral()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            double x, h, s, y;
            
            s = 0;
            double capacity = 0.00000001;
            for (x = capacity / 2; x < 1; x += capacity)
            {
                y = Math.Sin(x);// подинтегральная функция
                s += y * capacity; // Элементарное приращение
            }
            ShowResult?.Invoke(s);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            
        }

    }
}
