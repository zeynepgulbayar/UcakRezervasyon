using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriOlustur();

            int Msayac = 1;

            foreach (Musteri item in Bilgiler.musteriler)
            {
                Console.WriteLine(Msayac + ") " + item.Ad + " " + item.Soyad);
                Msayac++;
            }

            int Msecim = 0;

            do
            {
                Console.Write("Müşteri Seçiniz: ");
                try
                {
                    Msecim = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(Msecim > 0 && Msecim < Bilgiler.musteriler.Count + 1));

            Lokasyon lokasyon = new Lokasyon();
            lokasyon.LokasyonOlustur();

            int KLsayac = 1;

            Console.WriteLine("Lokasyonlar: ");

            foreach (Lokasyon item in Bilgiler.lokasyonlar)
            {
                Console.WriteLine(KLsayac + ") " + item.Ulke + " " + item.Sehir + " " + item.Havalimani);
                KLsayac++;
            }

            int KLsecim = 0;

            do
            {
                Console.Write("Kalkış Lokasyonu Seçiniz: ");
                try
                {
                    KLsecim = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(KLsecim > 0 && KLsecim < Bilgiler.lokasyonlar.Count + 1));

            bool LKontrol = false;

            int VLsayac = 1;

            Console.WriteLine("Lokasyonlar: ");

            foreach (Lokasyon item in Bilgiler.lokasyonlar)
            {
                Console.WriteLine(VLsayac + ") " + item.Ulke + " " + item.Sehir + " " + item.Havalimani);
                VLsayac++;
            }

            int VLsecim = 0;

            do
            {
                Console.Write("Varış Lokasyonu Seçiniz: ");
                try
                {
                    VLsecim = Convert.ToInt32(Console.ReadLine());
                }
                catch { }

                if (VLsecim > 0 && VLsecim < Bilgiler.lokasyonlar.Count + 1)
                {
                    if (Bilgiler.lokasyonlar[KLsecim - 1] == Bilgiler.lokasyonlar[VLsecim - 1])
                    {
                        Console.WriteLine("Seçimler Aynı Olamaz.");
                    }
                    else
                    {
                        LKontrol = true;
                    }
                }
            } while (!(VLsecim > 0 && VLsecim < Bilgiler.lokasyonlar.Count + 1 && LKontrol));

            DateTime tarih = DateTime.Now;
            DateTime[] tarihler = new DateTime[10];

            for (int i = 0; i < tarihler.Length; i++)
            {
                tarihler[i] = tarih.AddDays(i + 1);
            }

            for (int sayac = 1; sayac <= tarihler.Length; sayac++)
            {
                Console.WriteLine(sayac + ") " + tarihler[sayac - 1].ToString("dd/MM/yyyy"));
            }

            int TSecim = 0;

            do
            {
                Console.Write("Tarih Seçiniz: ");
                try
                {
                    TSecim = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(TSecim > 0 && TSecim < tarihler.Length + 1) || !int.TryParse(TSecim.ToString(), out TSecim));

            Random random = new Random();
            string ucusNo = Msecim + "UN - " + random.Next(0, 100).ToString();

            Ucus ucus = new Ucus();
            ucus.UcusEkle(ucusNo, KLsecim, VLsecim, tarihler[TSecim - 1]);
            int ucusId = Bilgiler.ucusId;

            int koltukNo = random.Next(1, 200);

            int ucret = random.Next(500, 5000);
            if (musteri.Engelli)
                ucret = (int)(ucret * 0.5);

            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.RezervasyonEkle(Msecim - 1, koltukNo, ucusId, ucret);

            Console.ReadKey();
        }
    }
}
