using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2180607804_ngothainguyen_Lab01_03
{
    class Student : Person
    {

        public Student(string maso,string hoten,string khoa, float? diemtb)
            :base(maso,hoten)
        {
            Diemtb = diemtb;
            Khoa = khoa;
        }

        public Student()
        {

        }
        public string Khoa { get; set; }
        public float? Diemtb { get; set; }
        public void nhap()
        {
            Console.Write("Nhap MSSV:");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem trung binh:");
            Diemtb = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("MSSV:{0} \t Ho Ten:{1} \t Khoa:{2} \t Diemtb{3}", this.maso, this.hoten, this.Khoa, this.Diemtb);
        }
    }
}
