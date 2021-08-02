using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    abstract class NoiThat
    {
        string Ten; //Tên
        public string getTen() {  return Ten; }
        public void setTen(string Ten) { this.Ten = Ten; }
        string MaSanPham;
        public string getMaSanPham() { return MaSanPham; }
        public void setMaSanPham(string MaSanPham) { this.MaSanPham = MaSanPham; }
        string KichThuoc;
        public string getKichThuoc() { return KichThuoc; }
        public void setKichThuoc(string KichThuoc) { this.KichThuoc = KichThuoc; }
        string VatLieu;
        public string getVatLieu() { return VatLieu; }
        public void setVatLieu(string VatLieu) { this.VatLieu = VatLieu; }
        string MauSac;
        public string getMauSac() { return MauSac; }
        public void setMauSac(string MauSac) { this.MauSac = MauSac; }
        string HangSanXuat;
        public string getHangSanXuat() { return HangSanXuat; }
        public void setHangSanXuat(string HangSanXuat) { this.HangSanXuat = HangSanXuat; }
        string NoiSanXuat;
        public string getNoiSanXuat() { return NoiSanXuat; }
        public void setNoiSanXuat(string NoiSanXuat) { this.NoiSanXuat = NoiSanXuat; }
        int Gia; //Giá
        public int getGia() { return Gia; }
        public void setGia(int Gia) { this.Gia = Gia; }
        int SoLuong; // Số lượng
        public int getSoLuong() { return SoLuong; }
        public void setSoLuong(int SoLuong) { this.SoLuong = SoLuong; }
        int SoDaBan; // Đã bán
        public int getSoDaBan() { return SoDaBan; }
        public void setSoDaBan(int SoDaBan) { this.SoDaBan = SoDaBan; }
        //DateTime NgayNhapHang; // Ngày Nhập Hàng

        public virtual void NhapThongTin(ArrayList arrNoiThat)
        {
            Menu.MenuNhapThongTin();
            int iChucNang = int.Parse(Console.ReadLine());
            switch (iChucNang)
            {
                case 1: // Nhập Tên
                    {
                        Console.Write("Tên           : ");
                        Ten = Console.ReadLine();
                        break;
                    }
                case 0:
                    {
                        Program.Programming(arrNoiThat);
                        break;
                    }
            }
            //Console.WriteLine("Hãng Sản Xuất : ");
            //Console.WriteLine("Nơi Sản Xuất  : ");
        }
        public virtual void XuatThongTin()
        {

        }
    }
}
