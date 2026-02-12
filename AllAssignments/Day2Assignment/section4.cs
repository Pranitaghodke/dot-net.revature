using System;
using System.Text;

namespace Day2Assignment
{
    public class Section4
    {
        public static void Run()
        {
            
        
        StringExample();
        StringBuilderExample();
    }

    static void StringExample()
        {
           string mess="hello";
           mess +="pranita";
                               
           Console.WriteLine("string example"); 
           Console.WriteLine(mess);                   // hellopranita
        }

        static void StringBuilderExample()
        {
            StringBuilder sb =new StringBuilder("hello");
            sb.Append("pranita");

            Console.WriteLine("\nStringbuilder Example :");
            Console.WriteLine(sb.ToString());         //hellopranita

            Console.WriteLine("............................");
        }


    }
}