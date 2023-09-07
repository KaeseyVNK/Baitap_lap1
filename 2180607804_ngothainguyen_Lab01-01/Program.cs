using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2180607804_ngothainguyen_Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh doan so !!");
            Random random = new Random();
            int sochon = random.Next(100, 999);
            string targetString = sochon.ToString();
            int solan = 1, solanlonnhat = 7;
            string doan, ketquaphanhoi = "";
            while (ketquaphanhoi != "+++" && solan<=solanlonnhat)
            {
                Console.Write("Lan doan thu {0} ", solan);
                doan = Console.ReadLine();
                ketquaphanhoi = Getketquaphanhoi(targetString, doan);
                Console.WriteLine("Phan hoi tu may tinh : {0}", ketquaphanhoi);
                solan++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan, tro choi ket thuc !", solan - 1);
            if(solan>solanlonnhat)
            
                Console.WriteLine("Nguoi choi thua cuoc ! , ket qua can doan la {0}", sochon);
            else
            Console.WriteLine("Nguoi choi thang cuoc!", solan);
            Console.ReadLine();
        }
    static string Getketquaphanhoi(string muctieu, string doan)
        {
            string ketquaphanhoi = "";
            for(int i=0;i<muctieu.Length;i++)
            {
                if (muctieu[i] == doan[i])
                    ketquaphanhoi += "+";
                else if (muctieu.Contains(doan[i].ToString()))
                    ketquaphanhoi += "?";
            }
            return ketquaphanhoi;
        }
    }

}
