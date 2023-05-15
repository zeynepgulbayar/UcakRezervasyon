# C# Konsol Uçak Rezervasyon Sistemi

Projede 4 tane arabirim ve 5 tane sınıf kullanıldı.

### Arabirimler
* ILokasyon
* IMusteri
* IRezervasyon
* IUcus

### Sınıflar
* Bilgiler
* Lokasyon
* Musteri
* Rezervasyon
* Ucus

#### ILokasyon
* Lokasyon bilgileri için gerekli olan alanlar vardır.

#### IMusteri
* Müşteri bilgileri için gerekli olan alanlar vardır.

#### IRezervasyon
* Rezervasyon bilgileri için gerekli olan alanlar vardır.

#### IUcus
* Uçuş bilgileri için gerekli olan alanlar vardır.

#### Bilgiler
* Sınıfların kullandığı sayaçları ve listeleri barındırır.

#### Lokasyon
* LokasyonEkle ve LokasyonOlustur adında iki tane metod vardır.
* LokasyonEkle => ArrayListe veri ekler.
* LokasyonOlustur => Metin belgesindeki kayıtları okur ve istenilen formata getirerek LokasyonEkleye yollar.

#### Musteri
* MusteriEkle ve MusteriOlustur adında iki tane metod vardır.
* MusteriEkle => ArrayListe veri ekler.
* MusteriOlustur => Müşteri bilgilerini kullanıcıdan alır ve istenilen formata getirerek MusteriEkleye yollar.

#### Rezervasyon
* RezervasyonEkle adında bir tane metod vardır.
* RezervasyonEkle => ArrayListe veri ekler ve tüm rezervasyon bilgilerini ekrana yazdırır.

#### Ucus
* UcusEkle adında bir tane metod vardır.
* UcusEkle => ArrayListe veri ekler.

### NOT

* Uygulamanın çalışması için bin/Debug/ dosya dizininde lokasyon.txt belgesi olmalıdır.
* Müşteri bilgilerini giriniz ve müşteri seçiniz. Sonra kalkış yerini ve ardından varış yerini seçiniz. Kalkış ve varış yeri aynı olamaz. Lokasyondan sonra tarih seçiniz. Tüm bilgiler ekrana yazdırılacaktır.