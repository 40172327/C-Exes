using System;
using System.Collections.Generic;

namespace HouseArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> area = new List<int>();
            List<String> room = new List<String>();
            string roomName = "";


            do
            {
                Console.WriteLine("Please enter the room you are wanting to measure");
                roomName = Console.ReadLine();

                room.Add(roomName);

                Console.WriteLine("Please enter the lenght");
                int lenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the width");
                int width = Convert.ToInt32(Console.ReadLine());
                int totArea = 0;

                int roomArea = lenght * width;
                area.Add(roomArea);

                if (roomName == "stop")
                {
                    Console.WriteLine(" Room " + " Size ");
                    for (int i = 0; i < area.Count; i++)
                    {
                        

                            Console.WriteLine(" " + room[i] + "  " + area[i]);

                        
                    }
                    for (int i = 0; i < area.Count; i++)
                    {
                        totArea = totArea + area[i];
                    }
                    Console.WriteLine("The are of the house is: " + totArea);
                }
            } while (roomName!= "stop");
        }
    }
}