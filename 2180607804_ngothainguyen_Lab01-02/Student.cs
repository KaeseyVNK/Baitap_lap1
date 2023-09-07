using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2180607804_ngothainguyen_Lab01_02
{
    class Student
    {
        private string mssv;
        private string hoten;
        private float dtb;
        private string khoa;

        public string Mssv { get => mssv; set => mssv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public float Dtb { get => dtb; set => dtb = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public Student()
        {

        }
    public Student(string mssv, string hoten, float dtb, string khoa)
        {
           this.mssv = mssv;
           this.hoten= hoten;
           this.dtb = dtb;
           this.khoa= khoa;
        }
    public void nhap()
        {
            Console.Write("Nhap MSSV:");
            mssv = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem trung binh:");
            dtb = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            khoa = Console.ReadLine();
        }
    public void xuat()
        {
            Console.WriteLine("MSSV:{0} Ho Ten:{1} Khoa:{2} Diemtb{3}", this.Mssv, this.Hoten, this.Khoa, this.Dtb);
        }
    }
}
