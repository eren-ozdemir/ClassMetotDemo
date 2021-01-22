using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Eren Özdemir";
            musteri1.Tc = "254362152";
            musteri1.Telefon = "5419711475";
            musteri1.ID = 100;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Gizem Özdemir";
            musteri2.Tc = "6215321010";
            musteri2.Telefon = "5419716525";
            musteri2.ID = 101;


            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Sil(musteri2);
            musteri.Listele(musteri1);
        }
    }
}
