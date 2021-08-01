using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.QuanLyCuaHangNoiThat
{
    abstract class NoiThat
    {
        string Ten; //Tên
        public string getTen() {  return Ten; }
        public void setTen(string Ten) { this.Ten = Ten; }
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
        int DaBan; // Đã bán
        public int getDaBan() { return DaBan; }
        public void setDaBan(int DaBan) { this.DaBan = DaBan; }
        //DateTime NgayNhapHang; // Ngày Nhập Hàng
        public virtual void NhapThongTin()
        {
            Console.WriteLine("Tên           : ");
            Ten = Console.ReadLine();
            Console.WriteLine("Hãng Sản Xuất : ");
            Console.WriteLine("Nơi Sản Xuất  : ");
        }
        public virtual void XuatThongTin()
        {

        }
    }
}
