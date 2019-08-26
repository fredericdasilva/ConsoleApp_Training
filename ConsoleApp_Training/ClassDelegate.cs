using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Training
{

    class ClassDelegate
    {

        public delegate void MyDelegate(string message);

        public ClassDelegate()
        {
            MyDelegate myDelegate1 = Method1;
            MyDelegate myDelegate2 = Method2;

            myDelegate1("toto");
            myDelegate1("tata");

            myDelegate2("toto");
            myDelegate2("tata");
        }


        public static void Method1(string argStr)
        {
            Console.WriteLine(String.Format("{0} from method 1", argStr));
        }

        public static void Method2(string argStr)
        {
            Console.WriteLine(String.Format("{0} from method 2", argStr));
        }


    }

   
}
