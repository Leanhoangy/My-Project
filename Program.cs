using ConsoleApp6;

Danhsachhocsinh dshs = new Danhsachhocsinh();

while (true)
{
    Console.Clear();
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. Nhap danh sach hoc sinh");
    Console.WriteLine("2. Xuat danh sach hoc sinh");
    Console.WriteLine("3. In thong tin 1 hoc sinh theo ma");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon chuc nang: ");
    string chon = Console.ReadLine();

    switch (chon)
    {
        case "1":
            dshs.Nhapdshs();
            break;
        case "2":
            dshs.Xuatdshs();
            break;
        case "3":
            dshs.inds();
            break;
        case "0":
            Console.WriteLine("Tam biet!");
            return;
        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }
}