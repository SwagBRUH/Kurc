using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kurc
{
    class typs
    {
        string naz_vid;
        string edin_iz;
        string word_rec;
        DateTime data_rec = new DateTime();
        public typs() { }
        ~typs() { }
        public void setnaz_vid(string naz_vid)
        {
            this.naz_vid = naz_vid;
        }
        public void setedin_iz(string edin_iz)
        {
            this.edin_iz = edin_iz ;
        }
        public void setword_rec(string word_rec)
        {
            this.word_rec = word_rec;
        }
        public void setdata_rec(DateTime data_rec)
        {
            this.data_rec = data_rec;
        }
        public void Print()
        {
            Console.WriteLine("Название вида спорта:"+naz_vid);
            Console.WriteLine("Единица измерения:" +edin_iz);
            Console.WriteLine("Мировой рекорд:"+word_rec);
            Console.WriteLine("Дата рекорда:"+data_rec);
        }
        public void Print(StreamWriter file)
        {
            file.WriteLine("Название вида спорта:" + naz_vid);
            file.WriteLine("Единица измерения:" + edin_iz);
            file.WriteLine("Мировой рекорд:" + word_rec);
           file.WriteLine("Дата рекорда:" + data_rec);
        }


    }
}
