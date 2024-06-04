using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class Program
    {
        /*1.	Write a java program to find nth lowest number in an array/arraylist. N is less than (length of array – 1)*/
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter elements: ");

            Console.WriteLine("Enter nth element: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(".......................................................");

            int temp;

            for (int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }

            

            Console.WriteLine();
            for (int i=0;i< arr.Length;i++)
            {
                
                    Console.WriteLine(arr[i]);
                
            }
            Console.WriteLine("nth position ele: ");
            for (int i = 1; i < arr.Length; i++)
            {
                if(i == n)
                {
                    Console.WriteLine(arr[i-1]);
                }
               

            }

        }
    }
}
