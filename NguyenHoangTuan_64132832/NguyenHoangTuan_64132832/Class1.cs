using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangTuan_64132832
{
    internal class MucHangHoa
    {
        protected string MaHang;
        protected string TenHang;
        protected int SoLuong;
        protected decimal DonGia;
        protected string LoaiHang;
        public MucHangHoa() { }
        public MucHangHoa(string MaHang = " ", string TenHang = " ", int Soluong = 0, decimal DonGia = 0, string LoaiHang = " ")
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.SoLuong = Soluong;
            this.DonGia = DonGia;
            this.LoaiHang = LoaiHang;

        }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhap Ma Hang:");
            MaHang = Console.ReadLine();
            Console.WriteLine("Nhap Ten Hang:");
            TenHang = Console.ReadLine();
            do
            {


                Console.WriteLine("Nhap So Luong:");
            } while (!int.TryParse(Console.ReadLine(), out SoLuong) || SoLuong <= 0);
            Console.WriteLine("Nhap Don gia:");
            DonGia = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Loai Hang:");
            LoaiHang = Console.ReadLine();

        }
        public decimal GiaTheoLoai()
        {
            decimal Giatheoloai=1;
            if (LoaiHang == "A")
            {
                Giatheoloai = (decimal)1.5 * DonGia;
            }
            else if (LoaiHang == "B")
            {
                Giatheoloai = (decimal)1.2 * DonGia;
            }
            return Giatheoloai;

            

        }
        public decimal ThanhTien()
        {
            decimal ThanhTien;
            ThanhTien = SoLuong * GiaTheoLoai();
            return ThanhTien += ThanhTien * (decimal)0.8;
         }

        public void XuatThongTin()
        {
            Console.WriteLine($"{TenHang}\t{SoLuong}\t{GiaTheoLoai()}\t{ThanhTien()}");
        }
    }
    class HoaDonBanHang : MucHangHoa
    {
        protected int SoHoaDon;
        int n;
        HoaDonBanHang[] hd ;
        public HoaDonBanHang(string MaHang = " ", string TenHang = " ", int Soluong = 0, decimal DonGia = 0, string LoaiHang = " ", int SoHoaDon= 0 ,int n =0) 
        {

        }
        public void NHapHoaDonBanHang()
        {
            do
            {
                Console.WriteLine("Nhap so luong muc hang:");

            }while(!int.TryParse(Console.ReadLine(), out n)||n<=1||n>=20);
            hd = new HoaDonBanHang[n];
            for(int i=0; i < n;i++)
            {
                hd[i] = new HoaDonBanHang();
                hd[i].NhapThongTin();
            }
            Console.WriteLine("Nhap So Hoa Don:");
            SoHoaDon= int.Parse(Console.ReadLine());

        }
        public void XuatThongTinHoaDon()
        {
            foreach(HoaDonBanHang h in  hd)
            {
                h.XuatThongTin();
            }
        }
        public int DemSoLuongHoaDonA()
        {
            int dem = 0;
            foreach(HoaDonBanHang h in hd)
            {
                if (h.TenHang == "A")
                    dem++;
            }
            return dem;
        }

    }

}








































    




    