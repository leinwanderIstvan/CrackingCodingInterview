using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceSpace("This is a sentence !"));
            Console.ReadLine();
        }

        public static string ReplaceSpace(string str) 
        {

            char[] strChars = str.ToCharArray();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < strChars.Length; i++)
            {
                if (strChars[i] == 32)
                {
                    stringBuilder.Append("%20");
                }
                else
                {
                    stringBuilder.Append(strChars[i]);
                }
            }

            return stringBuilder.ToString();
            
        }
    }
}
