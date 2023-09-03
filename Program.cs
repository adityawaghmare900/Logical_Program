using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace LogicalProgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String revString="";
            Console.Write("Enter the name: ");
            String str = Convert.ToString(Console.ReadLine());
            for(int i=0;i<str.Length;i++)
            {
                revString = str[i] + revString;
            }
            Console.WriteLine(revString);
        }
    }
}