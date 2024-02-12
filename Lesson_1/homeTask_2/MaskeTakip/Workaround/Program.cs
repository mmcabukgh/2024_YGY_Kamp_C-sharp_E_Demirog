using Business.Concrete;
using Entities.Concrete;
using System;

// Degiskenler();
static void Degiskenler()
{
    string mesaj = "Selam";

    double tutar = 100000;
    int sayi = 100;
    bool girisYapmismi = false;

    string ad = "Mehmet";
    string soyad = "Çabuk";
    int doğumYili = 1995;
    long tcNo = 12345678901;

}

Vatandas vatandas0 = new Vatandas();

SelamVer();
SelamVer();
SelamVer1("Mehmet");
SelamVer1("Ahmet");
SelamVer1();

int sonuc = Topla();

int sonuc1 = Topla1();

int sonuc2 = Topla1(6,58);

string ogrenci1 = "mehmet";
string ogrenci2 = "kerem";
string ogrenci3 = "berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

//Diziler - Arrays - REFERANS tiplerdir. 
string[] ogrenciler = new string[3];
ogrenciler[0] = "Mehmet";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
//ogrenciler[3] = "İlkay";  //hatalı > 3 sınırını aştı

ogrenciler = new string[4];
ogrenciler[3] = "İlkay";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

//ÖNEMLİ !! Arrays - REFERANS tiplerdir. 

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

// olduğunda

sehirler2 = sehirler1;  // ve
sehirler1[0] = "Adana";  // ise

Console.WriteLine(sehirler2[0]); //ÇIKTI SONUCU NE OLUR??

//Cevap: sehirler2 ve sehirler1 Referans tipli olduklarından
//sehirler2 = sehirler1 ataması ile
//sehirler2[0] = sehirler1[0] aynı olur. Yani çıktı: Adana

int sayi1 = 10;
int sayi2 = 20;

sayi2 = sayi1;
sayi1 = 30;

// sayi2 NE OLUR???
// REFERANS değil DEĞER TİP olduğu için yeni DEĞERi alır. SONUÇ: 10

//ÖNEMLİ!!! CLASS (Nesneler) REFERANS Tiptir.

Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "Mehmet";

Vatandas vatandas2 = new Vatandas();
vatandas1.Ad = "İlkay";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//-----------****----------
//Array ların kullanımı DotNet ile yerini Generic List lere bırakmıştır.
// Jenerik Koleksiyonlar - Generic Collections

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");

foreach(string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

//*************************************************************
/* ÖDEV : Generic koleksiyon gibi davranıp Add yapabilen
 * kendi List (MyList) sınıfını yazın. 
 MyList sınıfı Kod sonunda YAZILDI!!
 */

MyList listem1 = new MyList(["Ankara Ödev", "İstanbul Ödev", "İzmir Ödev"]);

listem1.Add("Yenişehir Ödev");


//**********************************************************

Person person1 = new Person();
person1.FirstName = "ENGİN";
person1.LastName = "DEMİROĞ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 1;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



static void SelamVer()
    {
        Console.WriteLine("Merhaba");
    }

static void SelamVer1(string isim = "Noname")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla()
{
    return 5;
}
static int Topla1(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DoğumYili { get; set; }
    public long TcNo { get; set; }
}

/* ÖDEV : Generic koleksiyon gibi davranıp Add yapabilen
 * kendi List (MyList) sınıfını yazın. */


public class MyList
{
    private string[] myList;

    public MyList(string[] mylist)
    {
        myList = mylist;
        Console.WriteLine("Listenin İLK Durumu: \n");
        foreach (string el in myList)
        {
            Console.WriteLine("- " + el + "\n");
        }
    }

    public void Add(string eleman)
    {
        string[] newlist = new string[myList.Length + 1];
        for (int i = 0; i < myList.Length; i++)
        {
            newlist[i] = myList[i];
        }
        newlist[myList.Length] = eleman;
        myList = newlist;

        Console.WriteLine("Listenin Son Durumu: \n");
        foreach (string el in myList)
        {
            Console.WriteLine("- " + el + "\n");
        }
    }
}