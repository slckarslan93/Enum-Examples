using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sıcaklık = 30;

            if (sıcaklık<= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya Çıkmak İçin Havanın biraz daha ısınmasını bekleyelim");
            }
            else if (sıcaklık>=(int)HavaDurumu.soguk)
            {
                Console.WriteLine("Sıcak Bir gün");
            }
            else if (sıcaklık>=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hadi dışarıya çıkalım");
            }

        }
    }

    enum Gunler
    {
        pazartesi =1,
        salı,
        çarşamba,
        perşembe,
        cuma=23,
        cumartesi,
        pazar
    }
    enum HavaDurumu
    {
        soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30,
    }

}
