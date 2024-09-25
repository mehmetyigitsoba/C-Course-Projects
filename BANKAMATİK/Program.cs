namespace BANKAMATİK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          /*

         *   2500 tl parası olacak 
        Bir bankamatik düşünülerek tasarlanacak bir program  için 
        Kartlı işlem    1
        Kartsız işlem   2
        //********Kartlı işlem bölümü
        Şifre istenecek=> Şifre:ab18
        ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
        //*******************Ana Menü 
        Para Çekmek için    1
        Para yatırmak için  2
        Para Transferleri   3
        Eğitim Ödemeleri    4
        Ödemeler            5
        Bilgi Güncelleme    6
        //*********************Seçim 1************
        Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
        Ana menüye dönmek için   9
        Çıkmak için             0
        //******************Seçim 2***********************
        Kredi Kartına   1
        Kendi Hesabınıza yatırmak için  2
        Ana Menü        9
        Çıkmak için     0
        //------------------------------------
        //----1
        Kredi kardı için en az 12 haneli kart numarasını girsin
        bakiye yeterli ise hesaptan kredi kartına para yatırılaca
        Ana Menü        9
        Çıkmak için     0
        //--------------------------
        //---2
        hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
        Ana Menü        9
        Çıkmak için     0
        //*****************************Seçim 3
        Başka Hesaba EFT    1
        Başka Hesaba Havale 2
        //---------------------------------
        //--1
        EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
        yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
        Ana Menü        9
        Çıkmak için     0
        //-----------------------------
        //---2
        hesap için 11 haneli hesap numarası işlemler doğru ise
        gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
        Ana Menü        9
        Çıkmak için     0
        //****************Seçim 4
        Eğitim Ödemeleri sayfası arızalı
        Ana Menü        9
        Çıkmak için     0
        //****************************Seçim 5
        Elektrik Faturası       1
        Telefon Faturası        2
        İnternet faturası       3
        Su Faturası             4
        OGS Ödemeleri           5
        //-----------------------------------------
        //---1 => bütün faturala için aşağıdaki şart yeterli
        fatura tutarı istenir, hesap uygun ise yatırılır değilse
        Ana Menü        9
        Çıkmak için     0
        //-----------------------------------
        //***************Seçim 6
        Şifre değiştirmek için 1
        Şifre değiştirme işlemi gerçekleştirilir
        Ana Menü        9
        Çıkmak için     0


       //********Kartsız işlem bölümü

       //*******************Ana Menü 
       CepBank Para Çekmek 1
        Para yatırmak için  2
        Kredi Kartı Ödeme   3
        Eğitim Ödemeleri    4
        Ödemeler            5

        //*********************Seçim 1************
        TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
        Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
Ana menüye dönmek için   9
        Çıkmak için              0
        //******************Seçim 2***********************
        Nakit ödeme     1
        Hesaptan ödeme  2
        Ana Menü        9
        Çıkmak için     0
        //------------------------------------
        //----1
     Kredi kartı için en az 12 haneli kart numarasını girsin

     Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
        Nakit olarak ödeme gerçekleştirin.
        Ana Menü        9
        Çıkmak için     0
        //--------------------------
        //---2
        Kredi kartı için en az 12 haneli kart numarasını girsin
Hesap numarasını girsin

        Ana Menü        9
        Çıkmak için     0
        //*****************************Seçim 3
        Başka Hesaba EFT    1
        Başka Hesaba Havale 2
        //---------------------------------
        //--1
        EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
        yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
        Ana Menü        9
        Çıkmak için     0
        //-----------------------------
        //---2
        hesap için 11 haneli hesap numarası işlemler doğru ise
        gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
        Ana Menü        9
        Çıkmak için     0
        //****************Seçim 4
        Eğitim Ödemeleri sayfası arızalı
        Ana Menü        9
        Çıkmak için     0
        //****************************Seçim 5
        Elektrik Faturası       1
        Telefon Faturası        2
        İnternet faturası       3
        Su Faturası             4
        OGS Ödemeleri           5
        //-----------------------------------------
        //---1 => bütün faturala için aşağıdaki şart yeterli
        fatura tutarı istenir, hesap uygun ise yatırılır değilse
        */
            int bakiye = 2500;
            string sifre = "abs13";


        ANAMENU:


            Console.WriteLine("Kartlı İşlem-1\nKartsız İşlem-2\nYapılacak işlemi seçiniz:");
            int islem = Convert.ToInt32(Console.ReadLine());
            int kredikartınayatırılan_para;
            int hesabayatırılan_para;

            if (islem == 1)
            {
                int hak = 0;

                while (hak <= 2)
                {
                    Console.WriteLine("şifre girin");
                    string sifre_3 = Console.ReadLine();
                    if (hak == 2)
                    {
                        Console.WriteLine("SİSTEM 1 SAAT KİTLENDİ");
                        Thread.Sleep(3600000);
                        goto ANAMENU;
                    }
                    else if (sifre_3 != sifre)
                    {
                        Console.WriteLine("şifre hatalı");
                        ++hak;

                    }
                    else
                    {
                        Console.WriteLine("başarılı giriş yaptınız");
                        break;
                    }










                }

            ANAMENU1:
                int islem1_1 = 1;
                int islem1_2 = 2;
                int islem1_3 = 3;
                int islem1_4 = 4;
                int islem1_5 = 5;
                int islem1_6 = 6;
                int islem1_9 = 9;
                int islem1_0 = 0;
                Console.WriteLine("para çekmek-1_1\npara yatırmak-1_2\npara transferi-1_3\neğitim ödemeleri-1_4\nfatura ödeme-1_5\nşifre değiştirme-1_6\nana menüye dön-1_9\nsistemden çık-1_0\nYapılacak işlemi seçiniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == islem1_1)
                {
                PARACEK:
                    Console.WriteLine("ne kadar para çekmek istiyorsunuz:");
                    int cekilecek_para = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_para > bakiye)
                    {
                        Console.WriteLine("bakiye yetersiz");
                        goto PARACEK;
                    }
                    else
                    {
                        Console.WriteLine(cekilecek_para);
                        bakiye = bakiye - cekilecek_para;
                        Console.WriteLine("yeni bakiyeniz" + bakiye);
                        goto ANAMENU1;

                    }




                }
                else if (sayi == islem1_2)
                {

                    int islem1_2_1 = 1;
                    int islem1_2_2 = 2;
                    Console.WriteLine("kredi kartına para yatırmak-1_2_1\nhesaba para yatırmak-1_2_2\nyapılacak işlemi seçin");
                    int sayi9 = Convert.ToInt32(Console.ReadLine());



                    if (islem1_2_1 == sayi9)
                    {
                        Console.WriteLine("yatırılacak parayı girin:");
                        kredikartınayatırılan_para = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("kredi kartına yatırılan para" + kredikartınayatırılan_para);
                        goto ANAMENU1;
                    }
                    else if (sayi9 == islem1_2_2)
                    {
                        Console.WriteLine("yatırılacak parayı girin:");
                        hesabayatırılan_para = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("kredi kartına yatırılan para" + hesabayatırılan_para);
                        goto ANAMENU1;
                    }
                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız");
                        return;
                    }


                }
                else if (sayi == islem1_3)
                {
                    int islem1_3_1 = 1;
                    int islem1_3_2 = 2;
                    Console.WriteLine("ibana para gönderme-1_3_1\nhesaba para gönderme-1_3_2\nhangi işlemi yapmak istiyorsunuz:");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());




                    if (islem1_3_1 == sayi2)
                    {
                    KOD:
                        Console.WriteLine("üleninin para kodunu girin");
                        string metin = Console.ReadLine();

                        string b = metin.ToUpper();

                        if (b != "TR")
                        {
                            Console.WriteLine("hatalı ülke kodu");
                            goto KOD;
                        }
                        else
                        {
                        IBAN:
                            Console.WriteLine("bir ibam giriniz");
                            long sayi_1 = Convert.ToInt64(Console.ReadLine());
                            int basamak = (int)Math.Log10(sayi_1) + 1;
                            if (basamak != 12)
                            {

                                Console.WriteLine("hatalı iban girdiniz");
                                goto IBAN;
                            }
                            else
                            {
                                Console.WriteLine("göndericek iban" + (b + sayi_1));
                            IBANAGONDER:
                                Console.WriteLine("GÖNDERİLECEK PARA");
                                int gondpara_1 = Convert.ToInt32(Console.ReadLine());
                                if (gondpara_1 > bakiye)
                                {
                                    Console.WriteLine("bakiye yetersiz");
                                    goto IBANAGONDER;
                                }
                                else
                                {
                                    bakiye = bakiye - gondpara_1;
                                    Console.WriteLine("yeni bakiye" + bakiye);
                                    goto ANAMENU1;

                                }

                            }

                        }


                    }
                    else if (islem1_3_2 == sayi2)
                    {
                    HESAPNO:
                        Console.WriteLine("11 hanali hesap numarsı girin");
                        long sayi3 = Convert.ToInt64(Console.ReadLine());
                        int basamak2 = (int)Math.Log10(sayi3) + 1;
                        if (basamak2 != 11)
                        {
                            Console.WriteLine("hesap no hatalı");
                            goto HESAPNO;
                        }
                        else
                        {
                        HESABAGONDER:
                            Console.WriteLine("GÖNDERİLECEK PARA");
                            int gondpara = Convert.ToInt32(Console.ReadLine());
                            if (bakiye < gondpara)
                            {
                                Console.WriteLine("bakiye yetersi");
                                goto HESABAGONDER;
                            }
                            else
                            {
                                bakiye = bakiye - gondpara;
                                Console.WriteLine("yeni bakiye" + bakiye);
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız");
                        return;
                    }

                }
                else if (sayi == islem1_4)
                {
                    Console.WriteLine("EĞİTİM ÖDEMELERİ ARIZALI");
                    goto ANAMENU1;
                }
                else if (sayi == islem1_5)
                {
                    int islem1_5_1 = 1;
                    int islem1_5_2 = 2;
                    int islem1_5_3 = 3;
                    int islem1_5_4 = 4;
                    int islem1_5_5 = 5;

                    Console.WriteLine("elektik faturası ödeme-1_5_1\ntelefon faturası ödeme-1-5_2\ninternet faturası ödeme-1_5_3\nsu fatarası ödeme-1_5_4\nOGS ödeme-1_5_5\nhangi işlemi yapmak istiyorsunuz");
                    int sayi4 = Convert.ToInt32(Console.ReadLine());
                    if (sayi4 == islem1_5_1)
                    {
                        Console.WriteLine("elektrik faturasını ödeyin");
                        int elektrikfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < elektrikfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU1;
                        }
                        else
                        {
                            Console.WriteLine("elektrik faturası ödendi");
                            bakiye = bakiye - elektrikfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU1;
                        }

                    }
                    else if (sayi4 == islem1_5_2)
                    {


                        Console.WriteLine("telefon faturasını ödeyin");
                        int telefonfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < telefonfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU1;
                        }
                        else
                        {
                            Console.WriteLine("telefon faturası ödendi");
                            bakiye = bakiye - telefonfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU1;
                        }


                    }
                    else if (sayi4 == islem1_5_3)
                    {


                        Console.WriteLine("internet faturasını ödeyin");
                        int internetfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < internetfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU1;
                        }
                        else
                        {
                            Console.WriteLine("internet faturası ödendi");
                            bakiye = internetfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU1;
                        }


                    }
                    else if (sayi4 == islem1_5_4)
                    {


                        Console.WriteLine("su faturasını ödeyin");
                        int sufaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < sufaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU1;
                        }
                        else
                        {
                            Console.WriteLine("telefon faturası ödendi");
                            bakiye = bakiye - sufaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU1;
                        }


                    }
                    else if (sayi4 == islem1_5_5)
                    {


                        Console.WriteLine("OGS faturasını ödeyin");
                        int OGSfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < OGSfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU1;
                        }
                        else
                        {
                            Console.WriteLine("OGS faturası ödendi");
                            bakiye = bakiye - OGSfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU1;
                        }


                    }
                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız");
                        return;
                    }
                }
                else if (sayi == islem1_6)
                {

                    int hak2 = 0;

                    while (hak2 <= 2)
                    {
                        Console.WriteLine("mevcut sifrenizi girin");
                        string sifre_2 = Console.ReadLine();
                        if (hak2 == 2)
                        {
                            Console.WriteLine("SİSTEM 1 SAAT KALDI");
                            Thread.Sleep(3600000);
                            goto ANAMENU;
                        }
                        else if (sifre_2 != sifre)
                        {
                            Console.WriteLine("mevcut sifreniz hatalı");
                            ++hak2;
                        }
                        else
                        {
                            Console.WriteLine("yeni sifrenizi girin");
                            sifre = Console.ReadLine();
                            goto ANAMENU;
                        }
                    }


                }
                else if (sayi == islem1_9)
                {
                    goto ANAMENU;
                }
                else if (sayi == islem1_0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    return;
                }
            }
            else if (islem == 2)
            {
                int islem2_1 = 1;
                int islem2_2 = 2;
                int islem2_3 = 3;
                int islem2_4 = 4;
                int islem2_5 = 5;
                int islem2_6 = 6;
                int islem2_9 = 9;
                int islem2_0 = 0;
                int kredikartıborcu = 1000;
            ANAMENU2:
                Console.WriteLine("para çekmek-2_1\npara yatırmak-2_2\npara transferi-2_3\neğitim ödemeleri-2_4\nfatura ödeme-2_5\nana menüye dön-2_9\nsistemden çık-2_0\nYapılacak işlemi seçiniz:");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                int yatırılantutar = 0;
                int nakitödenilentutar = 0;
                int hesaptancekilecektutar = 0;
                bakiye = bakiye - yatırılantutar;
                kredikartıborcu = kredikartıborcu - hesaptancekilecektutar;


                if (sayi5 == islem2_1)
                {
                    long TC = 123456789123;
                    long cepno = 05537770023;

                    int hak5 = 0;

                    while (hak5 <= 2)
                    {
                        Console.WriteLine("TC NO GİRİNİZ:");
                        long sorgu1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("telefon no giriniz:");
                        long sorgu2 = Convert.ToInt64(Console.ReadLine());
                        bool cevap = sorgu1 != TC || sorgu2 != cepno;
                        if (hak5 == 2)
                        {
                            Console.WriteLine("sistem 5sn kitlendi");
                            Thread.Sleep(5000);
                            goto ANAMENU;
                        }

                        else if (cevap)
                        {
                            Console.WriteLine("hatalı tc");
                            Console.WriteLine("hatalı cepno");
                            ++hak5;
                        }
                        else if (sorgu1 == TC && sorgu2 == cepno)
                        {
                            Console.WriteLine("1000 liranızı alabilirsiniz");
                            bakiye = bakiye - 1000;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }
                    }

                }
                else if (sayi5 == islem2_2)
                {
                    int islem2_2_1 = 1;
                    int islem2_2_2 = 2;
                    Console.WriteLine("kredi kartına para yatırmak-1_2_1\nhesaba para yatırmak-1_2_2\nyapılacak işlemi seçin");
                    int sayi10 = Convert.ToInt32(Console.ReadLine());



                    if (islem2_2_1 == sayi10)
                    {
                        Console.WriteLine("yatırılacak parayı girin:");
                        kredikartınayatırılan_para = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("kredi kartına yatırılan para" + kredikartınayatırılan_para);
                        goto ANAMENU2;
                    }
                    else if (sayi10 == islem2_2_2)
                    {
                        Console.WriteLine("yatırılacak parayı girin:");
                        hesabayatırılan_para = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("kredi kartına yatırılan para" + hesabayatırılan_para);
                        goto ANAMENU2;
                    }
                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız");
                        return;
                    }

                }
                else if (sayi5 == islem2_3)
                {
                    int islem2_3_1 = 1;
                    int islem2_3_2 = 2;







                    Console.WriteLine("ibana para gönderme-2_3_1\nhesaba para gönderme-2_3_2\nhangi işlemi yapmak istiyorsunuz:");
                    int sayi6 = Convert.ToInt32(Console.ReadLine());
                    if (sayi6 == islem2_3_1)
                    {
                        Console.WriteLine("ödemek istediğiniz tutarı girin");
                        nakitödenilentutar = Convert.ToInt32(Console.ReadLine());
                        kredikartıborcu = kredikartıborcu - nakitödenilentutar;
                        Console.WriteLine("kalan kredi kartı borcunuz" + kredikartıborcu);
                        goto ANAMENU2;
                    }
                    else if (sayi6 == islem2_3_2)
                    {
                    NAN:
                        Console.WriteLine("ödemek istediğiniz tutarı girin");
                        hesaptancekilecektutar = Convert.ToInt32(Console.ReadLine());

                        if (bakiye < hesaptancekilecektutar)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto NAN;
                        }
                        else
                        {

                            bakiye = bakiye - hesaptancekilecektutar;
                            kredikartıborcu = kredikartıborcu - hesaptancekilecektutar;
                            Console.WriteLine("kalan kredi kartı borcunuz" + kredikartıborcu);
                            goto ANAMENU2;
                        }

                    }






                }
                else if (sayi5 == islem2_4)
                {
                    Console.WriteLine("eiğitim ödeme arızalı");
                    goto ANAMENU2;
                }
                else if (sayi5 == islem2_5)
                {


                    int islem2_5_1 = 1;
                    int islem2_5_2 = 2;
                    int islem2_5_3 = 3;
                    int islem2_5_4 = 4;
                    int islem2_5_5 = 5;

                    Console.WriteLine("elektik faturası ödeme-2_5_1\ntelefon faturası ödeme-2-5_2\ninternet faturası ödeme-2_5_3\nsu fatarası ödeme-2_5_4\nOGS ödeme-2_5_5\nhangi işlemi yapmak istiyorsunuz");
                    int sayi6 = Convert.ToInt32(Console.ReadLine());
                    if (sayi6 == islem2_5_1)
                    {
                        Console.WriteLine("elektrik faturasını ödeyin");
                        int elektrikfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < elektrikfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU2;
                        }
                        else
                        {
                            Console.WriteLine("elektrik faturası ödendi");
                            bakiye = bakiye - elektrikfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }

                    }
                    else if (sayi6 == islem2_5_2)
                    {


                        Console.WriteLine("telefon faturasını ödeyin");
                        int telefonfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < telefonfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU2;
                        }
                        else
                        {
                            Console.WriteLine("telefon faturası ödendi");
                            bakiye = bakiye - telefonfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }


                    }
                    else if (sayi6 == islem2_5_3)
                    {


                        Console.WriteLine("internet faturasını ödeyin");
                        int internetfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < internetfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU2;
                        }
                        else
                        {
                            Console.WriteLine("internet faturası ödendi");
                            bakiye = bakiye - internetfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }


                    }
                    else if (sayi6 == islem2_5_4)
                    {


                        Console.WriteLine("su faturasını ödeyin");
                        int sufaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < sufaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU2;
                        }
                        else
                        {
                            Console.WriteLine("su faturası ödendi");
                            bakiye = bakiye - sufaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }


                    }
                    else if (sayi6 == islem2_5_5)
                    {


                        Console.WriteLine("OGS faturasını ödeyin");
                        int OGSfaturası = Convert.ToInt32(Console.ReadLine());
                        if (bakiye < OGSfaturası)
                        {
                            Console.WriteLine("bakiye yetersiz");
                            goto ANAMENU2;
                        }
                        else
                        {
                            Console.WriteLine("OGS faturası ödendi");
                            bakiye = bakiye - OGSfaturası;
                            Console.WriteLine("yeni bakiye" + bakiye);
                            goto ANAMENU2;
                        }


                    }

                    else
                    {
                        Console.WriteLine("hatalı tuşlama yaptınız");
                        return;
                    }
                }
                else if (islem2_9 == sayi5)
                {
                    goto ANAMENU;
                }
                else if (islem2_0 == sayi5)
                {

                    return;
                }
                else
                {
                    Console.WriteLine("hatalı tuşlama yaptınız");
                    return;
                }

            }
            else if (islem == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("hatalı tuşlama yaptınız");
                return;
            }
        }
    }
}
