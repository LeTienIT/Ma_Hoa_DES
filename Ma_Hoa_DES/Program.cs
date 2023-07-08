using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Dich_C0_D0 d = new Dich_C0_D0();
            //d.dich();
            //d.hienthiDich();
            //d.key_16();
            //d.hienthi_16key();
            //Tim_L0_R0 t = new Tim_L0_R0();
            //t.nhapKey();
            //int[] R0 = { 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            Dich_L0_R0 d = new Dich_L0_R0();
            //d.timEr(R0);
            //d.hienthiEr();
            d.tim_L_R();
            d.hienthi_L_R();
            d.tim_Ma();
            //Chuyen_Doi_Nhi_Phan cd = new Chuyen_Doi_Nhi_Phan();
            //cd.chuyen_doi();
            //cd.hienThi_P();cd.hienThi_Key();
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
