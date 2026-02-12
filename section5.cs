using  System;
using System.Collections.Generic;

namespace Day2Assignment
{
    public class Section5
    {
        public static void Run()
        {
            VarExample();

        }

        static  void VarExample()
        {
            var x=10;     // int
            var name ="Pranita";    //string 
            var list =new List<string>();

            list.Add("A");
            list.Add("B");

            Console.WriteLine(x);
            Console.WriteLine(name);

            foreach(var item in list)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("...............");

        }

    }
}
