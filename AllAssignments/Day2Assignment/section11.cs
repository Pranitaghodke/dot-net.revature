using System;
using System.Collections.Generic;

namespace Day2Assignment
{
    public class Section11
    {
        public static void Run()
        {
            ArrayExample();
            ListExample();

        }

        static void ArrayExample()
        {
            int []arr=new int [3]{1,2,3};

            Console.WriteLine("array value");

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void ListExample()
        {
            var list =new List<string>{"a" , "b"};
            list.Add("c");
            foreach(var item in list)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("...............");
        }
    }
}
