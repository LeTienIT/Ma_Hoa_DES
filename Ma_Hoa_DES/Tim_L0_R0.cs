using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    public class Tim_L0_R0
    {
        public int[] P_nhiphan = new int[64];
        public int[] key = new int[Danh_Sach_Bang.IP.Length];
        public int[] L0 = new int[32];
        public int[] R0 = new int[32];

        public void nhapKey()
        {
            /*Console.ReadKey();
            Console.WriteLine("Nhập bản mã nhị phân: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            if (numbers.Length != 64)
            {
                Console.WriteLine("Số lượng phần tử không hợp lệ.");
                return;
            }

            for (int i = 0; i < 64; i++)
            {
                if (!int.TryParse(numbers[i], out P_nhiphan[i]))
                {
                    Console.WriteLine("Giá trị không hợp lệ.");
                    return;
                }
            }*/
            Chuyen_Doi_Nhi_Phan cdnp = new Chuyen_Doi_Nhi_Phan();
            cdnp.chuyen_doi_P();
            cdnp.hienThi_P();
            Console.WriteLine("");
            cdnp.inputP.CopyTo(P_nhiphan, 0);
            Console.WriteLine("");
            Console.WriteLine("==========================Kết quả Đối chiếu P VỚI BẢNG I_P TA ĐƯỢC==========================");
            Console.WriteLine("");
            for (int i = 0; i < Danh_Sach_Bang.IP.Length; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    if ((Danh_Sach_Bang.IP[i] - 1) == j)
                    {
                        key[i] = P_nhiphan[j];
                    }
                }
            }
            int tach = 1;
            for (int i = 0; i < Danh_Sach_Bang.IP.Length; i++)
            {
                Console.Write(key[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine("");

            for (int i = 0; i < 32; i++)
            {
                L0[i] = key[i];
                R0[i] = key[i + 32];
            }
            Console.WriteLine("");
            Console.WriteLine("==========================L0 VÀ R0 TƯƠNG ỨNG TỪ BẢN MÃ TRÊN==========================");
            Console.WriteLine("");
            Console.Write("0: ");
            for (int i = 0; i < 32; i++)
            {
                Console.Write(L0[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                Console.Write(R0[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;

            }
            Console.WriteLine("");
        }
        public int[] getL0()
        {
            return L0;
        }
        public int[] getR0()
        {
            return R0;
        }
    }
}
