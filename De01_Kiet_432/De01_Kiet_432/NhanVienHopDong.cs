using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_Kiet_432
{
    internal class NhanVienHopDong : NhanVien
    {
        private int soNgayLamViec;

        public NhanVienHopDong()
        {
        }

        public NhanVienHopDong(string maNV, string hoTen, DateTime ngayTD, int soNgayLamViec) : base(maNV, hoTen, ngayTD)
        {
            this.soNgayLamViec = soNgayLamViec;
        }

        public int SoNgayLamViec { get => soNgayLamViec; set => soNgayLamViec = value; }
        public double TinhTien()
        {
            if (SoNgayLamViec <= 10)
                return SoNgayLamViec * 100000;
            else return 1000000 + (SoNgayLamViec - 10) * 200000;
        }

        public override string ToString()
        {
            return string.Format("{0,-5}{1,-10}{2,-13}{3,-15}{4,-10}", MaNV, HoTen, NgayTD.ToShortDateString(), SoNgayLamViec,TinhTien());
        }
    }
}
