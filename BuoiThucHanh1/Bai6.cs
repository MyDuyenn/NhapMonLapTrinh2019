using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Bai6
    {
        static void Main(string[] args)
        {
            int n, gio, phut, giay, du;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            gio = n / 3600;
            du = n % 3600;
            phut = du / 60;
            du = du % 60;

            Console.WriteLine("Gio: " + gio);
            Console.WriteLine("Phut: " + phut);
            Console.WriteLine("Giay: " + du);
        }
    }
}
