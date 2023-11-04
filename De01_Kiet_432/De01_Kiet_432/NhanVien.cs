using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_Kiet_432
{
    internal class NhanVien
    {
        private string maNV;
        private string hoTen;
        private DateTime ngayTD;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgayTD { get => ngayTD; set => ngayTD = value; }

        public NhanVien(string maNV, string hoTen, DateTime ngayTD)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngayTD = ngayTD;
        }

        public NhanVien()
        {
        }

        public override string ToString()
        {
            return string.Format("{0,-5}{1,-10}{2,-13}{3,-15}{4,-10}", MaNV, HoTen, NgayTD.ToShortDateString(), " - "," - ");
        }

        public override bool Equals(object obj)
        {
            return obj is NhanVien vien &&
                   MaNV == vien.MaNV;
        }
    }
}
