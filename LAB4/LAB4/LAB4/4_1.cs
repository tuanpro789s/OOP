using Microsoft.Win32;
using System;

namespace LAB4
{
    internal class PTB1
    {
        protected float b;
        protected float c;
        public PTB1()
        {
            b = 0;
            c = 0;
        }
        public PTB1(float b, float c)
        {
            this.b = b;
            this.c = c;
        }
        public void NHAP()
        {
            Console.Write("Nhap he so b: ");
            while(!float.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Nhap lai he so b: ");
            }
            Console.Write("Nhap he so c: ");
            while(!float.TryParse(Console.ReadLine(),out c))
            {
                Console.Write("Nhap lai he so c: ");
            }
        }
        public void GIAI()
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem duy nhat:" + (-c / b));
            }
        }
        public void XUAT()
        {
            if (c < 0)
            {
                Console.WriteLine($"{b}x - {c*-1} = 0");
            }
            else
            {
                Console.WriteLine($"{b}x + {c} = 0");
            }
        }
    }
    class PTB2 : PTB1
    {
        float a;
        public PTB2():base()
        {
            a = 0;
        }
        public PTB2(float a, float b, float c):base(b,c)
        {
            this.a = a;
        }
        public new void NHAP()
        {
            Console.Write("Nhap he so a: ");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Nhap lai he so a: ");
            }
            base.NHAP();
        }
        public new void XUAT()
        {
            Console.Write($"{a}x^2 + ");
            base.XUAT();
        }
        public new void GIAI()
        {
            if(a == 0)
            {
                base.GIAI();
            }
            else
            {
                float del = b * b - (4 * a * c);
                if( del < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (del == 0)
                {
                    float x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {x}");
                }
                else
                {
                    float x1 = (-b + (float)Math.Sqrt(del)) / (2 * a);
                    float x2 = (-b - (float)Math.Sqrt(del)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet x1= {x1} va x2 = {x2}");
                }
            }
        }
    }
}