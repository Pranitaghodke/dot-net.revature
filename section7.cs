using System;


namespace Day2Assignment
{
    public class Section7
    {
        public static void Run()
        {
            ifElseExample();
            SwitchExpressionExample();
        }

        static void ifElseExample()
        {
            int x =5;

            if(x>0)
            Console.WriteLine("pos");

            else if(x<0)
            Console.WriteLine("neg");

            else 
            Console.WriteLine("zero");   
        }
        static void SwitchExpressionExample()
        {
            int x=5;

            var result=x switch
            {
                0 => "zero", >0 => "positive",< 0 =>"negative "
            };
            Console.WriteLine(result);
            Console.WriteLine("................");

        }
        
        
    }
}
