using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Permutation_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";

            int[] counter = new int[128];

            for (int i = 0; i < str.Length; i++)
            {
                counter[str[i]]++;
            }

            int count = 0;
            for (int i = 0; i < 128; i++)
            {
                count += counter[i] % 2;
            }


            Console.WriteLine(count <= 1);


            Console.ReadLine();
        }
    }
}
