using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mypartialderivative;

namespace Mypartialderivative_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivative obj1 = new MyDerivative();
            string secim;
            Console.WriteLine("kısmi türev alma şuan sadece \n f(z)=(sayı.x^sayı)+(sayı.y^sayı) \n" +
            "tipindeki fonksiyonda çalışmaktadır \n (örnk= f(z)=2x^3+5y^2 \n");
            Console.WriteLine("x'in katsayısını yazınız.");
            int xkat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x'in üssünü yazınız");
            int xussu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y'nin katsayısını yazınız.");
            int ykatsayı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y'nin üssünü yazınız");
            int yus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x için mi y için mi kısmi türev almak istersiniz : ");
            secim = Console.ReadLine();
            if (secim=="x")
            {
                obj1.Tkat = xkat;
                obj1.Tus = xussu;
            }
            else if (secim=="y")
            {
                obj1.Tkat = ykatsayı;
                obj1.Tus = yus;
            }
            obj1.Hesapla();
            if (secim == "x")
            {
                Console.WriteLine(obj1.Tsonuckat + secim + "^" + obj1.Tsonucus + "+" + ykatsayı + "y^" + yus);
            }
            else if (secim == "y")
            {
                Console.WriteLine(" fonksiyonun türevlenmiş hali " + obj1.Tsonuckat + secim + "^" + obj1.Tsonucus + "+" + xkat + "y^" + xussu);
            }
            Console.ReadKey();
        }
    }
}