using System.Linq;
using System;
namespace ConsoleApp95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cheat one new mansoura sum of odd integers
            int t = int.Parse(Console.ReadLine()!);
            while( t--  > 0)
            {
               long[] num = Console.ReadLine()!.Split().Select(long.Parse).ToArray();
                long n = num[0];
                long k = num[1];
                Console.WriteLine(n % 2 == k % 2 && n >= k * k ? "YES" : "NO");
            }
        }
        
    }
}
