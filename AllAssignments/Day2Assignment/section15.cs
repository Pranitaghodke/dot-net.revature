 using System;
using System.ComponentModel;

namespace Day2Assignment
{
    public class Section15()
    {
       public static void Run()
       {
  DebugExample();
       }   

       static void DebugExample()
        {
            int a=10;
            int b=5;

            int result = Add(a,b);
          Console.WriteLine("result :" + result);
          Console.WriteLine(".........................");
        }
        static int Add(int X,int Y)
        {
            return X + Y;
        }
    }
}
