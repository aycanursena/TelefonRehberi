using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Metotlar
    {
        //Menu yeniIslem = new Menu();

        public ArrayList isimler = new ArrayList()
                                {"B" , "E", "H", "Ö", "C", "E"};
        public ArrayList soyisimler = new ArrayList()
                                {"Ç", "Ç", "Y", "E", "Y", "K"};
        public ArrayList numaralar = new ArrayList()
                                {05000000000, 05000000001, 05000000002, 05000000003, 05000000004, 05000000005};
        public void NumaraSil()
        {
            Console.WriteLine(" ");
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string silinecek_isim = Console.ReadLine();
            Console.WriteLine(" ");
            if (isimler.Contains(silinecek_isim) || soyisimler.Contains(silinecek_isim))
                Console.WriteLine(silinecek_isim + " isimli/soyisimli kişi rehberden silinmek üzere onaylıyor musunuz ? \n1- Evet\n2- Hayır");
            Console.Write("Seçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (secim == 1)
            {
                if (isimler.Contains(silinecek_isim))
                {
                    int x = isimler.IndexOf(silinecek_isim);
                    isimler.RemoveAt(x);
                    soyisimler.RemoveAt(x);
                    numaralar.RemoveAt(x);
                }
                else if (soyisimler.Contains(silinecek_isim))
                {
                    int y = soyisimler.IndexOf(silinecek_isim);
                    isimler.RemoveAt(y);
                    soyisimler.RemoveAt(y);
                    numaralar.RemoveAt(y);
                }
                Console.WriteLine(silinecek_isim + " isimli/soyisimli kişi rehberden silindi.");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı.\nLütfen bir seçim yapınız : ");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                Console.Write("Seçiminiz : ");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Silme işlemi sonlandırıldı..");
                    Console.WriteLine("----------------------------");
                }
                if (secim1 == 2)
                {
                    Console.WriteLine(" ");
                    NumaraSil();
                }
            }
        }
        public void NumaraGuncelle()
        {
            Console.WriteLine(" ");
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string isim = Console.ReadLine();

            if (isimler.Contains(isim))
            {
                int index = isimler.IndexOf(isim);

                Console.WriteLine(isim + " isimli/soyisimli kişinin hangi bilgisini güncellemek istiyorsunuz ? \n1- İsim\n2- Soyisim\n3- Numara");
                Console.Write("Seçiminiz : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (secim)
                {
                    case 1:
                        Console.Write("Yeni ismi giriniz : ");
                        string yeniIsim = Console.ReadLine();
                        isimler[index] = yeniIsim;
                        Console.WriteLine(" ");
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + yeniIsim + "\nSoyisim : " + soyisimler[index] + "\nNumara : " + numaralar[index]);
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.Write("Yeni soyismi giriniz : ");
                        string yeniSoyisim = Console.ReadLine();
                        isimler[index] = yeniSoyisim;
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + isimler[index] + "\nSoyisim : " + yeniSoyisim + "\nNumara : " + numaralar[index]);
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.Write("Yeni numarayı giriniz : ");
                        long yeniNumara = Convert.ToInt32(Console.ReadLine());
                        isimler[index] = yeniNumara;
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + isimler[index] + "\nSoyisim : " + soyisimler[index] + "\nNumara : " + yeniNumara);
                        Console.WriteLine(" ");
                        break;
                }
            }
            else if (soyisimler.Contains(isim))
            {
                int index = soyisimler.IndexOf(isim);

                Console.WriteLine(isim + " isimli/soyisimli kişinin hangi bilgisini güncellemek istiyorsunuz ? \n1- İsim\n2- Soyisim\n3- Numara");
                Console.Write("Seçiminiz : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (secim)
                {
                    case 1:
                        Console.Write("Yeni ismi giriniz : ");
                        string yeniIsim = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + yeniIsim + "\nSoyisim : " + soyisimler[index] + "\nNumara : " + numaralar[index]);
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.Write("Yeni soyismi giriniz : ");
                        string yeniSoyisim = Console.ReadLine();
                        isimler[index] = yeniSoyisim;
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + isimler[index] + "\nSoyisim : " + yeniSoyisim + "\nNumara : " + numaralar[index]);
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.Write("Yeni numarayı giriniz : ");
                        long yeniNumara = Convert.ToInt32(Console.ReadLine());
                        isimler[index] = yeniNumara;
                        Console.WriteLine("--- GÜNCELLENEN BİLGİLER ---");
                        Console.WriteLine("İsim : " + isimler[index] + "\nSoyisim : " + soyisimler[index] + "\nNumara : " + yeniNumara);
                        Console.WriteLine(" ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.\nLütfen bir seçim yapınız : ");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                Console.Write("Seçiminiz : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {

                }
                else if (secim == 2)
                {
                    NumaraGuncelle();
                }
            }
        }
        public void RehberiListele()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*****************************");
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine("isim : " + isimler[i]);
                Console.WriteLine("soyisim : " + soyisimler[i]);
                Console.WriteLine("Telefon numarası : " + numaralar[i]);
                Console.WriteLine("-");
            }
        }
        public void NumaraKayıt()
        {
            Console.WriteLine(" ");
            Console.Write("Lütfen isim giriniz : ");
            string isim = Console.ReadLine();
            isimler.Add(isim);
            Console.Write("Lütfen soyisim giriniz : ");
            string soyisim = Console.ReadLine();
            soyisimler.Add(soyisim);
            Console.Write("Lütfen numarayı giriniz : ");
            long numara = Convert.ToInt64(Console.ReadLine());
            numaralar.Add(numara);
            Console.WriteLine(" ");
        }
        public void RehberdeArama()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz : ");
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            Console.Write("Seçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (secim == 1)
            {
                Console.Write("İsim veya soyisim giriniz : ");
                string isim = Console.ReadLine();
                Console.WriteLine("Arama sonuçlarınız : ");
                Console.WriteLine("*********************");
                Console.WriteLine(" ");

                if (isimler.Contains(isim))
                {
                    int index = isimler.IndexOf(isim);
                    Console.WriteLine("İsim : " + isimler[index]);
                    Console.WriteLine("Soyisim : " + soyisimler[index]);
                    Console.WriteLine("Telefon Numarası : " + numaralar[index]);
                    Console.WriteLine("-");
                }
                else if (soyisimler.Contains(isim))
                {
                    int index = soyisimler.IndexOf(isim);
                    Console.WriteLine("İsim : " + isimler[index]);
                    Console.WriteLine("Soyisim : " + soyisimler[index]);
                    Console.WriteLine("Telefon Numarası : " + numaralar[index]);
                    Console.WriteLine("-");
                }
            }
            else if (secim == 2)
            {
                Console.Write("Telefon numarası giriniz : ");
                long numara = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(" ");

                if (numaralar.Contains(numara))
                {
                    Console.WriteLine("Arama sonuçlarınız : ");
                    Console.WriteLine("*********************");
                    Console.WriteLine(" ");

                    int index = numaralar.IndexOf(numara);
                    Console.WriteLine("-");
                    Console.WriteLine("İsim : " + isimler[index]);
                    Console.WriteLine("Soyisim : " + soyisimler[index]);
                    Console.WriteLine("Telefon Numarası : " + numaralar[index]);
                    Console.WriteLine("-");
                }
            }
        }
        public void Cikis()
        {
            Console.WriteLine("--- İŞLEM SONLANDIRILDI ---");
        }
    }
}