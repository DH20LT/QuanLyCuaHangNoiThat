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
            Console.Title = Program.Name;
            Console.WriteLine("==========================================");
            Console.WriteLine("| 1. Tạo Đối Tượng  |");
            Console.WriteLine("| 2. Lọc Đối Tượng |");
            Console.WriteLine("| 3. Thoát Chương Trình         |");
            Console.WriteLine("==========================================");
            Console.Write("Nhập chức năng: ");
        }
        public static void MenuCreate()
        {
            Console.Title = "Tạo Đối Tượng" + Program.Name;
        }
        public static void MenuFilter()
        {
            Console.Title = "Lọc Đối Tượng" + Program.Name;
            Console.WriteLine("=================================");
            Console.WriteLine("| 1. Hiện Đối Tượng Bàn");
        }
    }
}
