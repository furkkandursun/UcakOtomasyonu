//Console.BackgroundColor = ConsoleColor.Gray;
//Console.ForegroundColor = ConsoleColor.Red;

const string txt = "İyı günler dileriz bizi tercih ettiğiniz için teşekkür ederiz...";

Console.WriteLine("");
Console.WriteLine("************************************************************************************************************************************************\n");
Console.WriteLine("                                                              UÇUŞ LİSTESİ                                                                      \n");
Console.WriteLine("**   1- Sabiha Gökçen Havalimanı(SAW) - Trabzon Havalimanı(TZX)       **   2- İstanbul Havalimanı(IST) - Liverpool Merkez Tren İstasyonu(LXC)   \n");
Console.WriteLine("**   3- Mardin Havalimanı - İzmir Havalimanı(ADB)                     **   4- Ankara Esenboğa Havalimanı(ESB) - Frankfurt Havalimanı(FRA)       \n");
Console.WriteLine("**   5- Denizli Çardak Havalimanı - Kars Harakani Havalimanı(TZX)     **   6- Zürih Kloten Havalimanı(ZRH) - New York Havalimanı(EWR)           \n");
Console.WriteLine("**   7- Hasan Polatkan Havalimanı(AOE) - Yüksekova Havalimanı(YKO)    **   8- Napoli Havalimanı(NAP) - Budapeşte Havalimanı(BUD)                \n");
Console.WriteLine("**   9- İstanbul Havalimanı(IST) - Adana Havalimanı(ADA)              **   10-Manchester Havalimanı(MAN) - Newcastle Havalimanı(NCL)            \n");
Console.WriteLine("**   11-İzmir Havalimanı(SAW) - Sabiha Gökçen Havalimanı(ADB)         **   12-Sofya Havalimanı(SOF) - Dalaman Havalimanı(DLM)                   \n");
Console.WriteLine("**   13-Trabzon Havalimanı(TZX) - Sabiha Gökçen Havalimanı(SAW)       **   14-Ankara Esenboğa Havalimanı(ESB) - Paris Havalimanı(CDG)           \n");
Console.WriteLine("************************************************************************************************************************************************\n\n");
for (; ; )
{
Console.WriteLine("");
Console.WriteLine("**********  İŞLEMLER MENÜSÜ  **********\n");
Console.WriteLine("1- Yeni Kullanıcı Kaydı ");
Console.WriteLine("2- Fiyat Sorgulama ");
Console.WriteLine("3- Uçak Durumu ");
Console.WriteLine("4- Bilet Satın Al ");
Console.WriteLine("5- Günün Uçuşu ");
Console.WriteLine("6- Çıkış \n");
Console.Write("Yapmak İstediğiniz İşlemin Numarasını Giriniz : ");
int islem;
islem = Convert.ToInt32(Console.ReadLine());
switch (islem)
{
    case 1:
        Console.WriteLine("** Yeni Kullanıcı Kaydı **");
        islemler.kullaniciKaydi();
        break;
    case 2:
        Console.WriteLine("**   Fiyat Sorgulama    **");
        islemler.FiyatSorgulama();
        break;
    case 3:
        Console.WriteLine("**   Uçak Durumu   **");
        islemler.UcakDurumu();
        break;
    case 4:
        Console.WriteLine("**   Bilet Satın Al   **");
        islemler.BiletSatinAl();
        break;
    case 5:
        Console.WriteLine("**   Günün Uçuşu    **");
        islemler.GununUcusu();
        break;
    case 6:
        Console.WriteLine(txt);
        System.Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Yanlış İşlem Seçimi ");
        break;
}

}

class SatınAl
{
    private string TcKimlikNumarasi;
    public string tcKimlikNumarasi
    {
        get
        {
                TcKimlikNumarasi = TcKimlikNumarasi.Substring(0, 4) + "*******";
                return TcKimlikNumarasi;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Length != 11)
            {
                Console.WriteLine("Lütfen 11 haneli TC numaranızı giriniz!");
            }
            else
            {
                TcKimlikNumarasi = value;
            }
        }
    }
    public static void BiletSatinAl()
    {
        Console.Write("Bilet Almak İstediğiniz Uçuşu Seçiniz : ");
        int bilet = Convert.ToInt32(Console.ReadLine());

        switch (bilet)
        {
            case 1:
                Console.WriteLine("1- Sabiha Gökçen Havalimanı(SAW) - Trabzon Havalimanı(TZX)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y1 = Convert.ToChar(Console.ReadLine());
                if (y1 == 'E' || y1 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi=Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.",nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 2:
                Console.WriteLine("2- İstanbul Havalimanı(IST) - Liverpool Merkez Tren İstasyonu(LXC)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y2 = Convert.ToChar(Console.ReadLine());
                if (y2 == 'E' || y2 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 3:
                Console.WriteLine("3- Mardin Havalimanı - İzmir Havalimanı(ADB)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y3 = Convert.ToChar(Console.ReadLine());
                if (y3 == 'E' || y3 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 4:
                Console.WriteLine("4- Ankara Esenboğa Havalimanı(ESB) - Frankfurt Havalimanı(FRA)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y4 = Convert.ToChar(Console.ReadLine());
                if (y4 == 'E' || y4 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 5:
                Console.WriteLine("5- Denizli Çardak Havalimanı - Kars Harakani Havalimanı(TZX)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y5 = Convert.ToChar(Console.ReadLine());
                if (y5 == 'E' || y5 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 6:
                Console.WriteLine("6- Zürih Kloten Havalimanı(ZRH) - New York Havalimanı(EWR)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y6 = Convert.ToChar(Console.ReadLine());
                if (y6 == 'E' || y6 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 7:
                Console.WriteLine("7- Hasan Polatkan Havalimanı(AOE) - Yüksekova Havalimanı(YKO)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y7 = Convert.ToChar(Console.ReadLine());
                if (y7 == 'E' || y7 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 8:
                Console.WriteLine("8- Napoli Havalimanı(NAP) - Budapeşte Havalimanı(BUD)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y8 = Convert.ToChar(Console.ReadLine());
                if (y8 == 'E' || y8 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 9:
                Console.WriteLine("9- İstanbul Havalimanı(IST) - Adana Havalimanı(ADA)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y9 = Convert.ToChar(Console.ReadLine());
                if (y9 == 'E' || y9 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 10:
                Console.WriteLine("10-Manchester Havalimanı(MAN) - Newcastle Havalimanı(NCL)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y10 = Convert.ToChar(Console.ReadLine());
                if (y10 == 'E' || y10 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 11:
                Console.WriteLine("11-İzmir Havalimanı(SAW) - Sabiha Gökçen Havalimanı(ADB)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y11 = Convert.ToChar(Console.ReadLine());
                if (y11 == 'E' || y11 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 12:
                Console.WriteLine("12-Sofya Havalimanı(SOF) - Dalaman Havalimanı(DLM)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y12 = Convert.ToChar(Console.ReadLine());
                if (y12 == 'E' || y12 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 13:
                Console.WriteLine("13-Trabzon Havalimanı(TZX) - Sabiha Gökçen Havalimanı(SAW)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y13 = Convert.ToChar(Console.ReadLine());
                if (y13 == 'E' || y13 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            case 14:
                Console.WriteLine("14-Ankara Esenboğa Havalimanı(ESB) - Paris Havalimanı(CDG)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y14 = Convert.ToChar(Console.ReadLine());
                if (y14 == 'E' || y14 == 'e')
                {
                    SatınAl nesne = new SatınAl();
                    Console.Write("Tc Kimliğinizi Giriniz : ");
                    nesne.tcKimlikNumarasi = Console.ReadLine();
                    Console.WriteLine("{0} TC Kimlikli kişinin bileti alındı.", nesne.tcKimlikNumarasi);
                    break;
                }
                else
                {
                    islemler.BiletSatinAl();
                    break;
                }
                break;
            default:
                Console.WriteLine("Böyle Bir Uçuş Bulunmuyor");
                islemler.BiletSatinAl();
                break;
        }
    }
}
class islemler:SatınAl
{
    struct kullanıcı
    {
        public string ad;
        public string soyad;
        public string uyruk;
        public char cinsiyet;
    }

    public static void kullaniciKaydi()
    {
        Console.Write("Kaç Kullanıcı Kaydı Yapılacak :");
        int n = Convert.ToInt32(Console.ReadLine());
        kullanıcı[] kayitlar = new kullanıcı[n];
        for (int i = 0; i <= kayitlar.Length - 1; i++)
        {
            Console.WriteLine("***  {0}. Kullanıcının bilgileri  ***", i);
            Console.Write("Adınızı Giriniz :");
            kayitlar[i].ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz :");
            kayitlar[i].soyad = Console.ReadLine();
            Console.Write("Uyruk Giriniz :");
            kayitlar[i].uyruk = Console.ReadLine();
            try
            {
                Console.Write("Cinsiyetinizi Giriniz :");
                kayitlar[i].cinsiyet = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception hata)
            {
                Console.WriteLine("Tek Karakter Giriniz : " + hata);
                kullaniciKaydi();
            }

        }
        Console.WriteLine("***  KAYIT BAŞARILI   ***");

        int j = 0;
        while (j <= kayitlar.Length - 1)
        {
            Console.WriteLine("***   {0}. Kullanıcının Bilgileri   ***", j);
            Console.WriteLine("Adınız : " + kayitlar[j].ad.ToUpper());
            Console.WriteLine("Soyadınız : " + kayitlar[j].soyad.ToUpper());
            Console.WriteLine("Uyruğunuz : " + kayitlar[j].uyruk.ToUpper());
            Console.WriteLine("Cinsiyetiniz : " + kayitlar[j].cinsiyet);
            j++;
        }

    }
    public static void FiyatSorgulama()
    {
        
        Console.Write("Uçuş Seçiniz : ");
        int secim = Convert.ToInt32(Console.ReadLine());
        
        if (secim>14 || secim<1)
        {
            Console.WriteLine("Böyle Bir Uçuş Bulunmuyor");
            islemler.FiyatSorgulama();
        }
        else if (secim % 2 == 0)
        {
            Console.Write("Dış Hatlar Uçuşu : 482TL");
        }
        else
        {
            Console.WriteLine("İç Hatlar Uçuşu : 258TL");
        }
    }
    public static void UcakDurumu()
    {
        Console.Write("Durumunu Öğrenmek İstediğiniz Uçuşu Seçiniz : ");
        int numara = Convert.ToInt32(Console.ReadLine());

        switch (numara)
        {
            case 1:
                Console.WriteLine("1- Sabiha Gökçen Havalimanı(SAW) - Trabzon Havalimanı(TZX)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y1 = Convert.ToChar(Console.ReadLine());
                if (y1 == 'E' || y1 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 22:40 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 2:
                Console.WriteLine("2- İstanbul Havalimanı(IST) - Liverpool Merkez Tren İstasyonu(LXC)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y2 = Convert.ToChar(Console.ReadLine());
                if (y2 == 'E' || y2 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu (Rötar) : 14:25 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 3:
                Console.WriteLine("3- Mardin Havalimanı - İzmir Havalimanı(ADB)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y3 = Convert.ToChar(Console.ReadLine());
                if (y3 == 'E' || y3 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu (Rötar): 19:15 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 4:
                Console.WriteLine("4- Ankara Esenboğa Havalimanı(ESB) - Frankfurt Havalimanı(FRA)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y4 = Convert.ToChar(Console.ReadLine());
                if (y4 == 'E' || y4 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 10:30 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 5:
                Console.WriteLine("5- Denizli Çardak Havalimanı - Kars Harakani Havalimanı(TZX)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y5 = Convert.ToChar(Console.ReadLine());
                if (y5 == 'E' || y5 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 14:45 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 6:
                Console.WriteLine("6- Zürih Kloten Havalimanı(ZRH) - New York Havalimanı(EWR)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y6 = Convert.ToChar(Console.ReadLine());
                if (y6 == 'E' || y6 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 18:55 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 7:
                Console.WriteLine("7- Hasan Polatkan Havalimanı(AOE) - Yüksekova Havalimanı(YKO)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y7 = Convert.ToChar(Console.ReadLine());
                if (y7 == 'E' || y7 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 09:45 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 8:
                Console.WriteLine("8- Napoli Havalimanı(NAP) - Budapeşte Havalimanı(BUD)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y8 = Convert.ToChar(Console.ReadLine());
                if (y8 == 'E' || y8 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 07:30 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 9:
                Console.WriteLine("9- İstanbul Havalimanı(IST) - Adana Havalimanı(ADA)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y9 = Convert.ToChar(Console.ReadLine());
                if (y9 == 'E' || y9 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 04:40");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 10:
                Console.WriteLine("10-Manchester Havalimanı(MAN) - Newcastle Havalimanı(NCL)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y10 = Convert.ToChar(Console.ReadLine());
                if (y10 == 'E' || y10 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 08:34 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 11:
                Console.WriteLine("11-İzmir Havalimanı(SAW) - Sabiha Gökçen Havalimanı(ADB)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y11 = Convert.ToChar(Console.ReadLine());
                if (y11 == 'E' || y11 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 15:25 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 12:
                Console.WriteLine("12-Sofya Havalimanı(SOF) - Dalaman Havalimanı(DLM)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y12 = Convert.ToChar(Console.ReadLine());
                if (y12 == 'E' || y12 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 09:45 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 13:
                Console.WriteLine("13-Trabzon Havalimanı(TZX) - Sabiha Gökçen Havalimanı(SAW)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y13 = Convert.ToChar(Console.ReadLine());
                if (y13 == 'E' || y13 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 19:30 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            case 14:
                Console.WriteLine("14-Ankara Esenboğa Havalimanı(ESB) - Paris Havalimanı(CDG)");
                Console.WriteLine("Seçmek İstediğiniz Uçuş Bu Mu ? (E/H)");
                char y14 = Convert.ToChar(Console.ReadLine());
                if (y14 == 'E' || y14 == 'e')
                {
                    Console.WriteLine("Uçuş Durumu : 10:55 ");
                    break;
                }
                else
                {
                    islemler.UcakDurumu();
                    break;
                }
                break;
            default:
                Console.WriteLine("Böyle Bir Uçuş Bulunmuyor");
                islemler.UcakDurumu();
                break;
        }


    }
    
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    public static void GununUcusu()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 7);
        Gunler gunadi;
        gunadi = (Gunler)sayi;
        Console.WriteLine(gunadi.ToString()+ " günü için Özel Uçuş : Sabiha Gökçen Havalimanı(SAW) - Trabzon Havalimanı(TZX)");

    }
}







