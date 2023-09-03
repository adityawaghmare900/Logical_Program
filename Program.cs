using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace LogicalProgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter the number: ");
            int a=Convert.ToInt16(Console.ReadLine());
            for(int  i = 1; i < a; i++)
            {
                if(a%i == 0)
                {
                    sum = sum + i;  
                }
            }
            if(sum==a)
            {
                Console.WriteLine("Given number is Perfect Number");
            }
        }
    }
}