using System;

namespace Day2Assignment
{
    public class Section9
    {
        public static void Run()
        {
        LogicalExample();
        ComparisonExample();
        }

        static void LogicalExample()
        {
            int x=50;
            if (x>0 && x <100)
            {
                Console.WriteLine("x is in range");
            }

            bool isReady=false;
            bool hasData=false;

            if (!(isReady || hasData))
            {
                Console.WriteLine("No data available");
            }
        }

        static void ComparisonExample()
        {
            string a = "hi";
            bool eq = a == "hi";

            Console.WriteLine("Equality result: " + eq);

             Console.WriteLine("................");
        }
        
    }
}

    
