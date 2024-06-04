using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class Intermedient1
    {/*1.	An array contains strings of different lengths. e.g. { ‘I’ , ‘am’ , ‘very’ , ‘smart’ }.Write a
      * program such that array will contain all strings of same length,   output – { ‘Iam’ , ‘ver’ , ‘ysm’
      * , ‘art’ }  if array does not contain sufficient characters , replace last chars by #  
         e.g. { ‘I’ , ‘am’ , ‘very’ , ‘good’ }    output  { ‘Iam’ , ‘ver’ , ‘ygo’ , ‘od#’ }*/

        static void Main(string[] args)
        {

            string[] str = new string[] { "I", "am", "very", "smart"};
            string str1 = "";

            for (int i = 0; i < str.Length; i++)
            {
                char[] ch = str[i].ToCharArray();
                for(int j=0; j < ch.Length; j++)
                {
                    Console.WriteLine(ch[j]);
                }

                
            }
           


        }
    }
}
