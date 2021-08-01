using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace QuanLyCuaHangNoiThat
{
    class Program
    {
        public const string Name = "Quản Lý Cửa Hàng Nội Thất";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = ("Quản Lý Cửa Hàng Nội Thất");
            ArrayList arrNoiThat = new ArrayList();
            Programming(arrNoiThat);
        }
        static void Programming(ArrayList arrNoiThat)
        {
            Menu.MenuMain();
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch(iChucNang)
                {
                    case 1:
                        {
                            ChucNang.CreateObject();
                            break;
                        }
                    case 2:
                        {
                            //ChucNang.FilterObject();
                            break;
                        }
                    case 3:
                        {
                            // to exit program

                            break;
                        }
                }
            } while (iChucNang > 0);
        }
    }
    
}
