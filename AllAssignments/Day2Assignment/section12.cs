using System;
using System.Collections.Generic;

namespace Day2Assignment
{
    public class Section12
    {
        public static void Run()
        {
            ForLoopExample();

            ForeachExample();

            WhileExample();

            DoWhileExample();

        }

        static void ForLoopExample()
        {
            Console.WriteLine ("for loop :");
             for (int i=0; i<3; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ForeachExample()
        {
            Console.WriteLine("foreach loop :");
            var list =new List<int>{1,2,3};
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
               static void WhileExample()
        {
            Console.WriteLine("while loop :");
            int i =0;
            while (i<3)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void DoWhileExample()
        {
            Console.WriteLine("do while loop :");
            int i =0;

            do
            {
                Console.WriteLine(i);
                i++;

            }while(i<3);
            Console.WriteLine("................");
        }

    }
}