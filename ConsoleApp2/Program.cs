//double taban, yükseklik, alan;
//Console.Write("Taban sayısını girin : ");
//taban = double.Parse(Console.ReadLine());
//Console.Write("Yükseklik değeri girin : ");
//yükseklik = double.Parse(Console.ReadLine());
//alan = (taban * yükseklik) / 2;
//Console.Write("Sonuç: {0}", alan);
//Console.ReadKey();


//double birimFiyat, aylikBedel, tuketimMiktarı;
//Console.WriteLine("Tüketim miktarını girin: ");
//tuketimMiktarı = double.Parse(Console.ReadLine());
//Console.WriteLine("Birim fiyat giriniz : ");
//birimFiyat = double.Parse(Console.ReadLine());
//aylikBedel = (tuketimMiktarı * birimFiyat);
//Console.WriteLine(aylikBedel);
//Console.ReadKey();


//Console.WriteLine("1.sayiyi giriniz: ");
//int sayi1=int.Parse(Console.ReadLine());
//Console.WriteLine("2.sayiyi giriinz: ");
//int sayi2=int.Parse(Console.ReadLine());
//if (sayi1 % sayi2 == 0)
//    Console.WriteLine("{0} sayisi {1} sayisina tam bölünür ", sayi1, sayi2);
//else
//    Console.WriteLine("{0} sayisi {1} sayisina tam bölünmez", sayi1, sayi2);
//Console.ReadKey();


//int adet, toplamFiyat, birimFiyat;
//char cevap;
//Console.Write("Adet degeri giriniz: ");
//adet=int.Parse(Console.ReadLine());
//Console.Write("Birim fiyat giriniz: ");
//birimFiyat=int.Parse(Console.ReadLine());
//toplamFiyat = adet * birimFiyat;
//Console.Write("Satış fiyatı. "+toplamFiyat);
//if (toplamFiyat > 1000)
//{
//
//   Console.Write("Devam etmek istiyor musunuz?  (E/ H) ");
//    cevap = char.Parse(Console.ReadLine());
//    if (cevap == 'e' || cevap == 'E')
//        Console.Write("İşlem onaylandı");
//    else
//        Console.Write("İşlem iptal edildi");

//}
//else
//    Console.Write("İşlem onaylandı");


//-----VİZE SORUSU OLABİLİR ÇIKTISI NEDİR ŞEKLİNDE------
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//        Console.Write("*");
//    Console.WriteLine();

//}


//int toplam = 0;
//string sayi;
//Console.Write("Sayiyi giriniz: ");
//sayi=Console.ReadLine();
//for (int i = 0; i < sayi.Length; i++)
//    toplam += int.Parse(sayi[i].ToString());
//Console.Write("Sayinin rakamları toplamı: {0}", toplam);



//string sesliharfler = "aerioöuü";
//string sessizharfler = "bcçdfghjklmnprsstvyz";
//string rakamlar = "1234567890";
//int seslisay = 0, sessizsay = 0, rakamsay = 0;
//Console.Write("Metin giriniz: ");
//string metin = Console.ReadLine();
//metin.ToLower();
//foreach (char karakter in metin)
//{
//    foreach (char sesli in sesliharfler)
//    {
//        if (karakter == sesli)
//            seslisay++;
//    }
//    foreach (char sessiz in sessizharfler)
//    {
//        if (karakter == sessiz)
//            sessizsay++;
//    }
//    foreach (char rakam in rakamlar)
//    {
//        if (karakter == rakam)
//            rakamsay++;
//    }

//}
//Console.WriteLine("Metin uzunluğu: " + metin.Length);
//Console.WriteLine("Sesli harflerin uzunluğu: " + seslisay);
//Console.WriteLine("Sessiz harflerin uzunluğu: " + sessizsay);
//Console.WriteLine("Rakamların sayısı: " + rakamsay);
//Console.WriteLine("Özel karakter sayısı: " + (metin.Length - (seslisay + sessizsay
//+ rakamsay)));
//Console.ReadKey();


//{
//    Console.Write("Yaşınızı giriniz: ");
//    int yas = int.Parse(Console.ReadLine());

//    Console.Write("Boyunuzu giriniz (cm): ");
//    int boy = int.Parse(Console.ReadLine());

//    Console.Write("Kilonuzu giriniz: ");
//    int kilo = int.Parse(Console.ReadLine());

//    double kalori = Hesapla(yas, boy, kilo);

//    Console.WriteLine("Hesaplanan kalori: " + kalori);

//    Console.ReadKey();
//}

//static double Hesapla(int yas, int boy, int kilo)
//{
//    double sonuc = 0;

//    // Yaş
//    if (yas >= 18 && yas < 29)
//        sonuc += 10;
//    else if (yas >= 29 && yas < 45)
//        sonuc += 25;
//    else if (yas >= 45)
//        sonuc += 35;

//    // Boy
//    if (boy >= 150 && boy < 180)
//        sonuc *= 1.75;
//    else if (boy >= 180 && boy < 200)
//        sonuc *= 1.50;
//    else if (boy >= 200)
//        sonuc *= 1.25;

//    // Kilo
//    if (kilo >= 0 && kilo < 60)
//        sonuc *= 2;
//    else if (kilo >= 60 && kilo < 80)
//        sonuc *= 3;
//    else if (kilo >= 80 && kilo < 100)
//        sonuc *= 4;
//    else if (kilo >= 100)
//        sonuc *= 5;

//    return sonuc;
//}


