using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin hoa don :");
            Console.Write("So hoa don: ");
            int soHoaDon = int.Parse(Console.ReadLine());

            HoaDonHocPhi hoaDon = new HoaDonHocPhi(soHoaDon);
            hoaDon.NhapThongTin();

            Console.WriteLine("\n Thong tin hoa don:");
            hoaDon.XuatThongTin();

            double tienTrungBinh = hoaDon.TinhTienTrungBinh();
            Console.WriteLine($"\nTien trung binh la: {tienTrungBinh:C}");

            Console.ReadLine();
        }
    }
}
