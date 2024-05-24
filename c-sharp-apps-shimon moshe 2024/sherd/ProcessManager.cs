using c_sharp_apps_shimon_moshe_2024.bank_app;
using c_sharp_apps_shimon_moshe_2024.draft_app;
using c_sharp_apps_shimon_moshe_2024.sport_app;
using c_sharp_apps_shimon_moshe_2024.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.sherd
{
    internal class ProcessManager
    {
        public static void MainProcess()
        {
            while(true)
            {
                Console.WriteLine("1. bank-app");
                Console.WriteLine("2. sport-app");
                Console.WriteLine("3. draft-app");
                Console.WriteLine("4. transportation-app");
                Console.WriteLine("0. Exit");
                Console.Write("choose : ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose) 
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;

                    case 2:
                        SportAppMain.MainEntry();
                        break;

                    case 3:
                        DraftAppMain.MainEntry();
                        break;

                    case 4:
                        TransportaionAppMain.MainEntry();
                        break;

                    case 0:
                        return;

                    default: Console.WriteLine("Error!");
                        break;
                }


            }
        }
    }
}
