using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal class Rezervasyon  : IRezervasyon
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int KoltukNo { get; set; }
        public int UcusId { get; set; }
        public int Ucret { get; set; }

        public void RezervasyonEkle(int musteriId, int koltukNo, int ucusId, int ucret)
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            rezervasyon.Id = Bilgiler.rezervasyonId;
            rezervasyon.MusteriId = musteriId;
            rezervasyon.KoltukNo = koltukNo;
            rezervasyon.UcusId = ucusId;
            rezervasyon.Ucret = ucret;

            Bilgiler.rezervasyonId++;

            Bilgiler.rezervasyonlar.Add(rezervasyon);

            Musteri musteri = (Musteri)Bilgiler.musteriler[musteriId];
            Ucus ucus = (Ucus)Bilgiler.ucuslar[UcusId];

            Lokasyon lokasyon = new Lokasyon();

            Console.WriteLine("\nMüşteri Bilgileri: ");
            Console.WriteLine("Müşteri Adı: " + musteri.Ad);
            Console.WriteLine("Müşteri Soyadı: " + musteri.Soyad);
            Console.WriteLine("Müşteri EPosta: " + musteri.EPosta);
            Console.WriteLine("Müşteri Telefon: " + musteri.Telefon);

            Console.WriteLine("\nUçuş Bilgileri: ");
            Console.WriteLine("Uçuş Numarası: " + ucus.UcusNo);
            lokasyon = (Lokasyon)Bilgiler.lokasyonlar[ucus.KalkisLokasyonu - 1];
            Console.WriteLine("Kalkış Lokasyonu: " + lokasyon.Ulke + " " + lokasyon.Sehir + " " + lokasyon.Havalimani);
            lokasyon = (Lokasyon)Bilgiler.lokasyonlar[ucus.VarisLokasyonu - 1];
            Console.WriteLine("Varış Lokasyonu: " + lokasyon.Ulke + " " + lokasyon.Sehir + " " + lokasyon.Havalimani);
            Console.WriteLine("Uçuş Tarihi: " + ucus.UcusTarihi.ToString("dd/MM/yyyy"));
            Console.WriteLine("Koltuk Numarası: " + koltukNo);
            Console.Write("Ücret: " + ucret);
        }
    }
}
