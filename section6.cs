using System;
namespace Day2Assignment
{
    public class Section6
    {
        public static void Run()
        {
            NullableExample();

        }

        static void NullableExample()
        {
            int? n=null;
            int  value =n ?? -1;

            Console.WriteLine("value :" + value);

            string s =null;
            int? length = s?.Length;

            Console.WriteLine("length :" + length);
 Console.WriteLine("....................................");
        }
    }
}