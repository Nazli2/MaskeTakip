//Degiskenler();



using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas = new Vatandas();





Selamver(isim: "Nazlı");
Selamver(isim: "Mustafa");

int sonuc = Topla(26, 47);


//Diziler / Arrays

string ogrenci1 = "Nazlı";
string ogrenci2 = "Mustafa";
string ogrenci3 = "İpek";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Nazlı";
ogrenciler[1] = "Mustafa";
ogrenciler[2] = "İpek";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] {"Bilecik", "Eskişehir", "Mersin"};
string[] sehirler2 = new[] { "Ankara", "İzmir", "Antalya" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "MUSTAFA";
person1.LastName = "KAVUŞDU";
person1.DateOfBirthYear = 1977;
person1.NationalIdentity = 123;


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> {"Ankara", "İstanbul", "İzmir"};
yeniSehirler1.Add("Bilecik");
foreach(string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
 
Console.ReadLine();

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000; //db den gelir
    int savi = 100;
    bool girisYapmisMi = false;


    string ad = "Nazlı";
    string soyadi = "Şahin";
    int dogumYili = 1998;
    long tcNo = 12345678910;

    Console.WriteLine(mesaj);

    Console.WriteLine(tutar * 1.18);

    

    Console.ReadLine();
}

static void Selamver(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1=5, int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}

//pascal casing 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}







