using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Unique_02
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputStr = "";
            if (isUniquCharacters(inputStr.ToLower()) == true)
            {
                Console.WriteLine("This input has just unique characters!");
            }
            else
            {
                Console.WriteLine("This input has duplicates!");
            }

            Console.ReadLine();
            
        }

        static bool isUniquCharacters(string word) 
        {
            char[] chars = word.ToCharArray();

            Array.Sort(chars);

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] != chars[i + 1])
                {
                    continue;
                }
                else 
                {
                    return false;
                }
            }

            return true;


        }


    }
}
