using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Bai4
    {
        static void Main(string[] args)
        {
            double soGio, soTien;
            string maNhanVien;

            Console.WriteLine("Nhap ma nhan vien: ");
            maNhanVien = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap so gio: ");
            soGio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so tien: ");
            soTien = Convert.ToDouble(Console.ReadLine());

            double L = soTien * soGio;
            Console.WriteLine("Luong cua {0}: {1}", maNhanVien, L);
        }
    }
}
