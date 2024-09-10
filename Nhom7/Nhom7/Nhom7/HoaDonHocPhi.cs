using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom7
{
    class HoaDonHocPhi
    {
        public int SoHoaDon;
        public List<KhoaHoc> DanhSach;

    public HoaDonHocPhi(int soHoaDon)
        {
            SoHoaDon = soHoaDon;
            DanhSach = new List<KhoaHoc>();
        }


        public void NhapThongTin()
        {
            Console.Write("Nhao so luong hoa don: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin khoa hoc thu {i + 1}:");
                Console.Write("Ma khoa hoc: ");
                string maKhoaHoc = Console.ReadLine();


                KhoaHoc khoaHoc = new KhoaHoc();
                DanhSach.Add(khoaHoc);
            }
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"So hoa don: {SoHoaDon}");
            Console.WriteLine("Danh sach cach khoa hoc :");
            foreach (var khoaHoc in DanhSach)
            {
                khoaHoc.XuatThongTin();
                Console.WriteLine();
            }
        }


        public double TinhTienTrungBinh()
        {
            double tongThanhTien = 0;
            foreach (var khoaHoc in DanhSach)
            {
                tongThanhTien = tongThanhTien + khoaHoc.TinhThanhTien();
            }
            double tienTrungBinh = tongThanhTien / DanhSach.Count;
            return tienTrungBinh;
        }
    }
}
