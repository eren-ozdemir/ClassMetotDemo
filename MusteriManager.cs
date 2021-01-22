using System;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + ", Kaydınız Eklenmiştir.\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + ", Kaydınız Silinmiştir.\n");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Ad + ", müşteri bilgileriniz aşağıdaki gibidir.");
            Console.WriteLine("TC Kimlik Numaranız: " + musteri.Tc);
            Console.WriteLine("Telefon Numaranız: " + musteri.Telefon);
            Console.WriteLine("ID Numaranız: " + musteri.ID + "\n");

        }
    }
}
