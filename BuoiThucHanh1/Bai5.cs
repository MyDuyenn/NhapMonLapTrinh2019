using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiThucHanh1
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int n, to100, tam, to50, to20, to10, to5, to2, to1;
            Console.WriteLine("Nhap so tien: ");
            n = Convert.ToInt32(Console.ReadLine());
            to100 = n / 100;
            tam = n % 100;
            to50 = tam / 50;
            tam = tam % 50;
            to20 = tam / 20;
            tam = tam % 20;
            to10 = tam / 10;
            tam = tam % 10;
            to5 = tam / 5;
            tam = tam % 5;
            to2 = tam / 2;
            tam = tam % 2;
            to1 = tam / 1;
            tam = tam % 1;

            Console.WriteLine("So to 100: " + to100);
            Console.WriteLine("So to 50: " + to50);
            Console.WriteLine("So to 20: " + to20);
            Console.WriteLine("So to 10: " + to10);
            Console.WriteLine("So to 5: " + to5);
            Console.WriteLine("So to 2: " + to2);
            Console.WriteLine("So to 1: " + to1);
        }
    }
}
