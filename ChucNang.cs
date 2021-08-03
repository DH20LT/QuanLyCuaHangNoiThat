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
                            //ban.XuatThongTin();
                            //Console.ReadLine();
                            arrNoiThat.Add(ban);
                            ban.NhapThongTin(arrNoiThat, 2);

                            /*Console.WriteLine(arrNoiThat.Count);
                            Console.ReadLine();
                            CreateObject(arrNoiThat);*/

                            break;
                        }
                    case 2: // Tạo Đối Tượng Ghế
                        {
                            Ghe ghe = new Ghe();
                            arrNoiThat.Add(ghe);
                            ghe.NhapThongTin(arrNoiThat, 3);
                            break;
                        }
                    default:
                        Console.WriteLine("Không Có Chức Năng Này! Enter để nhập lại");
                        Console.ReadLine();
                        ChucNang.CreateObject(arrNoiThat);
                        break;
                }
            } while (iChucNang > 0);
        }
        static void HienTatCa(ArrayList arrNoiThat)
        {
            for (int i = 0; i < arrNoiThat.Count; i++)
            {
                Ban ban = new Ban();
                Ghe ghe = new Ghe();
                Type ia = arrNoiThat[i].GetType();
                Type iBan = ban.GetType();
                Type iGhe = ghe.GetType();
                if (ia.Equals(iBan))
                {
                    ban = (Ban)arrNoiThat[i];
                    ban.XuatThongTin();
                }
                else if (ia.Equals(iGhe))
                {
                    ghe = (Ghe)arrNoiThat[i];
                    ghe.XuatThongTin();
                }
                else
                {
                    break;
                }
            }
        }
        public static void FilterObject(ArrayList arrNoiThat)
        {
            Console.Clear();
            Menu.MenuFilter();
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrNoiThat);
                            break;
                        }
                    case 1: //Lọc Ra Đối Tượng Bàn
                        {
                            /*Console.WriteLine(arrNoiThat.Count);
                            Console.ReadKey();
                            Ban ban1 = new Ban();
                            ban1 = (Ban)arrNoiThat[0];
                            ban1.XuatThongTin();*/

                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Ban ban = new Ban();
                                Type ia = arrNoiThat[i].GetType();
                                Type iBan = ban.GetType();
                                if (ia.Equals(iBan))
                                {
                                    ban = (Ban)arrNoiThat[i];
                                    ban.XuatThongTin();
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 11: // Hiện Tất Cả Đối Tượng 
                        {
                            HienTatCa(arrNoiThat);
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    default:
                        Console.WriteLine("Không Có Chức Năng Này! Enter để nhập lại");
                        Console.ReadLine();
                        ChucNang.FilterObject(arrNoiThat);
                        break;
                }
            }while (iChucNang > 0);
        }
        public static void UpdateObject(ArrayList arrNoiThat)
        {

        }
    }
}
