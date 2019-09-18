using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] str = {3,5,8,7};
            int first = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                str[i - 1] = str[i];
            }
            str[str.Length-1] = first;
            foreach (int a in str)
            {
                Console.WriteLine(a);
            }
        }
    }
}