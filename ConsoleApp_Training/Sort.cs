using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Training
{
    static class Sort
    {

        public static void Call()
        {
            int[] list = { 21,2,7,12,6};

            Sort.SortMethod1(list);

        }

        static int[] SortMethod1(int[] list)
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


            return tempList;

        }

    }
}
