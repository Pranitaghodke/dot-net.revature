using System;
using System.Threading.Tasks;

namespace Day2Assignment
{

public class Section2
{
    public static void Run()
    {
     TraditionalMainExample();
     TopLevelExample();
     AsyncMainExample().Wait();

    }
    static void TraditionalMainExample()
    {
      // example1 traditional main logic
        string[]args =new string[]{ "demo argument"};
        Console.WriteLine(args.Length > 0 ? args[0] : "no args");

    }

    static void TopLevelExample()
    {
    Console.WriteLine("top-level app started");
    }

static async Task AsyncMainExample()
   {
    await Task.Delay(100);
    Console.WriteLine("async main execute");
    Console.WriteLine(".........................");
   }
}
}
