// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");


//ogrenci clasıı oluştur parametreli ve parametresiz
//ad soyad cinsiyet,doğum tarihi
//ogrenciBilgileriniYaz metodu
Ogrenci ogrenci = new Ogrenci("Baran", "efe", "erkek", "5A", new DateTime(1998, 11, 06));
ogrenci.OgrenciBilgileriYaz();
ogrenci.YasHesapla();
Console.ReadKey();