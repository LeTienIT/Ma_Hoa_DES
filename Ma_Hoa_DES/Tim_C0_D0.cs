using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    public class Tim_C0_D0
    {
        public int[] Co = new int[28];
        public int[] Do = new int[28];
        public int[] keyNhiPhan = new int[64];
        public int[] key = new int[Danh_Sach_Bang.PC1.Length];
        public Tim_C0_D0()
        {

        }
        public void nhapKey()
        {
            /*Console.WriteLine("Nhập key nhị phân: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' '); 

            if (numbers.Length != 64)
            {
                Console.WriteLine("Số lượng phần tử không hợp lệ.");
                return;
            }

            for (int i = 0; i < 64; i++)
            {
                if (!int.TryParse(numbers[i], out keyNhiPhan[i]))
                {
                    Console.WriteLine("Giá trị không hợp lệ.");
                    return;
                }
            }*/
            Chuyen_Doi_Nhi_Phan cdnp = new Chuyen_Doi_Nhi_Phan();
            cdnp.chuyen_doi_K();
            cdnp.hienThi_Key();
            cdnp.inputKey.CopyTo(keyNhiPhan, 0);
            Console.WriteLine("");
            Console.WriteLine("==========================Kết quả Đối chiếu KEY VỚI BẢNG PC_1 TA ĐƯỢC==========================");
            Console.WriteLine(""); 
            for (int i=0;i<Danh_Sach_Bang.PC1.Length;i++)
            {
                for(int j=0;j<64;j++)
                {
                    if((Danh_Sach_Bang.PC1[i] - 1) == j)
                    {
                        key[i] = keyNhiPhan[j];
                    }
                }
            }
            int tach = 1;
            for (int i = 0; i < Danh_Sach_Bang.PC1.Length; i++)
            {
                Console.Write(key[i]+" ");
                if(tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine("");

            for (int i = 0; i < 28; i++)
            {
                Co[i] = key[i];
                Do[i] = key[i + 28];
            }
            Console.WriteLine("");
            Console.WriteLine("==========================C0 VÀ D0 TƯƠNG ỨNG TỪ BẢN MÃ TRÊN==========================");
            Console.WriteLine("");
            Console.Write("0: ");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(Co[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(Do[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
                
            }
        }
        public int[] getCo()
        {
            return Co;
        }
        public int[] getDo()
        {
            return Do;
        }

    }
}
