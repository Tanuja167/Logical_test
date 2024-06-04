using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class Assign2
    {
        /*2.	There are 2 arrays of numbers. Find java program to find number in first array which is not in second array.*/
        static void Main(string[] args)
        {
            int[] a = new int[] { 6,7,8,4,2};
            int[] b = new int[] { 5,6,7,11,9 };

           
            for (int i = 0; i < a.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    Console.WriteLine(a[i]);
                }

            }
            
        }
    }
}
