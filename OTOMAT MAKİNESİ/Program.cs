using System.ComponentModel.Design;

namespace OTOMAT_MAKİNESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
                               /* PERŞEMBE

Muşteri Daha önceden tanımlanmış bir urun listesinden bir urun seçecek. 
Para girişi yapacak. Girilen para seçilen urunun fiyatını karşılar ise urun alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

// Admin => urun Ekleyecek, urun Silecek, Fiyat Guncelleyecek

*/
            string[] urunler = { "COLA", "FANTA", "AYRAN" };
            string yeniUrun = "";

           

            int[] urunFiyatları = { 10, 20, 30 };
            int yeniUrunFiyatı = 0;
            int guccelenecekUrunFiyatı = 0;


            while (true)
            {
                Console.WriteLine("urunlerin eleman uzuunluğu:" + urunler.Length);

                Console.WriteLine("ne istersiniz:");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == urunler[0])
                {
                    Console.WriteLine($"URUN FİYATI:{urunFiyatları[0]}TL");
                    Console.WriteLine("PARA GİRİNİZ");
                    int girilenPara = Convert.ToInt32(Console.ReadLine());

                    while (urunFiyatları[0] < urunFiyatları[0])
                    {
                        int eklenecekPara = urunFiyatları[0] - girilenPara;

                        Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENU-2");
                        int islem = Convert.ToInt32(Console.ReadLine());

                        if (islem == 1)
                        {
                            Console.WriteLine("PARA GİRİNİZ");
                            eklenecekPara = Convert.ToInt32(Console.ReadLine());
                            girilenPara += eklenecekPara;
                            continue;


                        }
                        else if (islem == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("hatalı işlem");
                            continue;

                        }


                    }
                    while (girilenPara >= urunFiyatları[0])
                    {
                        int paraUstu = girilenPara - urunFiyatları[0];
                        Console.WriteLine($"afiyetolsun,para ustu:{paraUstu}TL");
                        break;

                    }

                }
                else if (cevap == urunler[1])
                {
                    Console.WriteLine($"URUN FİYATI:{urunFiyatları[1]}TL");
                    Console.WriteLine("PARA GİRİNİZ");
                    int girilenPara = Convert.ToInt32(Console.ReadLine());

                    while (girilenPara < urunFiyatları[1])
                    {
                        int eklenecekPara = urunFiyatları[1] - girilenPara;

                        Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENU-2");
                        int islem = Convert.ToInt32(Console.ReadLine());

                        if (islem == 1)
                        {
                            Console.WriteLine("PARA GİRİNİZ");
                            eklenecekPara = Convert.ToInt32(Console.ReadLine());
                            girilenPara += eklenecekPara;
                            continue;


                        }
                        else if (islem == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("hatalı işlem");
                            continue;
                        }


                    }
                    while (girilenPara >= urunFiyatları[1])
                    {
                        int paraUstu = girilenPara - urunFiyatları[1];
                        Console.WriteLine($"afiyetolsun,para ustu:{paraUstu}TL");
                        break;

                    }

                }
                else if (cevap == urunler[2])
                {
                    Console.WriteLine($"URUN FİYATI:{urunFiyatları[2]}TL");
                    Console.WriteLine("PARA GİRİNİZ");
                    int girilenPara = Convert.ToInt32(Console.ReadLine());

                    while (girilenPara < urunFiyatları[2])
                    {
                        int eklenecekPara = urunFiyatları[2] - girilenPara;

                        Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENU-2");
                        int islem = Convert.ToInt32(Console.ReadLine());

                        if (islem == 1)
                        {
                            Console.WriteLine("PARA GİRİNİZ");
                            eklenecekPara = Convert.ToInt32(Console.ReadLine());
                            girilenPara += eklenecekPara;
                            continue;


                        }
                        else if (islem == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("hatalı işlem");
                            continue;
                        }


                    }
                    while (girilenPara >= urunFiyatları[2])
                    {
                        int paraUstu = girilenPara - urunFiyatları[2];
                        Console.WriteLine($"afiyetolsun,para ustu:{paraUstu}TL");
                        break;

                    }


                }
                else if (cevap == yeniUrun)
                {
                    Console.WriteLine($"URUN FİYATI:{yeniUrunFiyatı}TL");
                    Console.WriteLine("PARA GİRİNİZ");
                    int girilenPara = Convert.ToInt32(Console.ReadLine());

                    while (girilenPara < yeniUrunFiyatı)
                    {
                        int eklenecekPara = yeniUrunFiyatı - girilenPara;

                        Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENU-2");
                        int islem = Convert.ToInt32(Console.ReadLine());

                        if (islem == 1)
                        {
                            Console.WriteLine("PARA GİRİNİZ");
                            eklenecekPara = Convert.ToInt32(Console.ReadLine());
                            girilenPara += eklenecekPara;
                            continue;


                        }
                        else if (islem == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("hatalı işlem");
                            continue;
                        }


                    }
                    while (girilenPara >= yeniUrunFiyatı)
                    {
                        int paraUstu = girilenPara - yeniUrunFiyatı;
                        Console.WriteLine($"afiyetolsun,para ustu:{paraUstu}TL");
                        break;

                    }
                }
                else if (cevap == "-1")
                {
                    int islem = 0;
                    while (true)
                    {

                        try
                        {
                            Console.WriteLine("urun eklemek için-1\nurun silmek için-2\nurun guncellemek için-3\nurun listelemek için-4");
                            islem = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("rakam giriniz");
                        }
                    }

                    if (islem == 1)
                    {

                        Array.Resize(ref urunler, urunler.Length + 1);
                        Array.Resize(ref urunFiyatları, urunFiyatları.Length + 1);
                        Console.WriteLine("eklemek istediğiniz urunu girin");
                        yeniUrun = Console.ReadLine().ToUpper();
                        urunler[urunler.Length - 1] = yeniUrun;
                        Console.WriteLine("eklemek istediğiniz urununun fiyatını  girin");
                        yeniUrunFiyatı = Convert.ToInt32(Console.ReadLine());
                        urunFiyatları[urunFiyatları.Length - 1] = yeniUrunFiyatı;
                        continue;


                    }
                    else if (islem == 2)
                    {
                        int index = 0;
                        foreach (var item in urunler)
                        {
                            Console.WriteLine($"index no:{index}" + item);
                            index++;
                        }
                        Console.WriteLine("silinecek urunun index no:");
                        int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                        Array.Clear(urunler, silinecekUrun, 1);
                        index = 0;
                        foreach (var item in urunler)
                        {
                            Console.WriteLine($"index no:{index}" + item);
                            index++;
                        }
                        continue;


                    }
                    else if (islem == 3)
                    {
                        int index = 0;

                        foreach (var item in urunler)
                        {
                            Console.WriteLine($"index no:{index}" + item);
                            index++;
                        }
                        Console.WriteLine("guncellemek isteğiniz urununun index no:");
                        int guncellenecekUrun = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("guncellemek isteğiniz urun");

                        urunler[guncellenecekUrun] = Console.ReadLine().ToUpper();
                        Console.WriteLine("guncellenmiş urunun fiyatını girin:");
                        urunFiyatları[guccelenecekUrunFiyatı] = Convert.ToInt32(Console.ReadLine());


                        index = 0;

                        foreach (var item in urunler)
                        {
                            Console.WriteLine($"index no:{index}" + item);
                            index++;
                        }
                        continue;
                    }
                    else if (islem == 4)
                    {

                        int n = 0;
                        foreach (var item in urunler)
                        {
                            Console.WriteLine(item);

                            Console.WriteLine($"{urunFiyatları[n]}TL");
                            n++;

                        }
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                        continue;
                    }
                }

            }



        }
    }
}
