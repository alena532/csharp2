using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using _053501_Lab11_Domain1;
using _053501.Lab11.Domain2;
namespace _053501_Lab11
   
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Task1
            /*Calculations calc = new Calculations();
            calc.ShowResult += calc.ResultInf;
            Thread first = new Thread(new ThreadStart(calc.Integral));
            first.Priority = ThreadPriority.Highest;
            Thread second = new Thread(new ThreadStart(calc.Integral));
            second.Priority = ThreadPriority.Lowest;
            first.Start();
            second.Start();
            */
            MemoryStream stream = new MemoryStream();
            StreamService service = new StreamService();
             var firstMethod=service.WriteToStream(stream);
            var secondMethod= service.CopyFromStream(stream, "ote.txt");
            //await Task.WhenAll(firstMethod, secondMethod);
            Task.WaitAll(firstMethod, secondMethod);
            Func<Autopark, bool> checking = Autopark.Checks;
             await service.GetStatisticsAsync("ote.txt",checking);
            
            
        }
    }
}
