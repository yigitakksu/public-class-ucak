using System;

public class Ucak
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public string SeriNo { get; set; }
    public int KoltukKapasitesi { get; set; }

    public Ucak(string model, string marka, string seriNo, int koltukKapasitesi)
    {
        Model = model;
        Marka = marka;
        SeriNo = seriNo;
        KoltukKapasitesi = koltukKapasitesi;
    }
}

public enum Durum
{
    Aktif,
    Pasif
}

public class Lokasyon
{
    public string Ulke { get; set; }
    public string Sehir { get; set; }
    public string Havaalani { get; set; }
    public Durum Durum { get; set; }

    public Lokasyon(string ulke, string sehir, string havaalani, Durum durum)
    {
        Ulke = ulke;
        Sehir = sehir;
        Havaalani = havaalani;
        Durum = durum;
    }
}

public class Rezervasyon
{
    public int Id { get; set; }
    public DateTime Tarih { get; set; }
    public Ucak Ucak { get; set; }
    public Lokasyon Nereden { get; set; }
    public Lokasyon Nereye { get; set; }
    public byte KoltukSayisi { get; set; }
    public bool Onay { get; set; }

    public Rezervasyon(int id, DateTime tarih, Ucak ucak, Lokasyon nereden, Lokasyon nereye, byte koltukSayisi, bool onay = false)
    {
        Id = id;
        Tarih = tarih;
        Ucak = ucak;
        Nereden = nereden;
        Nereye = nereye;
        KoltukSayisi = koltukSayisi;
        Onay = onay;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Ucak ucak = new Ucak("Boeing 747", "Boeing", "123ABC", 400);
        Lokasyon nereden = new Lokasyon("Türkiye", "İstanbul", "Atatürk Havalimanı", Durum.Aktif);
        Lokasyon nereye = new Lokasyon("ABD", "New York", "John F. Kennedy Havalimanı", Durum.Aktif);
        DateTime tarih = new DateTime(2022, 3, 15);
        byte koltukSayisi = 2;
        Rezervasyon rezervasyon = new Rezervasyon(1, tarih, ucak, nereden, nereye, koltukSayisi);

        Console.WriteLine($"Rezervasyon ID: {rezervasyon.Id}");
        Console.WriteLine($"Tarih: {rezervasyon.Tarih}");
        Console.WriteLine($"Uçak: {rezervasyon.Ucak.Marka} {rezervasyon.Ucak.Model} ({rezervasyon.Ucak.SeriNo})");
        Console.WriteLine($"Nereden: {rezervasyon.Nereden.Havaalani}, {rezervasyon.Nereden.Sehir}, {rezervasyon.Nereden.Ulke}");
        Console.WriteLine($"Nereye: {rezervasyon.Nereye.Havaalani}, {rezervasyon.Nereye.Sehir}, {rezervasyon.Nereye.Ulke}");
        Console.WriteLine($"Koltuk Sayısı: {rezervasyon.KoltukSayisi}");
        Console.WriteLine($"Rezervasyon Onayı: {rezervasyon.Onay}");
    }
}