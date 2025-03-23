using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp6
{
    public class Hocsinh
    {
        string mahs;

        public string Mahs { get => mahs; set => mahs = value; }
       
        string tenhs;
        public string Tenhs { get => tenhs; set => tenhs = value; }

        public List<Monhoc> dsmh = new List<Monhoc>();

        int n;
        public void NhapHs()
        {
            Console.Write("Nhap ma hoc sinh: ");
            Mahs = Console.ReadLine();
            Console.Write("Nhap ten hoc sinh: ");
            Tenhs = Console.ReadLine();
            Console.Write("Nhap so luong mon: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap thong tin mon hoc");
                Monhoc mh = new Monhoc();
                mh.Nhap();

                dsmh.Add(mh);
            }


        }

        public void XuatHs()
        {
            Console.WriteLine("\nThong tin hoc sinh");
            Console.WriteLine("\nMa hoc sinh: " + Mahs);
            Console.WriteLine("Ten hoc sinh: " + Tenhs);
            Console.WriteLine("\nDanh sach mon hoc");
            foreach(Monhoc x in dsmh)
            {
                x.Xuat();
            }
        }




        public double diemTB()
        {
            if (dsmh.Count == 0)
            {
                return 0;
            }
            return dsmh.Sum(mh => mh.DiemTongKet()) / dsmh.Count;
        }




        public string Xeploaihs()
        {
            double tb = diemTB();
            bool dk1 = dsmh.Any(mh1 => mh1.DiemTongKet() >= 6.5);
            bool dk2 = dsmh.Any(mh1 => mh1.DiemTongKet() >= 5.0);
            bool dk3 = dsmh.Any(mh1 => mh1.DiemTongKet() >= 3.5);
            bool dk4 = dsmh.Any(mh1 => mh1.DiemTongKet() >= 2.0);
            if (tb >= 8.0 && dk1)
            {
                return "Gioi";
            }
            else if (tb >=6.5 && dk2)
            {
                return "Kha";
            }
            else if (tb >= 5.0 && dk3)
            {
                return "Trung Binh";
            }
            else if (tb >= 3.5 && dk4)
            {
                return "Yeu";
            }
            else
            {
                return "Kem";
            }
        }





        public string kqht()
        {
            string kq = Xeploaihs();
            if (kq == "Gioi" || kq == "Kha" || kq == "Trung Binh")
            {
                return "Duoc len lop";
            }
            else if (kq == "Kem")
            {
                return "Thi lai";
            }
            else
            {
                return "O lai lop";
            }
        }










    }
}
