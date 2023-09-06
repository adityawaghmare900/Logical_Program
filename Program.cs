using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Transactions;

namespace LogicalProgam
{
    internal class CouponNumber
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i= 0; i <= 5000 ; i++) 
            {
                Console.WriteLine(i);
            }
            stopwatch.Stop();
            Console.WriteLine("time elasped: "+ stopwatch.Elapsed); 
        }
    }
}