using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //this is a commentary
            //Console.WriteLine("Hello, Kaarel!");
            Console.WriteLine("What's your name?");
            String Name;
            //read input from user
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            
        }
    }
}
