using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.transportation_app
{
    public class TransportationAppMain
    {
        public static void MainEntry()
        {
            Console.WriteLine("TransportationApp");
            MonitorTransportation m = new MonitorTransportation();
            m.Test1();

        }
    }
}
