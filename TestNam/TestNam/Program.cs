using System;

namespace TestNam
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please type you name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Please enter to exit");
            Console.ReadLine();
        }
    }
}
