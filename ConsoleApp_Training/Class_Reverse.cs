using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Training
{
    public static class Class_Reverse
    {
        //Unresolved

        public static void MainReverse()
        {
            //Console.WriteLine(Reverse(-123));
            Console.WriteLine(Reverse(121));
            //Console.WriteLine(Reverse(120));
            //Console.WriteLine(Reverse(0));
            //1534236469
            //Console.WriteLine(Reverse(9646324351));
            //Console.WriteLine(Reverse(1534236469));
        }

        public static int Reverse(int x)
        {

            String strX = Convert.ToString(x);
            char[] list = strX.ToCharArray();
            int l = list.Length;
            int start = 0;
            char[] listResult = new char[l];
            long resultlong;

            for (int i = start; i < l; i++)
                    listResult[i] = list[l - 1 - i];

            String s = new String(listResult);


            //Management of negative value
            if (s[s.Length-1] == '-')
            {
                s = s.Substring(0, s.Length - 1);
                s = String.Format("-{0}", s);
            }
                

            //Management of non significant zero
            while (s[0] == '0' && s.Length> 1)
                s = s.Substring(1);


            resultlong = Convert.ToInt64(s);
            
            if (resultlong >= int.MinValue && resultlong <= int.MaxValue)
            {
                return (int)resultlong;
            }

            return 0;

        }


    }
}
