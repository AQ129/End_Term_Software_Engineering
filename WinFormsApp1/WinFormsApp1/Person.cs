using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp1
{
    public class Person
    {
        private string  maNV;
        private string matKhau;
        private string ho;
        private string ten;
        private string sdt;
        private string email;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string tinhTrang;
        private string quyen;
        private string maBP;
        private string tenBP;
        private string tenNhom;
        private string maNhom;
        private byte[] hinhAnh;
        private string chucVu;
        private string phanLoai;
        public Person() 
        { 
        }

        public Person(string maNV, string matKhau, string ho, string ten, string sdt, string email, DateTime ngaySinh, string gioiTinh, string tinhTrang, string quyen, byte[] hinhAnh)
        {
            this.maNV = maNV;
            this.matKhau = matKhau;
            this.ho = ho;
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.tinhTrang = tinhTrang;
            this.quyen = quyen;
            this.hinhAnh = hinhAnh;
        }

        public Person(string maNV, string matKhau, string ho, string ten, string sdt, string email, DateTime ngaySinh, string gioiTinh, string tinhTrang, string quyen, string maBP, string tenBP, string tenNhom, string maNhom, byte[] hinhAnh, string chucVu, string phanLoai)
        {
            MaNV = maNV;
            MatKhau = matKhau;
            Ho = ho;
            Ten = ten;
            Sdt = sdt;
            Email = email;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            TinhTrang = tinhTrang;
            Quyen = quyen;
            MaBP = maBP;
            TenBP = tenBP;
            TenNhom = tenNhom;
            MaNhom = maNhom;
            HinhAnh = hinhAnh;
            ChucVu = chucVu;
            PhanLoai = phanLoai;
            MaNV = maNV;
            MatKhau = matKhau;
            Ho = ho;
            Ten = ten;
            Sdt = sdt;
            Email = email;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            TinhTrang = tinhTrang;
            Quyen = quyen;
            HinhAnh = hinhAnh;
            MaBP = maBP;
            MaNhom = maNhom;
            TenBP = tenBP;
            TenNhom = tenNhom;
            ChucVu = chucVu;
            PhanLoai = phanLoai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
    }
}
