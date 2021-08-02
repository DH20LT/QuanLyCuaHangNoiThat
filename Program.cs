using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace QuanLyCuaHangNoiThat
{
    class Program
    {
        const string NameOfProgram = "Quản Lý Cửa Hàng Nội Thất";
        public static string getName() { return NameOfProgram; }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = ("Quản Lý Cửa Hàng Nội Thất");
            ArrayList arrNoiThat = new ArrayList();
            Programming(arrNoiThat);
        }
        public static void Programming(ArrayList arrNoiThat)
        {
            Console.Clear();
            Menu.MenuMain();
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch(iChucNang)
                {
                    case 0: // Thoát
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            ChucNang.CreateObject(arrNoiThat);
                            break;
                        }
                    case 2:
                        {
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 3:
                        {
                            
                            break;
                        }
                    default:
                        Console.WriteLine("Không Có Chức Năng Này! Enter để nhập lại");
                        Console.ReadLine();
                        Program.Programming(arrNoiThat);
                        break;
                }
            } while (iChucNang > 0);
        }

        internal static void Programming(object arrNoiThat)
        {
            throw new NotImplementedException();
        }
    }
    
}
