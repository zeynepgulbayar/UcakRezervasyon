using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal class Lokasyon : ILokasyon
    {
        public int Id { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havalimani { get; set; }

        public string dosyaYolu = "lokasyon.txt";

        public void LokasyonEkle(int id, string ulke, string sehir, string havalimani)
        {
            Lokasyon lokasyon = new Lokasyon();

            lokasyon.Id = id;
            lokasyon.Ulke = ulke;
            lokasyon.Sehir = sehir;
            lokasyon.Havalimani = havalimani;

            Bilgiler.lokasyonlar.Add(lokasyon);
        }

        public void LokasyonOlustur()
        {
            if (File.Exists(dosyaYolu))
            {
                StreamReader reader = new StreamReader(dosyaYolu);

                while (true)
                {
                    string[] lokasyonDizi;

                    string satir = reader.ReadLine();

                    if (satir != null)
                    {
                        lokasyonDizi = satir.Split(',');
                        LokasyonEkle(Bilgiler.lokasyonId, lokasyonDizi[0], lokasyonDizi[1], lokasyonDizi[2]);
                        Bilgiler.lokasyonId++;
                    }
                    else
                        break;
                }
            }
        }
    }
}
