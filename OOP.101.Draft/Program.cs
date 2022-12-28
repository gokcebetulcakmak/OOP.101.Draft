using System;
using OOP._101.Draft;

using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)

    {
        //Sıra geldi tanımlanmış class dan bir örnek - instance- nesne yaratmaya
        //<Sınıf adı> <Nesne adı> = new <Sınıf adı>

        //Parametrik Constructor Örneği
        new ClassHome(234); //234 değeri class a geçilecek olan parametre değeridir.
        Console.WriteLine("Overload Constructor\n");
        // Overload Constructor Örneği
        new ClassHomeOL(); //class çalış ama parametresiz
        new ClassHomeOL(675); // tek parametreli ctor
        new ClassHomeOL(986, "WallStreet"); // çift parametrreli ctor




        //CarGallery carGallery = new CarGallery(); // Nesnem tanımlanmış olan sınıftan kendini örnekledi(İnstance aldı).
        ////Nesnemizin özelliklerine ulaşalım.
        //carGallery.Brand = "Mercedes";
        //carGallery.Model = "C200";
        //carGallery.Colour = "Lacivert";


        //Console.WriteLine("Arabanın Markası : " + carGallery.Brand + "\n" + "Modeli : " + carGallery.Model + "\nRengi : " + carGallery.Colour);

        //Console.WriteLine(carGallery.Price.ToString());
        //Console.ReadKey();
        //Ogrenciler ogrenciler = new Ogrenciler();
        //ogrenciler.OgrenciAdi = "Gökçe Betül";
        //ogrenciler.OgrenciSoyadi = " ÇAKMAK";
        //ogrenciler.Cinsiyet = 'K';
        //ogrenciler.Yasi = 26;
        //ogrenciler.Sinifi = "13A";
        //Console.WriteLine("Öğrenci Adı ve Soyadı : " + ogrenciler.OgrenciAdi + ogrenciler.OgrenciSoyadi + "\nÖğrencinin Cinsiyeti : " + ogrenciler.Cinsiyet + "\nÖğrencinin Yaşı : " + ogrenciler.Yasi + "\nÖğrencinin Sınıfı : " + ogrenciler.Sinifi );


        // Benim bir araba galerim var. Galerimde arabalar var..
        //public class CarGallery // CarGallery isminde bir class tanımlanıyor.
        //{
        //    public string Brand { get; set; } //marka
        //    public string Model { get; set; } // model
        //    public string MClass{ get; set; } // Sınıf
        //    public int MPover { get; set; } // Motor gücü
        //    public int MVolume { get; set; } // Motor Hacmi
        //    public string MSerial { get; set; } // Motor seri no
        //    public char GasType { get; set; } // Yakıt türü
        //    public char GearType { get; set; } // Vites Türü
        //    public string CaseType { get; set; } // Kasa tipi
        //    public int ProducedYear { get; set; } // Üretildiği yıl
        //    public string Colour { get; set; } //Renk bilgisi
        //    public int Price = 100000; // Fiyatı / Default değer atadım.

        //}
        //Bir sınıf öğrenci adı, soyadı, cinsiyeti, yaşı,sınıfı. Ekrana öğrencinin özellikleri yazdır.
        //public class Ogrenciler
        //{
        //    public string OgrenciAdi { get; set; }
        //    public string OgrenciSoyadi { get; set; }
        //    public char Cinsiyet { get; set; }
        //    public string Sinifi { get; set; }
        //    public int Yasi { get; set; }
        Console.ReadKey();
    }
}