using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class HalfAsendingDecending
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 6, 24, 18, 2,9 };
            int temp = 0;

            for(int i=0;i<arr.Length/2; i++)
            {
               for(int j=0;j<arr.Length/2; j++)
                {
                    if (arr[i] < arr[j])        
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {
                for (int j = arr.Length / 2; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i=0;i<arr.Length;i++)
          {
                Console.WriteLine(arr[i]);
          }
        }
    }
}
