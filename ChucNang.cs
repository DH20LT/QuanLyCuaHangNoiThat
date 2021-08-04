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
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrNoiThat);
                            break;
                        }
                    case 1: // Tạo Đối Tượng Bàn
                        {
                            Ban ban = new Ban();
                            arrNoiThat.Add(ban);
                            ban.NhapThongTin(arrNoiThat, 1);
                            break;
                        }
                    case 2: // Tạo Đối Tượng Ghế
                        {
                            Ghe ghe = new Ghe();
                            arrNoiThat.Add(ghe);
                            ghe.NhapThongTin(arrNoiThat, 2);
                            break;
                        }
                    case 3: // Tạo Đối Tượng Tủ
                        {
                            Tu tu = new Tu();
                            arrNoiThat.Add(tu);
                            tu.NhapThongTin(arrNoiThat, 3);
                            break;
                        }
                    case 4: // Tạo Đối Tượng Kệ
                        {
                            Ke ke = new Ke();
                            arrNoiThat.Add(ke);
                            ke.NhapThongTin(arrNoiThat, 4);
                            break;
                        }
                    case 5: // Tạo Đối Tượng Giường
                        {
                            Giuong giuong = new Giuong();
                            arrNoiThat.Add(giuong);
                            giuong.NhapThongTin(arrNoiThat, 5);
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
        static int UpdateReturn(ArrayList arrNoiThat, int i)
        {
            int SoDinhMenh = 0;
            for (int j = 0; j < arrNoiThat.Count; j++)
            {
                Ban ban = new Ban();
                Ghe ghe = new Ghe();
                Tu tu = new Tu();
                Ke ke = new Ke();
                Giuong giuong = new Giuong();

                Type ia = arrNoiThat[i].GetType();

                Type iBan = ban.GetType();
                Type iGhe = ghe.GetType();
                Type iTu = tu.GetType();
                Type iKe = ke.GetType();
                Type iGiuong = giuong.GetType();
                if (ia.Equals(iBan))
                {
                    SoDinhMenh = 1;
                }
                else if (ia.Equals(iGhe))
                {
                    SoDinhMenh = 2;
                }
                else if (ia.Equals(iTu))
                {
                    SoDinhMenh = 3;
                }
                else if (ia.Equals(iKe))
                {
                    SoDinhMenh = 4;
                }
                else if (ia.Equals(iGiuong))
                {
                    SoDinhMenh = 5;
                }
            }
            return SoDinhMenh;
        }
        static void HienTatCa(ArrayList arrNoiThat, int HienNao)
        {
            for (int i = 0; i < arrNoiThat.Count; i++)
            {
                Ban ban = new Ban();
                Ghe ghe = new Ghe();
                Tu tu = new Tu();
                Ke ke = new Ke();
                Giuong giuong = new Giuong();

                Type ia = arrNoiThat[i].GetType();

                Type iBan = ban.GetType();
                Type iGhe = ghe.GetType();
                Type iTu = tu.GetType();
                Type iKe = ke.GetType();
                Type iGiuong = giuong.GetType();
                switch(HienNao)
                {
                    case 0: // Hiện Hết Thông Tin
                        {
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
                            else if (ia.Equals(iTu))
                            {
                                tu = (Tu)arrNoiThat[i];
                                tu.XuatThongTin();
                            }
                            else if (ia.Equals(iKe))
                            {
                                ke = (Ke)arrNoiThat[i];
                                ke.XuatThongTin();
                            }
                            else if (ia.Equals(iGiuong))
                            {
                                giuong = (Giuong)arrNoiThat[i];
                                giuong.XuatThongTin();
                            }
                            else
                            {
                                break;
                            }
                            break;
                        }
                    case 1: // Hiện Tên + Đánh Số
                        {
                            int TempIndex = i+1;
                            if (ia.Equals(iBan))
                            {
                                ban = (Ban)arrNoiThat[i];
                                Console.WriteLine(TempIndex + ". " + ban.getTen());
                            }
                            else if (ia.Equals(iGhe))
                            {
                                ghe = (Ghe)arrNoiThat[i];
                                Console.WriteLine(TempIndex + ". " + ghe.getTen());
                            }
                            else if (ia.Equals(iTu))
                            {
                                tu = (Tu)arrNoiThat[i];
                                Console.WriteLine(TempIndex + ". " + tu.getTen());
                            }
                            else if (ia.Equals(iKe))
                            {
                                ke = (Ke)arrNoiThat[i];
                                Console.WriteLine(TempIndex + ". " + ke.getTen());
                            }
                            else if (ia.Equals(iGiuong))
                            {
                                giuong = (Giuong)arrNoiThat[i];
                                Console.WriteLine(TempIndex + ". " + giuong.getTen());
                            }
                            else
                            {
                                break;
                            }
                            break;
                        }
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
                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Ban ban = new Ban();
                                Type ia = arrNoiThat[i].GetType();
                                Type iBan = ban.GetType();
                                if (ia.Equals(iBan))
                                {
                                    ban = (Ban)arrNoiThat[i];
                                    ban.XuatThongTin("Loại Bàn", ban.getLoaiBan());
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 2: //Lọc Ra Đối Tượng Ghế
                        {
                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Ghe ghe = new Ghe();
                                Type ia = arrNoiThat[i].GetType();
                                Type iGhe = ghe.GetType();
                                if (ia.Equals(iGhe))
                                {
                                    ghe = (Ghe)arrNoiThat[i];
                                    ghe.XuatThongTin("Loại Ghế", ghe.getLoaiGhe());
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 3: //Lọc Ra Đối Tượng Tủ
                        {
                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Tu tu = new Tu();
                                Type ia = arrNoiThat[i].GetType();
                                Type iTu = tu.GetType();
                                if (ia.Equals(iTu))
                                {
                                    tu = (Tu)arrNoiThat[i];
                                    tu.XuatThongTin();
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 4: //Lọc Ra Đối Tượng Kệ
                        {
                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Ke ke = new Ke();
                                Type ia = arrNoiThat[i].GetType();
                                Type iKe = ke.GetType();
                                if (ia.Equals(iKe))
                                {
                                    ke = (Ke)arrNoiThat[i];
                                    ke.XuatThongTin();
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 5: //Lọc Ra Đối Tượng Giường
                        {
                            for (int i = 0; i < arrNoiThat.Count; i++)
                            {
                                Giuong giuong = new Giuong();
                                Type ia = arrNoiThat[i].GetType();
                                Type iGiuong = giuong.GetType();
                                if (ia.Equals(iGiuong))
                                {
                                    giuong = (Giuong)arrNoiThat[i];
                                    giuong.XuatThongTin();
                                }
                            }
                            Console.ReadKey();
                            ChucNang.FilterObject(arrNoiThat);
                            break;
                        }
                    case 11: // Hiện Tất Cả Đối Tượng 
                        {
                            HienTatCa(arrNoiThat, 0);
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
            } while (iChucNang > 0);
        }
        public static void UpdateObject(ArrayList arrNoiThat)
        {
            // Step 1 = Show all object as Namw and assign to it a number for choose
            Console.Clear();
            HienTatCa(arrNoiThat, 1);
            Console.WriteLine("Bạn muốn cập nhật Đối Tượng Nào? - 0 Để Hủy");
            int iCapNhat = int.Parse(Console.ReadLine());
            int iTempIndex = iCapNhat-1;
            if (iCapNhat == 0)
            {
                Program.Programming(arrNoiThat);
            }
            else
            switch (UpdateReturn(arrNoiThat, iTempIndex))
            {
                case 0:
                    {
                        break;
                    }
                case 1: // Bàn
                    {
                        Ban ban = new Ban();
                        ban = (Ban)arrNoiThat[iTempIndex];
                        ban.XuatThongTin("Loại Bàn", ban.getLoaiBan());
                        ban.CapNhatThongTin(arrNoiThat, 1);
                        arrNoiThat.Insert(iTempIndex, ban);
                        break; 
                    }
                case 2: //Ghế
                    {
                        Ghe ghe = new Ghe();
                        ghe = (Ghe)arrNoiThat[iTempIndex];
                        ghe.XuatThongTin("Loại Ghế", ghe.getLoaiGhe());
                        ghe.CapNhatThongTin(arrNoiThat, 2);
                        arrNoiThat.Insert(iTempIndex, ghe);
                        break;
                    }
                case 3: // Tủ
                    {
                        Tu tu = new Tu();
                        tu = (Tu)arrNoiThat[iTempIndex];
                        tu.CapNhatThongTin(arrNoiThat, 3);
                        arrNoiThat.Insert(iTempIndex, tu);
                        break;
                    }
                case 4: //Kệ
                    {
                        Ke ke = new Ke();
                        ke = (Ke)arrNoiThat[iTempIndex];
                        ke.CapNhatThongTin(arrNoiThat, 3);
                        arrNoiThat.Insert(iTempIndex, ke);
                        break;
                    }
                case 5: // Giường
                    {
                        Giuong giuong = new Giuong();
                        giuong = (Giuong)arrNoiThat[iTempIndex];
                        giuong.CapNhatThongTin(arrNoiThat, 3);
                        arrNoiThat.Insert(iTempIndex, giuong);
                        break;
                    }
            }
        }
        public static void UpdateObjectBeautiful(ArrayList arrNoiThat)
        { }
        public static int MultipleChoice(bool canCancel, params ArrayList[] options)
        {
            const int startX = 15;
            const int startY = 8;
            const int optionsPerLine = 3;
            const int spacingPerLine = 14;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}
