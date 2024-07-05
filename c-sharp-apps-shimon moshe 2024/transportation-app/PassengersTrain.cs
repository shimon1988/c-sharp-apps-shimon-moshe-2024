using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone crone;
        public int CronesAmount { get; set; }

        // בנאי עם פרמטרים
        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount)
            : base(line, id, maxSpeed, crone.GetSeats() * cronesAmount + crone.GetExtras())
        {
            this.crone = crone;
            CronesAmount = cronesAmount;
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
                Console.WriteLine($"Rejected {passengers} passengers from the train.");
            }
        }

        // ToString מורשה
        public override string ToString()
        {
            return base.ToString() + $", Crone Seats {crone.GetSeats()}, Crones Amount {CronesAmount}";
        }
    }

}
