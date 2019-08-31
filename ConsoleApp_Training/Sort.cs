using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApp_Training
{
    static class Sort
    {

        public static void Call()
        {
            

            int[] listInitial = new int[500];
            Random random = new Random();
            for (int i = 0; i < listInitial.Length; i++)
            {
                listInitial[i] = random.Next(listInitial.Length*2);
            }

            //int[] list = { 6, 3,2,4 };
            //int[] list = { 6, 3, 4, 2 };
            int[] list = (int[])listInitial.Clone();
            //int[] list = { 6,5,3,1,8,7,2,4};

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Reset();
            stopwatch1.Start();

            int[] sortedlist1 = Sort.SelectionSort(list);

            stopwatch1.Stop();
            Console.WriteLine(String.Format("Selection Sort ==> {0} ticks", stopwatch1.ElapsedTicks));

            list = (int[])listInitial.Clone();
            stopwatch1.Reset();
            stopwatch1.Start();
            int[] sortedlist2 = Sort.MergeSortGlobal(list);
            stopwatch1.Stop();
            Console.WriteLine(String.Format("Merge Sort ==> {0} ticks", stopwatch1.ElapsedTicks));

            stopwatch1.Reset();
            stopwatch1.Start();
            var sortedlist3 = listInitial.OrderBy(i=>i);
            stopwatch1.Stop();
            Console.WriteLine(String.Format("Linq Order by  Sort ==> {0} ticks", stopwatch1.ElapsedTicks));
        }

        static int[] SelectionSort(int[] list)
        {
            int i,temp;

            for (int j = 0; j < list.Length; j++)
            {
                i = 0;
                temp = 0;
                while (i < list.Length - 1)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                    i++;
                }
            }


            return list;

        }

        static int[] MergeSortGlobal(int[] list)
        {
            return MergeSort(list, null);
        }

        static int[] MergeSort(int[] list, int[] listAdjacent)
        {
            int middle = 0;
            int[] listLeft, listRight;

            /* Divide array by 2 in subArrays until having array of two elements */
            if (list.Length > 1)
            {
                middle = list.Length / 2;

                if ((list.Length % 2) > 0 )
                    middle++;

                listLeft = new int[middle];
                listRight = new int[(list.Length / 2)];

                /* Copy left side */
                for (int i = 0; i < middle; i++)
                    listLeft[i] = list[i];

                /* Copy right side */
                for (int i = middle; i < list.Length; i++)
                    listRight[i-middle] = list[i];


                //Sort list
                list = MergeSort(listLeft, listRight);
                
            }

            /* When we reach the top of recursive level, we return the final merged list */
            if (null == listAdjacent)
                return list;

            //Sort listAdjacent
            if (listAdjacent.Length > 1)
            {
                //middle = listAdjacent.Length / 2;
                //listLeft = new int[middle];
                //listRight = new int[middle];

                middle = listAdjacent.Length / 2;

                if ((listAdjacent.Length % 2) > 0)
                    middle++;

                listLeft = new int[middle];
                listRight = new int[(listAdjacent.Length / 2)];

                /* Copy left side */
                for (int i = 0; i < middle; i++)
                    listLeft[i] = listAdjacent[i];

                /* Copy right side */
                for (int i = middle; i < listAdjacent.Length; i++)
                    listRight[i - middle] = listAdjacent[i];


                //Sort listAdjacent
                listAdjacent = MergeSort(listLeft, listRight);

            }


            int[] mergeList = new int[list.Length * 2];

            /* Merge the two lists */
            int a = 0, b = 0;
            while (a < list.Length && b < listAdjacent.Length)
            {
                if (list[a] > listAdjacent[b])
                {
                    mergeList[a + b] = listAdjacent[b];
                    b++;
                }
                else
                {
                    mergeList[a + b] = list[a];
                    a++;
                }

            }

            /* Copy the rest of data */
            while (a < b & ((a+b) <(list.Length + listAdjacent.Length)))
            {
                mergeList[a + b] = list[a];
                a++;
            }

            while (b < a & ((a + b) < (list.Length + listAdjacent.Length)))
            {
                mergeList[a + b] = listAdjacent[b];
                b++;
            }

            return mergeList;

        }

        }
}
