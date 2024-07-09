using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class Crone
    {
        private int rows;
        private int columns;

        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public Crone(Crone crone)
        {
            this.rows = crone.rows;
            this.columns = crone.columns;
        }

        public int GetSeats()
        {
            return rows * columns;
        }

        public int GetExtras()
        {
            return rows * 2;
        }
    }
}
