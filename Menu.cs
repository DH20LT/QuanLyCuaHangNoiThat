using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    class Menu
    {
        public static void MenuMain()
        {
            Console.Title = Program.getName();
            Console.WriteLine("==========================================");
            Console.WriteLine("| 1. Tạo Đối Tượng                       |");
            Console.WriteLine("| 2. Lọc Đối Tượng                       |");
            Console.WriteLine("| 3. Cập Nhật Đối Tượng                  |");
            Console.WriteLine("| 0. Thoát Chương Trình                  |");
            Console.WriteLine("==========================================");
            Console.Write("Nhập chức năng: ");
        }
        public static void MenuCreate()
        {
            Console.Title = "Tạo Đối Tượng" + Program.getName();
            Console.WriteLine("==========================================");
            Console.WriteLine("| 1. Tạo Đối Tượng Bàn                   |");
            Console.WriteLine("| 2. Tạo Đối Tượng                       |");
            Console.WriteLine("| 3. Tạo Đối Tượng                       |");
            Console.WriteLine("| 4. Tạo Đối Tượng                       |");
            Console.WriteLine("| 5. Tạo Đối Tượng Xuất                  |");
            Console.WriteLine("| 6. Tạo Đối Tượng                       |");
            Console.WriteLine("| 7. Tạo Đối Tượng                       |");
            Console.WriteLine("| 8. Tạo Đối Tượng                       |");
            Console.WriteLine("| 9. Tạo Đối Tượngn                      |");
            Console.WriteLine("| 0. Về Menu Chính                       |");
            Console.WriteLine("==========================================");
            Console.Write("Nhập chức năng: ");
        }
        public static void MenuNhapThongTin() 
        {
            Console.Title = "Nhập Thông Tin" + Program.getName();
            Console.WriteLine("==========================================");
            Console.WriteLine("| 1. Nhập Tên                            |");
            Console.WriteLine("| 2. Nhập Mã Sản Phẩm                    |");
            Console.WriteLine("| 3. Nhập Kích Thước                     |");
            Console.WriteLine("| 4. Nhập Vật Liệu                       |");
            Console.WriteLine("| 5. Nhập Hãng Sản Xuất                  |");
            Console.WriteLine("| 6. Nhập Nơi Sản Xuất                   |");
            Console.WriteLine("| 7. Nhập Giá                            |");
            Console.WriteLine("| 8. Nhập Số Lượng                       |");
            Console.WriteLine("| 9. Nhập Số Đã Bán                      |");
            Console.WriteLine("| 0. Hoàn Tất Nhập                       |");
            Console.WriteLine("==========================================");
            Console.Write("Nhập chức năng: ");
        }
        public static void MenuFilter()
        {
            Console.Title = "Lọc Đối Tượng" + Program.getName();
            Console.WriteLine("=================================");
            Console.WriteLine("| 1. Hiện Đối Tượng Bàn");
        }
        public static void MenuUpdate()
        {
            Console.Title = "Cập Nhật Đối Tượng" + Program.getName();
        }
    }
}
