using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4.Kodepost
{
    internal class KodePost
    {
        public enum StateKelurahan {Cibaduyut, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};
        public enum StateKodePos {k40221, k40287, k40267, k40256, j40287, k40286, e40286, f40286, k40272, k40274, k40273}

        public void getKodepos()
        {
            Console.WriteLine("Kelurahan\tKode Pos");
            for (int i = 0; i < 11; i++)
            {
                string kelPad = ((StateKelurahan)i).ToString().PadRight(15);
                Console.Write(kelPad + "\t" + ((StateKodePos)i).ToString().Substring(1));
                Console.WriteLine();
            }
        }
    }
}
