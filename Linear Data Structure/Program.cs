using System;
using System.Collections.Generic;

namespace Linear_Data_Structure
{
    class Program
    {
        public static void Main()
        {
            //Initializing Intergers for each class
            int[] StackNumber = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] FrequencyArray = new int[] { 1, 1, 2, 2, 2, 3, 4, 4, 4, 4, 5, 5, 5};
            int SequenceStartNumber = 2;
            int MaxCount = 50;

            ReverseNumber.StackDemostration(StackNumber);

            ArrayOfInt.ArrayFrequencyCounter(FrequencyArray);

            SequenceQueue.SQ(SequenceStartNumber, MaxCount);
        }
    }
}
