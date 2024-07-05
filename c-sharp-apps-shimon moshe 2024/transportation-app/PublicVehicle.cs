using System;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class PublicVehicle
    {
        // תכונות
        public int Line { get; set; }
        public int ID { get; set; }
        private int maxSpeed;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = Math.Min(value, 40); }
        }
        public int Seats { get; set; }

        // בנאי ריק
        public PublicVehicle()
        {
        }

        // בנאי עם פרמטרים
        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            Line = line;
            ID = id;
            MaxSpeed = maxSpeed;
            Seats = seats;
        }

        // מתודה CalculateHasRoom
        public bool CalculateHasRoom(int passengers)
        {
            return passengers <= Seats;
        }

        // מתודה UploadPassengers
        public virtual void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom(passengers))
            {
                Seats -= passengers;
                Console.WriteLine($"Uploaded {passengers} passengers to the vehicle.");
            }
            else
            {
                Console.WriteLine($"Rejected {passengers} passengers due to lack of space.");
            }
        }

        // ToString ממומש
        public override string ToString()
        {
            return $"PublicVehicle: Line {Line}, ID {ID}, MaxSpeed {MaxSpeed}, Seats {Seats}";
        }
    }

}
