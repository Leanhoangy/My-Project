using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Danhsachhocsinh
    {
        List<Hocsinh> dshocsinh = new List<Hocsinh>();
        
        public void Nhapdshs()
        {
            int n;
            Console.Write("\nNhap so luong hoc sinh: ");
            n = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                Hocsinh hss = new Hocsinh();
                hss.NhapHs();
                dshocsinh.Add(hss);
            }
        }




        public void Xuatdshs()
        {
            Console.WriteLine("\nDanh sach hoc sinh");
            foreach(Hocsinh x in dshocsinh)
            {
                x.XuatHs();
            }
        }



        public void inds()
        {
            string x;
            Console.Write("Nhap ma hs: ");
            x = Console.ReadLine();

            Hocsinh hs = dshocsinh.FirstOrDefault(h=>h.Mahs == x);
            if (hs != null)
            {
                Console.WriteLine($"\nThong tin hoc sinh:");
                Console.WriteLine($"Ma HS: {hs.Mahs}");
                Console.WriteLine($"Ten HS: {hs.Tenhs}");
                Console.WriteLine($"Diem TB: {hs.diemTB():0.00}");
                Console.WriteLine($"Xep loai: {hs.Xeploaihs()}");
                Console.WriteLine($"Ket qua hoc tap: {hs.kqht()}");
                foreach(Monhoc s in hs.dsmh)
                {
                    double point = s.DiemTongKet();
                    string status = point >= 5 ? "Dat" : "Khong dat";
                    Console.WriteLine($"{s.Mh} - Diem: {point:0.00} - {status}");

                }

            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh co ma: " + x);
            }
        }

    }
}
