using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Bai3
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Nhap so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToDouble(Console.ReadLine());

            double c = (a * 3.5 + b * 7.5) / 11;
            Console.WriteLine("Diem trung binh: {0:0.00}", c);
        }
    }
}
