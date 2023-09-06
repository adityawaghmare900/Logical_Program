using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Transactions;

namespace LogicalProgam
{
    internal class CouponNumber
    {
        static void Main(string[] args)
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTWXYZ012345689";
            var strchar = new char[5];
            var random=new Random();

            for(int i = 0; i < strchar.Length; i++)
            {
                strchar[i]=chars[random.Next(chars.Length)];
            }
            var genRandNum=new String(strchar);
            Console.WriteLine(genRandNum);
        }
    }
}