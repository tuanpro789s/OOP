using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangTuan_64132832
{
    internal class Program
    {
        static void Class1()
        {
            HoaDonBanHang hd = new HoaDonBanHang();
            hd.NHapHoaDonBanHang();
            hd.XuatThongTinHoaDon();
            hd.DemSoLuongHoaDonA();
        }
        static void Main(string[] args)
        {
            // de 11
            Class1();
            Console.ReadKey();
        }
    }
}
