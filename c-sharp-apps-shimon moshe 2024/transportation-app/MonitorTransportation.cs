using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class MonitorTransportation
    {
        // מתודה Test1
        public void Test1()
        {
            // כאן תישאר בדיקת המטלה שתועבר במהלך הבדיקה
        }

        // מתודה MyTest
        public static void MyTest()
        {
            PublicVehicle[] vehicles = new PublicVehicle[]
            {
            new Bus(1, 101, 120, 50, 2),
            new PassengersTrain(2, 202, 300, new Crone(10, 5), 5),
            new PassengersAirplane(3, 303, 4, 30, 10, 6)
                // Add more vehicles as needed
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                vehicle.UploadPassengers(20);
                vehicle.UploadPassengers(30);
                Console.WriteLine(vehicle);
                Console.WriteLine();
            }
        }

        // מתודה CountPlains
        public int CountPlains(PublicVehicle[] vehicles)
        {
            int count = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle is PassengersAirplane)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
