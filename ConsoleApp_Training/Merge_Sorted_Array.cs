using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp_Training
{
    static class Merge_Sorted_Array
    {
        public static void subMain()
        {
            int[] liste1 = new int[] { 1, 3, 4, 5, 6, 7 };
            int[] liste2 = new int[] { 2, 4, 5, 6, 7, 8, 9, 11, 12 };
            int[] o = new int[liste1.Length + liste2.Length];



            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Reset();
            stopwatch1.Start();
            //Complexity O(m+n)
            Method3(liste1, liste2, liste1.Length, liste2.Length, o);
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedTicks);


            //Display results
            for (int i = 0; i <= o.Length - 1; i++)
            {
                Console.WriteLine("Output ==> " + o[i]);
            }
        }

        private static void Method1(int[] liste1, int[] liste2, int[] o)
        {
            int currentIndex = 0;
            int minValue = 0;

            for (int i = 0; i <= liste1.Length - 1; i++)
            {
                for (int j = 0; j <= liste2.Length - 1; j++)
                {
                    if (liste1[i] < liste2[j])
                        minValue = liste1[i];
                    else
                        minValue = liste2[j];

                    //First value
                    if (currentIndex == 0)
                    {
                        o[currentIndex] = minValue;
                        currentIndex++;
                        //break;
                    }

                    //Save the new value for next iterations
                    if (minValue > o[currentIndex - 1])
                    {
                        o[currentIndex] = minValue;
                        currentIndex++;
                        //break;
                    }

                }
            }

        }

        /// <summary>
        /// Complexity O(m+n)
        /// </summary>
        /// <param name="liste1"></param>
        /// <param name="liste2"></param>
        /// <param name="o"></param>
        private static void Method2(int[] liste1, int[] liste2, int[] o)
        {
            int pos1 = 0;
            int pos2 = 0;

            for (int i = 0; i < o.Length; i++)
            {
                if (pos1 != -1 && liste1[pos1] < liste2[pos2])
                {
                    o[i] = liste1[pos1];
                    if (pos1 < liste1.Length - 1)
                        pos1++;
                    else
                        pos1 = -1;
                }
                //Case same value
                else if (pos1 != -1 && pos2 != -1 && liste1[pos1] == liste2[pos2])
                {
                    o[i] = liste1[pos1];

                    if (pos1 < liste1.Length - 1)
                        pos1++;
                    else
                        pos1 = -1;

                    if (pos2 < liste2.Length - 1)
                        pos2++;
                    else
                        pos2 = -1;

                }
                else if (pos2 != -1)
                {
                    o[i] = liste2[pos2];
                    if (pos2 < liste2.Length - 1)
                        pos2++;
                    else
                        pos2 = -1;
                }

            }


        }


        public static void Method3(int[] arr1, int[] arr2,
                                  int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < n1 && j < n2)
            {
                // Check if current element  
                // of first array is smaller 
                // than current element 
                // of second array. If yes,  
                // store first array element  
                // and increment first array 
                // index. Otherwise do same  
                // with second array 
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining  
            // elements of first array 
            while (i < n1)
                arr3[k++] = arr1[i++];

            // Store remaining elements 
            // of second array 
            while (j < n2)
                arr3[k++] = arr2[j++];
        }

    }
}
