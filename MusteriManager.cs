using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Eklendi:  "+ musteri.Adi);
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinme işlemi Yapıldı  "+ musteri.Adi);
        
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi   " + musteri.Adi);

        }




    }

}
