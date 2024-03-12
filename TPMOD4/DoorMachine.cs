using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4.Door
{
    internal class DoorMachine
    {
        public enum StateKeys {Terbuka, Tertutup, Terkunci, Exit};
        public enum StateKunci {Kunci, Tidak_Kunci};

        public void run()
        {
            StateKeys defaults = StateKeys.Terkunci;
            String masukanPerintah = "terbuka";
            while(defaults != StateKeys.Exit)
            {
                switch (defaults)
                {
                    case StateKeys.Terbuka:
                        Console.WriteLine("Pintu Terbuka");
                        break;
                    case StateKeys.Terkunci:
                        Console.WriteLine("Pintu Terkunci");
                        break;
                    case StateKeys.Exit:
                        Console.WriteLine("Keluar");
                        break;
                }
                Console.WriteLine("Masukan Perintah: ");
                masukanPerintah = Console.ReadLine();

                if(masukanPerintah == "Buka Pintu" || masukanPerintah == "Buka")
                {
                    if(defaults == StateKeys.Terkunci)
                    {
                        defaults = StateKeys.Terbuka;
                    }
                    else
                    {
                        Console.WriteLine("Tidak Terkunci");
                    }
                }
                else if(masukanPerintah == "Kunci Pintu" || masukanPerintah == "Kunci")
                {
                    if(defaults == StateKeys.Terbuka)
                    {
                        defaults = StateKeys.Terkunci;
                    }
                    else
                    {
                        Console.WriteLine("Terkunci");
                    }
                }
                else if(masukanPerintah == "Exit" || masukanPerintah == "EXIT")
                {
                    defaults = StateKeys.Exit;
                }
                else
                {
                    Console.WriteLine("Unknown masukanPerintah");
                }
            }
        }
    }
}
