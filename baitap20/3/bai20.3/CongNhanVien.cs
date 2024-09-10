using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCB
{
    abstract class CongNhanVien
    {
        protected string maso;
        protected string hoten;
        protected bool gioitinh;
        public virtual void Input()
        {
            Console.Write("Nhap ma so: ");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();

            Console.Write("Nhap gioi tinh(True/False): ");
            while (!bool.TryParse(Console.ReadLine(), out gioitinh))
            {
                Console.Write("Nhap gioi tinh(True/False): ");
            }
        }

        public abstract float TinhLuong();
        public virtual void Output()
        {
            Console.WriteLine($"Ma so: {maso}");
            Console.WriteLine($"Ho ten: {hoten}");
            Console.WriteLine($"Tien luong: {TinhLuong()}");
        }
    }

    class NhanVienHanhChinh : CongNhanVien
    {
        int ngaycong;
        float luongthang;

        public override float TinhLuong()
        {
            return (float)(ngaycong * luongthang / 26);
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so ngay cong: ");
            while (!int.TryParse(Console.ReadLine(), out ngaycong))
            {
                Console.Write("Nhap lai so ngay cong: ");
            }
            Console.Write("Nhap luong thang: ");
            while (!float.TryParse(Console.ReadLine(), out luongthang))
            {
                Console.Write("Nhap lai luong thang: ");
            }
        }
    }

    class GiaoVien : CongNhanVien
    {
        protected int sotiet;
        protected float luong1tiet;
        public override float TinhLuong()
        {
            return (float)(sotiet * luong1tiet);
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so tiet: ");
            while (!int.TryParse(Console.ReadLine(), out sotiet))
            {
                Console.Write("Nhap lai so tiet: ");
            }
            Console.Write("Nhap thu la mot tiet: ");
            while (!float.TryParse(Console.ReadLine(), out luong1tiet))
            {
                Console.Write("Nhap lai thu la mot tiet: ");
            }
        }
    }
}
