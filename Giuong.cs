using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    class Giuong : NoiThat //Giường
    {
        public Giuong()
        {
            setTen("");
            setMaSanPham("");
            setKichThuoc("");
            setVatLieu("");
            setMauSac("");
            setHangSanXuat("");
            setNoiSanXuat("");
            setGia(0);
            setSoLuong(0);
            setSoDaBan(0);
        }
        public Giuong(string Ten,
                    string MaSanPham,
                    string KichThuoc,
                    string VatLieu,
                    string MauSac,
                    string HangSanXuat,
                    string NoiSanXuat,
                    int Gia,
                    int SoLuong,
                    int SoDaBan)
        {
            setTen(Ten);
            setMaSanPham(MaSanPham);
            setKichThuoc(KichThuoc);
            setVatLieu(VatLieu);
            setMauSac(MauSac);
            setHangSanXuat(HangSanXuat);
            setNoiSanXuat(NoiSanXuat);
            setGia(Gia);
            setSoLuong(SoLuong);
            setSoDaBan(SoDaBan);
        }
        public override void NhapThongTin(ArrayList arrNoiThat, int i)
        {
            Console.Clear();
            Console.Title = "Nhập Đối Tượng Giường" + Program.getName();
            base.NhapThongTin(arrNoiThat, i);
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
        public void CapNhatThongTin(ArrayList arrNoiThat, int i)
        {
            base.NhapThongTin(arrNoiThat, i);
        }
    }
}
