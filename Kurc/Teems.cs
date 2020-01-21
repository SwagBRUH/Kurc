using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurc
{
    class Teems
    {
        string name_t;
        string fio_t;
        string sity;
        string naim_sar;
        string mesto_prov;
        DateTime data_prov = new DateTime();

        public Teems() { }
        ~Teems() { }

        public void setname_t(string name_t)
        {
            this.name_t = name_t;
        }
        public void setfio_t(string fio_t)
        {
            this.fio_t = fio_t;
        }
        public void setsity(string sity)
        {
            this.sity = sity;
        }
        public void setnaim_sar(string naim_sar)
        {
            this.naim_sar = naim_sar;
        }
        public void setmest_prov(string mesto_prov)
        {
            this.mesto_prov = mesto_prov;
        }
        public void setdata_prov(DateTime data_prov)
        {
            this.data_prov= data_prov;
        }
        public void Print()
        {
            Console.WriteLine("Название команды: " + name_t);
            Console.WriteLine("ФИО тренера: " + fio_t);
            Console.WriteLine("Город: " + sity);
            Console.WriteLine("Наименование соревнования: " + naim_sar);
            Console.WriteLine("Дата проведения : " + data_prov);
            Console.WriteLine("Место проведения: " + mesto_prov);
        }
        public void Printf(StreamWriter file)
        {
            file.WriteLine("Название команды: " + name_t);
            file.WriteLine("ФИО тренера: " + fio_t);
            file.WriteLine("Город: " + sity);
            file.WriteLine("Наименование соревнования: " + naim_sar);
            file.WriteLine("Дата проведения : " + data_prov);
            file.WriteLine("Место проведения: " + mesto_prov);
        }






    }
}
