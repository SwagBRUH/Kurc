using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
fios
godr
tem
sporraz
vid sporta
lichrecord

    */


namespace Kurc
{
    class Sportsmancs
    {
        string fio_s;
        int god_r;
        string team;
        string sport_raz;
        string lich_record;
        string vid_S;
        
        public Sportsmancs() { }
        ~Sportsmancs() { }
        public void setvid_S(string vid_S)
        {
            this.vid_S = vid_S;
        }
        public void setfio_s(string fio_s)
        {
            this.fio_s = fio_s;
        }
        public int getgod_r() { return god_r; }
        public void setgod_r(int god_r)
        {
            this.god_r = god_r;
        }
        public void setteam(string team)
        {
            this.team = team;
        }
        public void setsport_raz(string sport_raz)
        {
            this.sport_raz = sport_raz;
        }
        public void setlich_record(string lich_record)
        {
            this.lich_record = lich_record;
        }
        public void Print()
        {
            Console.WriteLine("Ф.И.О:" + fio_s);
            Console.WriteLine("Год рождения:" + god_r);
            Console.WriteLine("Команд:" + team);
            Console.WriteLine("Спортивный разряд:" + sport_raz);
            Console.WriteLine("Вид спорта:" + vid_S);
            Console.WriteLine("Личный рекорд:" + lich_record);
          
        }
        public void Printf(StreamWriter file)
        {
            file.WriteLine("Ф.И.О:" + fio_s);
            file.WriteLine("Год рождения:" + god_r);
            file.WriteLine("Команд:" + team);
            file.WriteLine("Спортивный разряд:" + sport_raz);
            file.WriteLine("Вид спорта:" + vid_S);
            file.WriteLine("Личный рекорд:" + lich_record);

        }
    }
}
