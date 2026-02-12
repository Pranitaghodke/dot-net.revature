using System;

namespace Day2Assignment
{
    public class Section8
    {
        public static void Run()
        {
            
            IsPatternExample();
            SwitchPatternExample();
        }

        static void IsPatternExample()
        {
            object o =5;
        
           if( o is int i)
            {
                Console.WriteLine(i+1);
            }

        }
        static void SwitchPatternExample()
        {
            object obj ="hello";

            string result=obj switch
            {
                null => "none",
                int  n=>$"int {n}",
                string s=> $"str({s})",
                _ =>"other"
            };
            Console.WriteLine(result);
            Console.WriteLine(".................");
        }
    }
}