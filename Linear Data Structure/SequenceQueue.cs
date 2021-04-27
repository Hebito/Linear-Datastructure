using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Data_Structure
{
    class SequenceQueue
    {
        //Use to show Queue capability with Sequencing.
        public static void SQ(int n, int maxCount)
        {
            //Initializing code from Main Program
            int S1 = n;
            int S2 = S1 + 1;
            int S3 = 2 * S1 + 1;
            int S4 = S1 + 2;
            int MaxCount = maxCount;
            int count = 0;

            Queue<int> Sequencer = new Queue<int>();
            Sequencer.Enqueue(S1);
            Console.WriteLine("\n|Uses Queue<T> class to display a sequence by a set Number.|");
            Console.WriteLine("\nThe following sequences is:\n");

            //Continues until Queue has reach its intended max count
            while (Sequencer.Count > 0)
            {
                count++;
                int current = Sequencer.Dequeue();
                Console.Write(current + ", ");

                if (count == MaxCount)
                {
                    Console.WriteLine();
                    Console.WriteLine("\nThe sequence amount is: " + count);
                    Console.WriteLine("\n------------------------------------------------------------------------------------");
                    return;
                }

                //Sequence 2 or S2
                Sequencer.Enqueue(S1 + 1);
                //S3
                Sequencer.Enqueue(2 * S1 + 1);
                //S4
                Sequencer.Enqueue(S1 + 2);
                //S5
                Sequencer.Enqueue(S2 + 1);
                //S6
                Sequencer.Enqueue(2 * S2 + 1);
                //S7
                Sequencer.Enqueue(S2 + 2);
                //S8
                Sequencer.Enqueue(S3 + 1);
                //S9
                Sequencer.Enqueue(2 * S3 + 1);
                //S10
                Sequencer.Enqueue(S3 + 2);
                //S11
                Sequencer.Enqueue(S4 + 1);
                //S12
                Sequencer.Enqueue(2 * S4 + 1);
                //S13
                Sequencer.Enqueue(S4 + 2);
            }
        }
    }
}

