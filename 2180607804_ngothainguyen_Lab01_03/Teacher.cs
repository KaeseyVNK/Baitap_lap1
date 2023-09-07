using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2180607804_ngothainguyen_Lab01_03
{
    class Teacher : Person
    {
        public String DiaChi;
        public Teacher()
        {

        }
        public Teacher(string maso, string hoten, string diachi )
                  : base(maso, hoten)
        {

            DiaChi = diachi;
        }
        
   
        public void Nhap()
        {
            Console.Write("Nhap ma teacher:");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten teacher");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi :");
            DiaChi = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("MS:{0} \t Ho Ten:{1} \t DiaChi:{2}", this.maso, this.hoten,this.DiaChi);
        }
    }
}
