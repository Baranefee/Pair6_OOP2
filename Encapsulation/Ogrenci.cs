using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Sınıf { get; set; }

        private DateTime _DogumTarihi;

        public DateTime DogumTarihi
        {
            get { return _DogumTarihi; }

            set
            {
                if (value >= DateTime.Now)
                {
                    Console.WriteLine("doğum tarihi bugünden büyük olamaz");
                    _DogumTarihi = DateTime.Now;
                }
                else
                {
                    _DogumTarihi = value;

                }
            }
        }


        public Ogrenci()
        {

        }
        public Ogrenci(string _Ad, string _Soyad, string _Cinsiyet, string _Sınıf, DateTime _DogumTarihi)
        {
            Ad = _Ad;
            Soyad = _Soyad;
            Cinsiyet = _Cinsiyet;
            Sınıf = _Sınıf;
            DogumTarihi = _DogumTarihi;
        }
        public void YasHesapla()
        {
            //girilen doğum tarihine göre yaşını hesaplayıp ekrana yazdır.
            int yas = (DateTime.Now.Year - _DogumTarihi.Year);
            TimeSpan yas1 = DateTime.Now - _DogumTarihi;
            
            Console.WriteLine($"yaşınız {yas}");
        }
        public void OgrenciBilgileriYaz()
        {
            Console.WriteLine($"{Cinsiyet} Öğrencimiz: {Ad} {Soyad}, {Sınıf} ında okumaktadır. {DogumTarihi.ToShortDateString()} tarihinde doğmuştur.");
        }

    }
}
