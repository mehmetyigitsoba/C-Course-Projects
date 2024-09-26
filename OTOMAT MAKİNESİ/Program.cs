using System.ComponentModel.Design;

namespace OTOMAT_MAKİNESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PERŞEMBE

     Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
    Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

     // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek

          */
            
            string[] ürünler = { "COLA", "FANTA", "AYRAN" };
            string yeniÜrün = "";

            int cola = 10;
            int fanta = 20;
            int ayran = 30;
            
            int[] ürünFiyatları = { cola, fanta, ayran };
            int yeniÜrünFiyatı = 0;
            int güccelenecekÜrünFiyatı = 0;


        ANAMENU:
            Console.WriteLine("ürünlerin eleman uzuunluğu:" + ürünler.Length);
           
            Console.WriteLine("ne istersiniz:");
            string cevap =Console.ReadLine().ToUpper();
            if (cevap == ürünler[0])
            {
                Console.WriteLine($"ÜRÜN FİYATI:{ürünFiyatları[0]}TL");
                Console.WriteLine("PARA GİRİNİZ");
                int girilenPara = Convert.ToInt32(Console.ReadLine());

                while (ürünFiyatları[0] < ürünFiyatları[0])
                {
                    int eklenecekPara = ürünFiyatları[0] - girilenPara;
                BİRONCEKİ_İSLEM:
                    Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENÜ-2");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1)
                    {
                        Console.WriteLine("PARA GİRİNİZ");
                        eklenecekPara = Convert.ToInt32(Console.ReadLine());
                        girilenPara += eklenecekPara;


                    }
                    else if (islem == 2)
                    {
                        goto ANAMENU;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                        goto BİRONCEKİ_İSLEM;
                    }
                    break;

                }
                while (girilenPara >= ürünFiyatları[0])
                {
                    int paraÜstü = girilenPara - ürünFiyatları[0];
                    Console.WriteLine($"afiyetolsun,para üstü:{paraÜstü}TL");
                    goto ANAMENU;

                }

            }
            else if (cevap == ürünler[1])
            {
                Console.WriteLine($"ÜRÜN FİYATI:{ürünFiyatları[1]}TL");
                Console.WriteLine("PARA GİRİNİZ");
                int girilenPara = Convert.ToInt32(Console.ReadLine());

                while (girilenPara < ürünFiyatları[1])
                {
                    int eklenecekPara = ürünFiyatları[1] - girilenPara;
                BİRONCEKİ_İSLEM:
                    Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENÜ-2");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1)
                    {
                        Console.WriteLine("PARA GİRİNİZ");
                        eklenecekPara = Convert.ToInt32(Console.ReadLine());
                        girilenPara += eklenecekPara;


                    }
                    else if (islem == 2)
                    {
                        goto ANAMENU;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                        goto BİRONCEKİ_İSLEM;
                    }
                    break;

                }
                while (girilenPara >= ürünFiyatları[1])
                {
                    int paraÜstü = girilenPara - fanta;
                    Console.WriteLine($"afiyetolsun,para üstü:{paraÜstü}TL");
                    goto ANAMENU;

                }

            }
            else if (cevap == ürünler[2])
            {
                Console.WriteLine($"ÜRÜN FİYATI:{ürünFiyatları[2]}TL");
                Console.WriteLine("PARA GİRİNİZ");
                int girilenPara = Convert.ToInt32(Console.ReadLine());

                while (girilenPara < ürünFiyatları[2])
                {
                    int eklenecekPara = ürünFiyatları[2] - girilenPara;
                BİRONCEKİ_İSLEM:
                    Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENÜ-2");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1)
                    {
                        Console.WriteLine("PARA GİRİNİZ");
                        eklenecekPara = Convert.ToInt32(Console.ReadLine());
                        girilenPara += eklenecekPara;


                    }
                    else if (islem == 2)
                    {
                        goto ANAMENU;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                        goto BİRONCEKİ_İSLEM;
                    }
                    break;

                }
                while (girilenPara >= ürünFiyatları[2])
                {
                    int paraÜstü = girilenPara - ürünFiyatları[2];
                    Console.WriteLine($"afiyetolsun,para üstü:{paraÜstü}TL");
                    goto ANAMENU;

                }


            }
            else if (cevap == yeniÜrün)
            {
                Console.WriteLine($"ÜRÜN FİYATI:{yeniÜrünFiyatı}TL");
                Console.WriteLine("PARA GİRİNİZ");
                int girilenPara = Convert.ToInt32(Console.ReadLine());

                while (girilenPara < yeniÜrünFiyatı)
                {
                    int eklenecekPara = yeniÜrünFiyatı - girilenPara;
                BİRONCEKİ_İSLEM:
                    Console.WriteLine("bakiye yetersi!!.para ekleme-1\nANAMENÜ-2");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1)
                    {
                        Console.WriteLine("PARA GİRİNİZ");
                        eklenecekPara = Convert.ToInt32(Console.ReadLine());
                        girilenPara += eklenecekPara;


                    }
                    else if (islem == 2)
                    {
                        goto ANAMENU;
                    }
                    else
                    {
                        Console.WriteLine("hatalı işlem");
                        goto BİRONCEKİ_İSLEM;
                    }
                    break;

                }
                while (girilenPara >= yeniÜrünFiyatı)
                {
                    int paraÜstü = girilenPara - yeniÜrünFiyatı;
                    Console.WriteLine($"afiyetolsun,para üstü:{paraÜstü}TL");
                    goto ANAMENU;

                }
            }
            else if (cevap == "-1")
            {
                int islem = 0;
                while (true)
                {
                    
                    try
                    {
                        Console.WriteLine("ürün eklemek için-1\nürün silmek için-2\nürün güncellemek için-3\nürün listelemek için-4");
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

                    Array.Resize(ref ürünler, ürünler.Length + 1);
                    Array.Resize(ref ürünFiyatları, ürünFiyatları.Length + 1);
                    Console.WriteLine("eklemek istediğiniz ürünü girin");
                    yeniÜrün = Console.ReadLine().ToUpper();
                    ürünler[ürünler.Length - 1] = yeniÜrün;
                    Console.WriteLine("eklemek istediğiniz ürününün fiyatını  girin");
                    yeniÜrünFiyatı = Convert.ToInt32(Console.ReadLine());
                    ürünFiyatları[ürünFiyatları.Length-1]=yeniÜrünFiyatı;
                    goto ANAMENU;


                }
                else if (islem == 2)
                {
                    int index = 0;
                    foreach (var item in ürünler)
                    {
                        Console.WriteLine($"index no:{index}" + item);
                        index++;
                    }
                    Console.WriteLine("silinecek ürünün index no:");
                    int silinecekÜrün = Convert.ToInt32(Console.ReadLine());
                    Array.Clear(ürünler, silinecekÜrün, 1);
                    index = 0;
                    foreach (var item in ürünler)
                    {
                        Console.WriteLine($"index no:{index}" + item);
                        index++;
                    }
                    goto ANAMENU;


                }
                else if (islem == 3)
                {
                    int index = 0;

                    foreach (var item in ürünler)
                    {
                        Console.WriteLine($"index no:{index}" + item);
                        index++;
                    }
                    Console.WriteLine("güncellemek isteğiniz ürününün index no:");
                    int guncellenecekÜrün = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("güncellemek isteğiniz ürün");

                    ürünler[guncellenecekÜrün] = Console.ReadLine().ToUpper();
                    Console.WriteLine("güncellenmiş ürünün fiyatını girin:");
                    ürünFiyatları[güccelenecekÜrünFiyatı] = Convert.ToInt32(Console.ReadLine());


                    index = 0;

                    foreach (var item in ürünler)
                    {
                        Console.WriteLine($"index no:{index}" + item);
                        index++;
                    }
                    goto ANAMENU;
                }
                else if (islem == 4)
                {

                    int n = 0;
                    foreach (var item in ürünler)
                    {
                        Console.WriteLine(item);

                        Console.WriteLine($"{ürünFiyatları[n]}TL");
                            n++;

                    }
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                    goto ANAMENU;
                }
            }



        }
    }
}
