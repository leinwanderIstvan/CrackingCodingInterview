using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aabcccccaaa";
            Compression(str);

            Console.ReadLine();
        }
        

        public static void Compression(string str) 
        {
            if (str == null || str == "")
            {
                Console.WriteLine("Invalid value!");
            }

            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                int count = 1;
                while (i < length - 1 && str[i] == str[i + 1])
                {
                    count++;
                    i++;
                }

                Console.WriteLine("{0} : {1}", str[i], count);
            }    

            
        }
    }
}
