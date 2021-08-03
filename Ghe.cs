using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    class Ghe : NoiThat
    {
        string LoaiGhe;
        public string getLoaiGhe() { return LoaiGhe; }
        public void setLoaiGhe(string LoaiGhe) { this.LoaiGhe = LoaiGhe; }
        public Ghe()
        {
            setTen("");
            setMaSanPham("");
            setLoaiGhe("");
            setKichThuoc("");
            setVatLieu("");
            setMauSac("");
            setHangSanXuat("");
            setNoiSanXuat("");
            setGia(0);
            setSoLuong(0);
            setSoDaBan(0);
        }
        public Ghe(string Ten,
                    string MaSanPham,
                    string LoaiGhe,
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
            setLoaiGhe(LoaiGhe);
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
            Console.Title = "Nhập Đối Tượng Ghế" + Program.getName();
            Console.WriteLine("Nhập Đối Tượng Ghế");
            base.NhapThongTin(arrNoiThat, i);
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}
