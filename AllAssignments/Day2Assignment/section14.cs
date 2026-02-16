using System;
using System.Text;

namespace Day2Assignment
{
    public class Section14
    {
        public static void Run()
        {

            NamespaceExample();
        }

        static void NamespaceExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("namespace example working");


            Console.WriteLine(sb.ToString());
            Console.WriteLine("........................");
        }
    }
}