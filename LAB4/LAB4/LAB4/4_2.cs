using System;

namespace LAB4
{
    internal class Phone
    {
        protected string maso;
        protected string nhanhieu;
        private decimal gianhap;
        protected int namsx;

        public decimal Gianhap { get => gianhap; set => gianhap = value; }

        public Phone()
        {
        }
        public Phone(string maso = " ", string nhanhieu = " ", decimal gianhap = 0, int namsx = 2020)
        {
            this.maso = maso;
            this.nhanhieu = nhanhieu;
            this.Gianhap = gianhap;
            this.namsx = namsx;
        }
        public void NHAP()
        {
            Console.Write("Nhap ma so: ");
            maso = Console.ReadLine();
            Console.Write("nhap nha hieu: ");
            nhanhieu = Console.ReadLine();
            Console.Write("Nhap gia dien thoai: ");
            while (!decimal.TryParse(Console.ReadLine(), out gianhap))
            {
                Console.Write("Nhap lai gia dien thoai: ");
            }
            Console.Write("Nhap nam san xuat: ");
            while (!int.TryParse(Console.ReadLine(),out namsx))
            {
                Console.Write("Nhap lai nam san xuat: ");
            }
        }
        public void XUAT()  
        {
            Console.WriteLine($"{maso}\t{nhanhieu}\t{Gianhap}\t{namsx}");
        }
        public decimal TinhThue()
        {
            if(nhanhieu == "Iphone")
        {
                return (decimal)0.1 * Gianhap;
            }
        else return (decimal)0.05 * Gianhap;
        }
    }  
    class SmartPhone : Phone
    {
        short dungluong;
        public SmartPhone(string maso = " ", string nhanhieu = " ", decimal gianhap = 0, int namsx = 2020, short d = 128) : base(){
            dungluong = d;
        }
        public new void NHAP()
        {
            base.NHAP();
            Console.Write("Nhap dung luong bo nho: ");
            while (!short.TryParse(Console.ReadLine(), out dungluong))
            {
                Console.Write("Nhap lai dung luong bo nho: ");
            }
        }
        public new void XUAT()
        {
            base.XUAT();
            Console.WriteLine($"\t{dungluong}");
        }
        public decimal TinhGiaBan()
        {
            decimal tien = Gianhap + TinhThue();
            if (dungluong >= 128)
            {
                tien = tien + Gianhap * (decimal)0.2;
            }
            else if(dungluong>16)
            {
                tien = tien + Gianhap * (decimal)0.1;
            }
            else
            {
                tien = tien + Gianhap * (decimal)0.05;
            }
            return tien;
        }

    }
    class DS_DTTM
    {
        int n;
        SmartPhone[] ds;
        public void NhapDS()
        {
            Console.Write("Nhap so luong DTTM: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 30)
            {
                Console.Write("Nhap lai so luong DTTM: ");
            }
            ds = new SmartPhone[n];
            for (int i = 0; i < n; i++)
            {
                ds[i] = new SmartPhone();
                ds[i].NHAP();
            }
        }
        public void SapXep()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i +1 ; j < n; j++)
                {
                    if (ds[i].Gianhap < ds[j].Gianhap)
                    {
                        SmartPhone tam = new SmartPhone();
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        public void XuatDS()
        {
            foreach (SmartPhone x in ds)
            {
                    x.XUAT();
            }
        }
    }
}