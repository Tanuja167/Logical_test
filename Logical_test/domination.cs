using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_test
{
    internal class domination
    {
        /*Denomination problem - here are notes of 1000, 500, 200,100,50,20 and 10. 
You need to distribute given amount in such a way that minimum number of notes are given. 
e.g. If amount to be given is 540 - then 500 -->1 note , 20-->2 notes 
if amount is 8930 --> 1000--> 8 notes  500-->1 note 200-->2 notes  20 --> 1 note 10 --> 1 note*/
        static void Main(string[] args)
        {
            int[] arr = new int[] {1000, 500, 200, 100, 50, 20,10};

            
            Console.WriteLine("enter amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            int cnt1 = 0, cnt2 =0, cnt3=0, cnt4=0, cnt5=0, cnt6=0, cnt7=0;
            while(amt !=0)
            {
                if(amt>=1000)
                {
                    amt =amt-1000;
                    cnt1++;
                }
                if(amt<1000 &&  amt>=500)
                {
                    amt = amt - 500;
                    cnt2++;
                }
                if(amt<500 && amt>=200)
                {
                    amt = amt - 200;
                    cnt3++;
                }
                if( amt<200 && amt>=100)
                {
                    amt = amt - 100;
                    cnt4++;
                }
                if(amt<100 && amt>=50)
                {
                    amt = amt - 50;
                    cnt5++;
                }
                if(amt<50 && amt>=20)
                {
                    amt = amt - 20;
                    cnt6++;
                }
                if(amt<20 && amt>=10)
                {
                    amt = amt - 10;
                    cnt7++;
                }
            }
            Console.WriteLine($"1000 countis: {cnt1}, \n500 count is{cnt2}, \n200 countis: {cnt3}" +
                $"\n100 countis: {cnt4}, \n50 countis: {cnt5}, \n20 countis: {cnt6}, " +
                $"\n10 countis: {cnt7}");
        } 
    }
}
