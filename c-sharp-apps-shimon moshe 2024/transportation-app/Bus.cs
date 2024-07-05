using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class Bus : PublicVehicle
    {
        public int Doors { get; set; }

        // בנאי ריק
        public Bus()
        {
            MaxSpeed = 120;
        }

        // בנאי עם פרמטרים
        public Bus(int line, int id, int maxSpeed, int seats, int doors)
            : base(line, id, maxSpeed, seats)
        {
            Doors = doors;
        }

        // Override ל-UploadPassengers
        public override void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom(passengers))
            {
                base.UploadPassengers(passengers);
            }
            else
            {
                Console.WriteLine($"Rejected {passengers} passengers from the bus.");
            }
        }

        // ToString מורשה
        public override string ToString()
        {
            return base.ToString() + $", Doors {Doors}";
        }
    }

}
