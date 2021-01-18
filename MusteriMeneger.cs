using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriMeneger
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı Eklendi.."+musteri.Adi) ;
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı Silindi.");
        }
    }
}
