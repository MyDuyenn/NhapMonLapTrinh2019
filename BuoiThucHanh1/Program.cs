using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien a va b
            double a, b;
            Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap gia tri cua b: ");
            b = Convert.ToDouble(Console.ReadLine());

            //Doi gia tri cua a va b
            double c;
            c = a;
            a = b;
            b = c;

            //Xuat gia tri
            Console.WriteLine("Gia tri a sau khi doi la: {0}, b sau khi doi la: {1}", a, b);

        }
    }
}
