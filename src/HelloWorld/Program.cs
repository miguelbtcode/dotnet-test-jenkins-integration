using System;

namespace HelloWorld
{
    public class Program
    {
        public static string GetGreeting()
        {
            return "Hello World!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting());
        }
    }
}
