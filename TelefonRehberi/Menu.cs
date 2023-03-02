using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Menu
    {
        Metotlar m1 = new Metotlar();
        public void IslemMenusu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni numara kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Varolan numarayı güncelleme");
            Console.WriteLine("(4) Rehberi listelemek");
            Console.WriteLine("(5) Rehberde arama yapmak");
            Console.WriteLine("(0) İşlemleri sonlandırma");
            Console.WriteLine("****************************************");

            Console.Write("Seçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    m1.NumaraKayıt();
                    IslemMenusu();
                    break;
                case 2:
                    m1.NumaraSil();
                    IslemMenusu();
                    break;
                case 3:
                    m1.NumaraGuncelle();
                    IslemMenusu();
                    break;
                case 4:
                    m1.RehberiListele();
                    IslemMenusu();
                    break;
                case 5:
                    m1.RehberdeArama();
                    IslemMenusu();
                    break;
                case 0:
                    m1.Cikis();
                    break;
            }
        }
    }
}
