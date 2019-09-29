using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Bai2
    {
        static void Main(string[] args)
        {
            double r, pi = 3.14159;
            Console.WriteLine("Nhap ban kinh r: ");
            r = Convert.ToDouble(Console.ReadLine());
            double A = pi * r * r;
            Console.WriteLine("Dien tich hinh tron la: {0:0.00}", A);

        }
    }
}
