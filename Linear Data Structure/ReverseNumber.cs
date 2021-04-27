using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Data_Structure
{
    //Use to show stack functionality by displaying a stacked array list.
    class ReverseNumber
    {
        public static void StackDemostration(Array NumArray)
        {
            int[] Num = (int[])NumArray;
           
            Stack<int> ReverseOrder = new Stack<int>();
            Console.WriteLine("|Displays stack from array list, with LIFO(Last In, First Out) functionality.|");

            //Insert each item from the given array into a stack
            foreach (var item in Num)
            {
                ReverseOrder.Push(item);
            }

            Console.WriteLine("Current Stack before Pop:");

            foreach (var item in ReverseOrder)
            {
                Console.Write(item + ","); //prints 6,5,4,3,2,1
            }

            Console.WriteLine("\n\nRemoving Value...");

            //Pop the last in the stack to show how LIFO works
            ReverseOrder.Pop();
            Console.WriteLine("\nCurrent Stack after Pop:");

            foreach (var item in ReverseOrder)
            {
                Console.Write(item + ","); //prints 5,4,3,2,1
            }

            Console.WriteLine("\n");
        }
    }
}
