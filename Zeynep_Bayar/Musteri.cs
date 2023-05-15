using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeynep_Bayar
{
    internal class Musteri : IMusteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        public string Telefon { get; set; }
        public bool Engelli { get; set; }

        public void MusteriEkle(int id, string ad, string soyad, string email, string telefon, bool engelli)
        {
            Musteri musteri = new Musteri();

            musteri.Id = id;
            musteri.Ad = ad;
            musteri.Soyad = soyad;
            musteri.EPosta = email;
            musteri.Telefon = telefon;
            musteri.Engelli = engelli;

            Bilgiler.musteriler.Add(musteri);
        }

        public void MusteriOlustur()
        {
            while (true)
            {
                Console.WriteLine("Müşteri Bilgileri");

                Console.Write("Adınız: ");
                string ad = Console.ReadLine();

                Console.Write("Soyadınız: ");
                string soyad = Console.ReadLine();

                Console.Write("E - Postanız: ");
                string eposta = Console.ReadLine();

                string telefon;

                do
                {
                    Console.Write("Telefon Numaranızı Giriniz: ");
                    telefon = Console.ReadLine();
                } while (telefon.Length != 11 || !Int64.TryParse(telefon, out long INT64));

                string engelli;
                bool engel = false;

                do
                {
                    Console.Write("Engelli Durumunuzu Giriniz (e, h): ");
                    engelli = Console.ReadLine().ToLower();
                } while (engelli != "e" && engelli != "h");

                if (engelli == "e")
                {
                    engel = true;
                }

                MusteriEkle(Bilgiler.musteriId, ad, soyad, eposta, telefon, engel);

                string mSecim;

                do
                {
                    Console.Write("Başka Bir Müşteri Eklemek İster Misiniz? (e, h): ");
                    mSecim = Console.ReadLine().ToLower();
                } while (mSecim != "e" && mSecim != "h");

                if (mSecim == "e")
                {
                    Bilgiler.musteriId++;
                }

                if (mSecim == "h")
                {
                    break;
                }
            }
        }
    }
}
