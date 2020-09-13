using System;

namespace _3333333
{
    class Prime
    {
        public static void Main()
        {
            int []aa = new int[98];
            bool[] bb = new bool[98];
            for(int i =0; i < aa.Length; i++) { aa[i] = i + 2; }

            int k = 2;
            while (true)
            {
                for (int i = 0; i < aa.Length; i++) 
                    if (aa[i] % k == 0 )bb[i] = true;

                if (k * k > aa.Length - 1)  //如果现在这个序列中最大数小于最后一个标出的素数的平方，
                    break;                          //那么剩下的序列中所有的数都是素数

                for (int i = 0; i < aa.Length; i++) 
                    if (i > k && bb[i] == false)
                    {
                        k = i;
                        break;
                    }
            }

            for (int i = 0; i < aa.Length; i++)
                if (bb[i] == false) Console.WriteLine(aa[i]+"is a prime number");
        }
    }


}
