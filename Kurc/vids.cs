using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurc
{
    class vids
    {
        string naim_sar;
        string mesto_prov;
        DateTime data_prov = new DateTime();
        public vids() { }
        ~vids() { }
        public void setnaim_sar(string naim_sar)
        {
            this.naim_sar = naim_sar;
        }
        public void setmesto_prov(string mesto_prov)
        {
            this.mesto_prov = mesto_prov;
        }
        public void setdata_prov(DateTime data_prov)
        {
            this.data_prov = data_prov;
        }
        public void Print()
        {
            Console.WriteLine("Наименование соревнования: " + naim_sar);
            Console.WriteLine("Дата проведения : " + data_prov);
            Console.WriteLine("Место проведения: " + mesto_prov);
        }
        public void Printf(StreamWriter file)
        {
            file.WriteLine("Наименование соревнования: " + naim_sar);
           file.WriteLine("Дата проведения : " + data_prov);
            file.WriteLine("Место проведения: " + mesto_prov);
        }
        }
}
