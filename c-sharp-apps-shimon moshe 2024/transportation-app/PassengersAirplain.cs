using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class PassengersAirplane : PublicVehicle
    {
        public int EnginesNum { get; set; }
        public int WingLength { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        // בנאי עם פרמטרים
        public PassengersAirplane(int line, int id, int enginesNum, int wingLength, int rows, int columns)
            : base(line, id, 1000, rows * columns - 7)
        {
            EnginesNum = enginesNum;
            WingLength = wingLength;
            Rows = rows;
            Columns = columns;
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
                Console.WriteLine($"Rejected {passengers} passengers from the airplane.");
            }
        }

        // ToString מורשה
        public override string ToString()
        {
            return base.ToString() + $", Engines {EnginesNum}, Wing Length {WingLength}, Rows {Rows}, Columns {Columns}";
        }
    }

}
