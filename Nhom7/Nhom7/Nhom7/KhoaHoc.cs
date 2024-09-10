using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom7
{
    class KhoaHoc
    {
        public string MaKhoaHoc;
        public string TenMonHoc;
        public int SoTiet;
        public double HocPhi;
        public DateTime NgayDangKi;

        public KhoaHoc()
        {


        }
        public KhoaHoc(string maKhoaHoc, string tenMonHoc, int soTiet, double hocPhi, DateTime ngayDangKi)
        {
            MaKhoaHoc = maKhoaHoc;
            TenMonHoc = tenMonHoc;
            SoTiet = soTiet;
            HocPhi = hocPhi;
            NgayDangKi = ngayDangKi;
        }
        public double TinhThanhTien()
        {
            double tienGiam = 0;
            if (NgayDangKi.Month == 9)
                tienGiam = 0.15 * HocPhi;
            else if (NgayDangKi.Month == 10)
                tienGiam = 0.10 * HocPhi;
            double thanhTien = HocPhi - tienGiam + 0.05 * HocPhi;
            return thanhTien;
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Ten khoa hoc: {TenMonHoc}");
            Console.WriteLine($"Hoc phi: {HocPhi:C}");
            Console.WriteLine($"Ngay dang ki: {NgayDangKi:dd/MM/yyyy}");
            Console.WriteLine($"Thanh tien: {TinhThanhTien():C}");
        }
    }
}
