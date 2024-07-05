using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class Crone
    {
        public int Rows { get; }
        public int Columns { get; }

        // בנאי עם פרמטרים
        public Crone(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        // בנאי העתקה
        public Crone(Crone crone)
        {
            Rows = crone.Rows;
            Columns = crone.Columns;
        }

        // מתודה GetSeats
        public int GetSeats()
        {
            return Rows * Columns;
        }

        // מתודה GetExtras
        public int GetExtras()
        {
            return Rows * 2; // 2 extras per row
        }
    }

}
