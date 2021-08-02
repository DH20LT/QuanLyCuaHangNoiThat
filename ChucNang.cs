using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat
{
    class ChucNang
    {
        public static void CreateObject(ArrayList arrNoiThat)
        {
            Console.Clear();
            Menu.MenuCreate();
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch(iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrNoiThat);
                            break;
                        }
                    case 1: // Tạo Đối Tượng Bàn
                        {
                            Ban ban = new Ban();
                            ban.NhapThongTin(arrNoiThat);
                            arrNoiThat.Add(ban);
                            break;
                        }
                }
            } while (iChucNang > 0);
        }
        public static void FilterObject(ArrayList arrNoiThat)
        {
            Menu.MenuFilter();
        }
        public static void UpdateObject(ArrayList arrNoiThat)
        {

        }
    }
}
