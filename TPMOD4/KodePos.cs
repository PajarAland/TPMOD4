using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4.Kodepos
{
    internal class KodePos
    {
        public String kelurahan;
        public int kodepos;
        public List<KodePos> kodeposList = new List<KodePos>();
        public KodePos(String a = "", int k = 0)
        {
            this.kelurahan = a;
            this.kodepos = k;
        }
        public void setKodePos()
        {
            this.kodeposList.Add(new KodePos("Batununggal", 40266));
            this.kodeposList.Add(new KodePos("Kujangsar", 40287));
            this.kodeposList.Add(new KodePos("Mengger", 40267));
            this.kodeposList.Add(new KodePos("Wates", 40256));
            this.kodeposList.Add(new KodePos("Cijaura", 40287));
            this.kodeposList.Add(new KodePos("Jatisar", 40286));
            this.kodeposList.Add(new KodePos("Margasar", 40286));
            this.kodeposList.Add(new KodePos("Sekejati", 40286));
            this.kodeposList.Add(new KodePos("Kebonwaru", 40272));
            this.kodeposList.Add(new KodePos("Maleer", 40274));
            this.kodeposList.Add(new KodePos("Samoja", 40273));
        }
        public void getKodePos()
        {
            Console.WriteLine("Kelurahan\tKode Pos");
            foreach(KodePos k in this.kodeposList)
            {
                string kelPad = k.kelurahan.PadRight(15);
                Console.WriteLine(kelPad + "\t" + k.kodepos);
                Console.WriteLine();
            }
        }
    }
}
