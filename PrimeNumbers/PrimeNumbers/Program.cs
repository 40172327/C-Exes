using System;

namespace PrimeNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please tipe a number between 1 and 10000");

            int intTemp = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= intTemp; i++)
            {
                for (int e = 2; e <= intTemp; e++)
                {
                    if(i!=e && i%e == 0)
                    {
                        isPrime = false;
                        break; 
                    }

                }
                if(isPrime){
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();


        }
    }
}
