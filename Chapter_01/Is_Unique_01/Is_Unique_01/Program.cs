using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Unique_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input ="Thisisit";
            if (uniqueCharacters(input.ToLower()) == true)
            {
                Console.WriteLine("The input string has all unique characters!");
            }
            else 
            {
                Console.WriteLine("The string has duplicate characters!");
            }

            Console.ReadLine();
            
        }

        static bool uniqueCharacters(string word) 
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        
                        return false;
                    }
                }
            }


            return true;
        }
    }
}
