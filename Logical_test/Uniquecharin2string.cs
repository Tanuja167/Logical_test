using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class Uniquecharin2string
    {
        static void Main(string[] args)
        {
            //str1 = "india" str2 = "in"  op- da

            string str1 = "India";
            string str2 = "in";

           string str3=  str1.ToLower();
            string str4 = str2.ToLower();
            char[] ch1 = str3.ToCharArray();
            char[] ch2 = str4.ToCharArray();
         
            for (int i=0;i<ch1.Length; i++)
            {
               
                for(int j=0;j<ch2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        ch1[i] = ' ';

                    }
                }
                Console.WriteLine(ch1[i]);

            }
            string str = new string(ch1);
        }
    }
}
