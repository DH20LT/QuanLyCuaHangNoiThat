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
        string LoaiBan;
        public string getLoaiBan() { return LoaiBan; }
        public void setLoaiBan(string LoaiBan) { this.LoaiBan = LoaiBan; }
        public Ban()
        {
            setTen("");
            setMaSanPham("");
            setLoaiBan("");
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
                    string LoaiBan,
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
            setLoaiBan(LoaiBan);
            setKichThuoc(KichThuoc);
            setVatLieu(VatLieu);
            setMauSac(MauSac);
            setHangSanXuat(HangSanXuat);
            setNoiSanXuat(NoiSanXuat);
            setGia(Gia);
            setSoLuong(SoLuong);
            setSoDaBan(SoDaBan);
        }
        public static void ExtendProperties(Ban ban)
        {
            ban.setLoaiBan(Console.ReadLine());
        }
        public override void NhapThongTin(ArrayList arrNoiThat, int i)
        {
            Console.Clear();
            base.NhapThongTin(arrNoiThat, i);
            Console.Write("Loại Bàn      : ");
            setLoaiBan(Console.ReadLine());
            Console.Clear();
            base.NhapThongTin(arrNoiThat, i);
        }
        
        public override void XuatThongTin(string CachGoi, string GiaTri)
        {
            base.XuatThongTin(CachGoi, GiaTri);
        }
        public void CapNhatThongTin(ArrayList arrNoiThat, int i)
        {
            base.NhapThongTin(arrNoiThat, i);
            Console.Write("Loại Bàn      : ");
            setLoaiBan(Console.ReadLine());
            Console.Clear();
            base.NhapThongTin(arrNoiThat, i);
        }
    }
}
