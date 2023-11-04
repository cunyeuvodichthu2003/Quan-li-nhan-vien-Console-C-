using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_Kiet_432
{
    internal class Program
    {   static void GenerateMenu()
        {
            Console.WriteLine("1. Nhap nhan vien");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Sap xep");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Lua chon cua ban: ");
            
        }
        static void Nhap(List<NhanVien> list)
        {
            int n = 0;
            do
            {
                Console.WriteLine("1. Nhan vien binh thuong");
                Console.WriteLine("2. Nhan vien hop dong");
                Console.WriteLine("Nhap loai nhan vien: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 && n > 2);
            if(n==1)
            {
                NhanVien nv = new NhanVien();
                Console.WriteLine("Nhap ma nhan vien: ");
                nv.MaNV = Console.ReadLine();
                if(list.Contains(nv))
                {
                    Console.WriteLine("Da co nhan vien nay!");
                    return;
                }
                Console.WriteLine("Nhap ten nhan vien: ");
                nv.HoTen = Console.ReadLine();
                Console.WriteLine("Nhap ngay tuyen dung: ");
                nv.NgayTD = DateTime.Parse(Console.ReadLine());
                list.Add(nv);

            }
            if(n==2)
            {
                NhanVienHopDong nv = new NhanVienHopDong();
                Console.WriteLine("Nhap ma nhan vien: ");
                nv.MaNV = Console.ReadLine();
                if (list.Contains(nv))
                {
                    Console.WriteLine("Da co nhan vien nay!");
                    return;
                }
                Console.WriteLine("Nhap ten nhan vien: ");
                nv.HoTen = Console.ReadLine();
                Console.WriteLine("Nhap ngay tuyen dung: ");
                nv.NgayTD = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so ngay lam viec: ");
                nv.SoNgayLamViec = int.Parse(Console.ReadLine());
                list.Add(nv);

            }
        }
        static void HienThi(List<NhanVien> list)
        {
            Console.WriteLine(string.Format("{0,-5}{1,-10}{2,-13}{3,-15}{4,-10}", "MaNV", "HoTen", "NgayTD", "SoNgayLamViec", "TongTien"));
            foreach (var khach in list)
                Console.WriteLine( khach.ToString());
        }
        static void SapXep(List<NhanVien> list)
        {
            list.Sort(delegate (NhanVien sv1, NhanVien sv2)
            {
                if (sv1.NgayTD.CompareTo(sv2.NgayTD) != 0)
                    return sv1.NgayTD.Date.CompareTo(sv2.NgayTD.Date);
                else return sv1.HoTen.CompareTo(sv2.HoTen);
            });
            HienThi(list);
        }
        static void Main(string[] args)
        {
            int n = 0;
            List<NhanVien> list = new List<NhanVien>();
            do
            {
                GenerateMenu();
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Nhap(list);
                }
                if (n == 2)
                {
                    HienThi(list);
                }
                if (n == 3)
                {
                    SapXep(list);
                }
                if (n == 4)
                    break;
            } while (true);
        }
    }
}
