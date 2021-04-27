using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linear_Data_Structure
{
    class ArrayOfInt
    {
    //For counting the frequency of each number in a given array list.
    public static void ArrayFrequencyCounter(Array Intergers)
        {
            int[] IntergersArr = (int[])Intergers;
            Console.WriteLine("\n|Displays numbers in array and the frequency of those numbers.|\n");
            Console.WriteLine("The numbers in the array are:\n");
            foreach (var item in IntergersArr)
            {
                Console.Write(item + ","); 
            }

            Console.WriteLine("\n");

            var n = from x in IntergersArr
                    group x by x into y
                    select y;
            foreach (var arrNum in n)
            {
                Console.WriteLine("Number " + arrNum.Key + " frequency is: " + arrNum.Count());
            }
        }
    }
}
