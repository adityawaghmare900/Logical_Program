namespace LogicalProgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0; int b=1;
            Console.Write(a+" "+ b+" "); 
            for(int i=0;i<10;i++)
            {
                int c = a + b;
                Console.Write(c+" ");
                a = b;
                b=c;
            }
        }
    }
}