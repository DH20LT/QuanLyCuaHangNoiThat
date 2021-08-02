using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    class Ban : NoiThat
    {
        
        public Ban()
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
        public Ban( string Ten, 
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
        public override void NhapThongTin(ArrayList arrNoiThat)
        {
            Console.Clear();
            Console.WriteLine("Nhập Đối Tượng Bàn");
            base.NhapThongTin(arrNoiThat);
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}
