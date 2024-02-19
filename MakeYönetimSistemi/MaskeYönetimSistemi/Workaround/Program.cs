using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim:"Enes");
            int sonuc = Topla(7,8);

            

            Console.ReadLine();
        }

        static void SelamVer(string isim="noname")  // nonamede default olarak noname
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1 = 5,int sayi2= 3) // default değerleri de atadık
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam :" + sonuc.ToString());
            return sonuc;
        }
    }
}
