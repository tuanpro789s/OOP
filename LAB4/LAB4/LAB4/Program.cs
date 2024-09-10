using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        static void BAI4_1()
        {
            //khoi tao khong tham so ptb1
            Console.WriteLine("Khoi tao PTB1");
            PTB1 pt1= new PTB1();
            pt1.NHAP();
            pt1.XUAT();
            pt1.GIAI();
            //khoi tao khong tham so ptb2
            Console.WriteLine("Khoi tao PTB2");
            PTB2 pt2= new PTB2();
            pt2.NHAP();
            pt2.XUAT();
            pt2.GIAI();
        }
        static void BAI4_2()
        {
            DS_DTTM ds= new DS_DTTM();
            ds.NhapDS();
            ds.SapXep();
            ds.XuatDS();
        }
        static void Main(string[] args)
        {
            BAI4_2();
            Console.ReadKey();
        }
    }
}
