using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal class Ucus : IUcus
    {
        public int Id { get; set; }
        public string UcusNo { get; set; }
        public int KalkisLokasyonu { get; set; }
        public int VarisLokasyonu { get; set; }
        public DateTime UcusTarihi { get; set; }

        public void UcusEkle(string ucusNo, int kalkisLokasyonu, int varisLokasyonu, DateTime ucusTarihi)
        {
            Ucus ucus = new Ucus();

            ucus.Id = Bilgiler.ucusId;
            ucus.UcusNo = ucusNo;
            ucus.KalkisLokasyonu = kalkisLokasyonu;
            ucus.VarisLokasyonu = varisLokasyonu;
            ucus.UcusTarihi = ucusTarihi;

            Bilgiler.ucusId++;

            Bilgiler.ucuslar.Add(ucus);
        }
    }
}
