using System;
using System.Collections.Generic;

namespace StringNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbersToAdd = new List<int>();
            int sum = 0;

            Console.WriteLine("Hello. Please enter some numbers separated by a comma(1,2,3,4,5....).");
            string commaN = Console.ReadLine();
            string[] commaNum = commaN.Split(',');


            for (int i = 0; i < commaNum.Length; i++)
            {

                Console.WriteLine(commaNum[i]);
                int e;

                bool result = Int32.TryParse(commaNum[i], out e );
                if (result)
                    sum = sum + e;

            }

            Console.WriteLine(sum);
        }
    }
}
