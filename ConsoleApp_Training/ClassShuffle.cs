using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp_Training
{
    public static class ClassShuffle
    {
        //Unresolved
        public static void MainShuffle()
        {

            //int[] list = { -6,10,184};
            //int[] list = { };
            int[] list = {1,2,3,4,5,6,7,8,9,10,11,12,13 };
            Console.WriteLine(Shuffle3(list));

        }


        private static int[] Shuffle3(int[] list)
        {
            int[] listResult = new int[list.Length];
            Random r = new Random();
            listResult = list.OrderBy(x => r.Next(0, list.Length)).ToArray();

            return listResult;
        }

        private static int[] Shuffle1(int[] list)
        {
            int[] listResult = new int[list.Length];
            Random r = new Random();
            int j = 0;

            for (int i = 0; i < list.Length; i++)
            {
                j = r.Next(0, list.Length);

                // Find random pointer
                while (listResult[j] != 0 || j==i)
                    j = r.Next(0, list.Length);

                listResult[j] = list[i];
            }

            return listResult;
        }

        private static int[] Shuffle2(int[] list)
        {
            int[] listResult = new int[list.Length];
            Random r = new Random();
            int j = 0;

            // Define random pointer between range + never start at 0 to avoid having same order
            if (list.Length == 0)
                return list;

            j = r.Next(1, list.Length);

            for (int i = 0; i < list.Length; i++)
            {
                //Go back to begin of list of we reach end of the array
                if (j == list.Length)
                    j = 0;
                
                listResult[j] = list[i];
                j++;

            }

            return listResult;
        }

    }
}
