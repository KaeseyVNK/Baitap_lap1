using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2180607804_ngothainguyen_Lab01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lists = new List<Student>();
            List<Teacher> listt = new List<Teacher>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("==========MENU===========");
                Console.WriteLine("1.   Them sinh vien");
                Console.WriteLine("2.   Them giao vien");
                Console.WriteLine("3.   Xuat Danh sach sinh vien");
                Console.WriteLine("4.   Xuat danh sach giao vien");
                Console.WriteLine("5.   Dem danh sach giao vien");
                Console.WriteLine("6.   Xuat danh sach cac Sinh vien thuoc khoa CNTT");
                Console.WriteLine("7.   Xuat danh sach giao vien o quan 9:");
                Console.WriteLine("8.   Xuat danh sach sinh vien DTB cao nhat va thuoc khoa CNTT");
                Console.WriteLine("9.   Xep loai hoc sinh");
                Console.WriteLine("0.   Thoát");
                Console.WriteLine("Xin hãy chọn chức năng (0-9):");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        ThemHocSinh(lists); break;
                    case "2":
                        Themgiaovien(listt);
                        break;
                    case "3":
                        Xuatdanhsach(lists); break;
                    case "4":
                        Xuatgiaovien(listt);
                        break;
                    case "5":
                        soluongdanhsach(listt, lists);
                        break;
                    case "6":
                        xuattheokhoa(lists, "CNTT");
                        break;
                    case "7":
                        xuattheodiachi(listt, "Quan 9");
                        break;
                    case "8":
                        xuatdanhsachtbvaCNTT(lists, "CNTT");
                        break;
                    case "9":
                        xeploai(lists);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void ThemHocSinh(List<Student> list)
        {
            Console.WriteLine("nhap thong tin sinh vien");
            Student student = new Student();
            student.nhap();
            list.Add(student);
            Console.WriteLine("them sinh vien thanh cong");
        }
        static void Xuatdanhsach(List<Student> lists)
        {
            Console.WriteLine("Danh sach chi tiet thong tin sinh vien");
            foreach (Student hocsinh in lists)
            {
                hocsinh.xuat();
            }
        }
        static void Themgiaovien(List<Teacher> listt)
        {
            Console.WriteLine("nhap thong tin sinh vien");
            Teacher teacher = new Teacher();
            teacher.Nhap();
            listt.Add(teacher);
            Console.WriteLine("them giao vien thanh cong");
        }
        static void Xuatgiaovien(List<Teacher> list)
        {
            Console.WriteLine("Danh sach chi tiet thong tin sinh vien");
            foreach (Teacher giaovien in list)
            {
                giaovien.Xuat();
            }
        }
        static void soluongdanhsach(List<Teacher> listt, List<Student> lists)
        {
            var demhocsinh = lists.Count();
            var demgiaovien = listt.Count();
            Console.WriteLine("So luong hoc sinh co trong danh sach : {0} \t So luong giao vien co trong danh sach :{1}", demhocsinh, demgiaovien);
        }
        static void xuattheokhoa(List<Student> lists, string khoa)
        {
            var students = lists.Where(s => s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase)).ToList();
            Xuatdanhsach(students);
        }
        static void xuattheodiachi(List<Teacher> listt, string diachi)
        {
            var teachers = listt.Where(s => s.DiaChi.IndexOf(diachi, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            Xuatgiaovien(teachers);
        }
        static void xuatdanhsachtbvaCNTT(List<Student> lists,string khoa)
        {
            var MaxDTB = (from s in lists where s.Khoa.Equals(khoa, StringComparison.OrdinalIgnoreCase) select s.Diemtb).Max();
            foreach (var student in lists)
            {
                if (student.Diemtb == MaxDTB && student.Khoa == khoa)
                    student.xuat();
            }
        }
        static void xeploai(List<Student> lists)
        {
            Console.WriteLine("==So Luong cua tung xep loai trong danh sach==");
            var xuatxac = lists.Where(s => s.Diemtb >= 9).Count();
            var gioi = lists.Where(s => s.Diemtb >= 8 && s.Diemtb < 9).Count();
            var kha = lists.Where(s => s.Diemtb >= 7 && s.Diemtb < 8).Count();
            var trungbinh = lists.Where(s => s.Diemtb >= 5 && s.Diemtb < 7).Count();
            var yeu = lists.Where(s => s.Diemtb >= 4 && s.Diemtb < 5).Count();
            var kem = lists.Where(s => s.Diemtb >= 4).Count();
            Console.WriteLine("Xuat Xac : {0} Gioi : {1} Kha : {2} Trung Binh : {3} Yeu : {4} Kem : {5}", xuatxac, gioi, kha, trungbinh, yeu, kem);
        }
    }
   }
