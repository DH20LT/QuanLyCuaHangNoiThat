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

        public void TestNewNhapThongTin()
        {
            Console.Write(Ten);
            Console.Write(MaSanPham);
            Console.ReadLine();
        }
        public virtual void NhapThongTin(ArrayList arrNoiThat, int i)
        {
            Menu.DrawMenuNhapThongTin(i);
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 1: // Nhập Tên
                        {
                            Console.Write("Tên           : ");
                            Ten = Console.ReadLine();
                            //TestNewNhapThongTin();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 2: //Nhập Mã Sản Phầm
                        {
                            Console.Write("Mã Sản Phầm   : ");
                            MaSanPham = Console.ReadLine();
                            //TestNewNhapThongTin();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 3: //Nhập Kích Thước
                        {
                            Console.Write("Kích Thước    : ");
                            KichThuoc = Console.ReadLine();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 4: //Nhập Vật Liệu
                        {
                            Console.Write("Vật Liệu      : ");
                            VatLieu = Console.ReadLine();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 5: //Nhập Màu Sắc
                        {
                            Console.Write("Màu Sắc       : ");
                            MauSac = Console.ReadLine();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 6: //Nhập Hãng Sản Xuất
                        {
                            Console.Write("Hãng Sản Xuất : ");
                            HangSanXuat = Console.ReadLine();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 7: //Nhập Nơi Sản Xuất
                        {
                            Console.Write("Nơi Sản Xuất  : ");
                            NoiSanXuat = Console.ReadLine();
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 8: //Nhập Giá
                        {
                            Console.Write("Giá           : ");
                            Gia = int.Parse(Console.ReadLine());
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 9: //Nhập Số Lượng
                        {
                            Console.Write("Số Lượng      : ");
                            SoLuong = int.Parse(Console.ReadLine());
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 10: //Nhập Số Đã Bán
                        {
                            Console.Write("Số Đã Bán     : ");
                            SoDaBan = int.Parse(Console.ReadLine());
                            NhapThongTin(arrNoiThat, i);
                            break;
                        }
                    case 11:
                        {
                            iChucNang = -1;
                            break;
                        }
                    case 12: // Quay Lại (Tạo Đối Tượng Khác)
                        {
                            ChucNang.CreateObject(arrNoiThat);
                            break;
                        }
                    case 0:
                        {
                            Program.Programming(arrNoiThat);
                            break;
                        }
                }
                if (iChucNang == -1)
                {
                    break;
                }
            } while(iChucNang > 0);
            //Console.WriteLine("Hãng Sản Xuất : ");
            //Console.WriteLine("Nơi Sản Xuất  : ");
        }
        
        public virtual void XuatThongTin()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("| Tên : " + Ten);
            Console.WriteLine("| Mã Sản Xuất : " + MaSanPham);
            Console.WriteLine("| Kích Thước : " + KichThuoc);
            Console.WriteLine("| Vật Liệu : " + VatLieu);
            Console.WriteLine("| Màu Sắc : " + MauSac);
            Console.WriteLine("| Hãng Sản Xuất : " + HangSanXuat);
            Console.WriteLine("| Nơi Sản Xuất : " + NoiSanXuat);
            Console.WriteLine("| Giá : " + Gia);
            Console.WriteLine("| Số Lượng : " + SoLuong);
            Console.WriteLine("| Số Đã Bán : " + SoDaBan);
            Console.WriteLine("==========================================");
        }
        public virtual void XuatThongTin(int i)
        {
            Console.WriteLine(Ten);
        }
        public virtual void XuatThongTin(string CachGoi, string GiaTri)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("| Tên : " + Ten);
            if (GiaTri.Equals(""))
            { } else
            { Console.WriteLine("| {0} : {1}", CachGoi, GiaTri); }
            Console.WriteLine("| Mã Sản Xuất : " + MaSanPham);
            Console.WriteLine("| Kích Thước : " + KichThuoc);
            Console.WriteLine("| Vật Liệu : " + VatLieu);
            Console.WriteLine("| Màu Sắc : " + MauSac);
            Console.WriteLine("| Hãng Sản Xuất : " + HangSanXuat);
            Console.WriteLine("| Nơi Sản Xuất : " + NoiSanXuat);
            Console.WriteLine("| Giá : " + Gia);
            Console.WriteLine("| Số Lượng : " + SoLuong);
            Console.WriteLine("| Số Đã Bán : " + SoDaBan);
            Console.WriteLine("==========================================");
        }
    }
}
