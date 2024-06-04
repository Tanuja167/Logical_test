using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class Assign3
    {
        /*3.	Find first non-repeating letter in the  given string. 
      e.g.  Input string is ‘My Name is Yasmin’. First non-repeating string is ‘e’. */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            string str2 = str.ToLower();
            char[] arr = str2.ToCharArray();
            

            for (int i=0; i<arr.Length; i++)
            {
                int cnt = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cnt++;
                    }
                }
                if(cnt == 1)
                {
                    Console.WriteLine(arr[i]);
                    break;
                   
                }
                                  
            }
           
        }

    }
}
