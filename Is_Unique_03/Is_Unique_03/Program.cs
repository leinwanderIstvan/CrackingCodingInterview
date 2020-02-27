using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Unique_03
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "geekforgeek";

            Console.WriteLine("{0} : Unique ? {1}", input, isUniqueCharacters(input) ? "YES":"NO");
            Console.ReadLine();

            
        }

        static bool isUniqueCharacters(string str) 
        {
            int[] counters = new int[256];

            Array.Clear(counters, 0, counters.Length -1);

            foreach (var chars in str)
            {
                if (++counters[chars] > 1)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
