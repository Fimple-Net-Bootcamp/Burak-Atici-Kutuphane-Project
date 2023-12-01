using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProject
{
    public class Uyeler : IYazdirilabilir
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int ÜyelikNumarası { get; set; }
        public List<Kitap> AldığıKitaplar { get; set; }

        public void Yazdır()
        {
            Console.WriteLine($"Üye Adı: {Ad}, Soyadı: {Soyad}, Üyelik Numarası: {ÜyelikNumarası}");

        }
        public void AldığıKitaplarıGoruntule()
        {
            if (AldığıKitaplar.Count == 0)
            {
                Console.WriteLine($"{Ad} {Soyad} adlı üyenin aldığı kitap bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine($"{Ad} {Soyad} adlı üyenin aldığı kitaplar:");
                foreach (var kitap in AldığıKitaplar)
                {
                    Console.WriteLine($"Kitap ID: {kitap.KitapID}, Ad: {kitap.Ad}, Yazar: {kitap.Yazar}, Yayın Yılı: {kitap.YayınYılı}");
                }
            }
        }

    }

}
