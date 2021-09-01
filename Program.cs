using System;

namespace Enumeration
{

    class Program
    {
        class Enumeration_Demo
        {
            enum MeetingImportance {
                Trivial,
                Regular,
                Critical }


            public static void Main(string[] args)
            {
                
                MeetingImportance meet = MeetingImportance.Critical;
                int value = (int)MeetingImportance.Critical;
                


                if (meet == MeetingImportance.Critical)
                {
                    Console.WriteLine("Critical" + value);

                }

                else if (meet == MeetingImportance.Trivial)
                {
                    Console.WriteLine("Trivial" + value);
                }

                else if (meet == MeetingImportance.Regular)
                {
                    Console.WriteLine("Regular" + value);
                }
            }
        }
    }
}
//op Critical 2