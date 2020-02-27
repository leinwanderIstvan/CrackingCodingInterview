using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] string1 = ("abc").ToCharArray();
            char[] string2 = ("bca").ToCharArray();

            if (Permutation(string1, string2))
            {
                Console.WriteLine("String2 is permutation of string1!");
            }
            else
            {
                Console.WriteLine("String2 is not a permutation of string1!");
            }

            

            Console.ReadLine();

        }

        static bool Permutation(char[] str1, char[]str2) 
        {

            int NumberOfCharacters = 256;

            int[] counter1 = new int[NumberOfCharacters];
            int[] counter2 = new int[NumberOfCharacters];


            for (int i = 0; i < str1.Length && i < str2.Length; i++)
            {
                counter1[str1[i]]++;
                counter2[str2[i]]++;
            }

            if (str1.Length != str2.Length)
            {
                return false;
            }

            for (int i = 0; i < NumberOfCharacters; i++)
            {
                if (counter1[i] != counter2[i])
                {
                    return false;
                }
            }

            return true;
            

        }
    }
}
