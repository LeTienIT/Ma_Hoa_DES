using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    public class Dich_L0_R0
    {
        int[] R1 = new int[32]; int[] L1 = new int[32];
        int[] R2 = new int[32]; int[] L2 = new int[32];
        int[] R3 = new int[32]; int[] L3 = new int[32];
        int[] R4 = new int[32]; int[] L4 = new int[32];
        int[] R5 = new int[32]; int[] L5 = new int[32];
        int[] R6 = new int[32]; int[] L6 = new int[32];
        int[] R7 = new int[32]; int[] L7 = new int[32];
        int[] R8 = new int[32]; int[] L8 = new int[32];
        int[] R9 = new int[32]; int[] L9 = new int[32];
        int[] R10 = new int[32]; int[] L10 = new int[32];
        int[] R11 = new int[32]; int[] L11 = new int[32];
        int[] R12 = new int[32]; int[] L12 = new int[32];
        int[] R13 = new int[32]; int[] L13 = new int[32];
        int[] R14 = new int[32]; int[] L14 = new int[32];
        int[] R15 = new int[32]; int[] L15 = new int[32];
        int[] R16 = new int[32]; int[] L16 = new int[32];

        int[] Er = new int[48];
        int[] XOR = new int[48];
        int[] S = new int[8];
        int[] S_nhiphan = new int[32];
        int[] hoanviP = new int[32];
        int[] bang_Ma_Nhi_Phan = new int[Danh_Sach_Bang.IP_1.Length];

        int[] R00 = new int[32];
        int[] L00 = new int[32];
        public void timEr(int[] r)
        {
            for(int i = 0; i < Danh_Sach_Bang.E.Length; i++)
            {
                for(int j = 0; j < 32; j++)
                {
                    if((Danh_Sach_Bang.E[i]-1) == j)
                    {
                        Er[i] = r[j];
                    }
                }
            }
        }
        public void hienthiEr()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================BẢNG ĐỐI CHIẾU R TRONG BẢNG E==========================");
            int tach = 0;
            for (int i = 0; i < 48; i++)
            {
                tach++;
                Console.Write(Er[i]);
                if(tach == 6)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
            }
        }
        public void K_XOR_Er(int[] k)
        {
            for(int i = 0; i < 48; i++)
            {
                if(k[i] == Er[i])
                {
                    XOR[i] = 0;
                }
                else
                {
                    XOR[i] = 1;
                }
            }
        }
        public void hienthiXOR()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================K XOR Er==========================");
            int tach = 0;
            for (int i = 0; i < 48; i++)
            {
                tach++;
                Console.Write(XOR[i]);
                if (tach == 6)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
            }
            Console.WriteLine("");
        }
        public void tim_S()
        {
            int dem = 0; int j = 0; int k = 0;
            int[] tmp = new int[6];
            for (int i = 0; i < 48; i++)
            {
                tmp[j] = XOR[i];
                dem++;j++;
                if(dem == 6)
                {
                    int hang = tmp[0] * 2 + tmp[5];
                    int cot = tmp[1] * 8 + tmp[2] * 4 + tmp[3] * 2 + tmp[4];
                    switch(k)
                    {
                        case 0: S[k] = Danh_Sach_Bang.sBox1[hang,cot];break;
                        case 1: S[k] = Danh_Sach_Bang.sBox2[hang, cot]; break;
                        case 2: S[k] = Danh_Sach_Bang.sBox3[hang, cot]; break;
                        case 3: S[k] = Danh_Sach_Bang.sBox4[hang, cot]; break;
                        case 4: S[k] = Danh_Sach_Bang.sBox5[hang, cot]; break;
                        case 5: S[k] = Danh_Sach_Bang.sBox6[hang, cot]; break;
                        case 6: S[k] = Danh_Sach_Bang.sBox7[hang, cot]; break;
                        case 7: S[k] = Danh_Sach_Bang.sBox8[hang, cot]; break;
                    }
                    k++;
                    dem = 0;
                    j = 0;
                }
            }
        }
        public void hienthi_S()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================SÓ THẬP PHÂN QUA 8 BẢNG==========================");
            for (int i=0;i<8;i++)
            {
                Console.Write(S[i] + " ");
            }
            Console.WriteLine("");
        }
        public void timS_nhiphan()
        {
            for (int i = 0; i < S.Length; i++)
            {
                int number = S[i];
                int startIndex = 4 * i;

                for (int j = 0; j < 4; j++)
                {
                    int bitIndex = startIndex + (3 - j);
                    int bitValue = (number >> j) & 1;
                    S_nhiphan[bitIndex] = bitValue;
                }
            }
        }
        public void hienthi_S_nhiphan()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================DÃY NHỊ PHÂN TRONG S==========================");
            int tach = 0;
            for (int i = 0; i < S_nhiphan.Length; i++)
            {
                Console.Write(S_nhiphan[i] + " ");
                tach++;
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
        }
        public void timHoan_Vi_P()
        {
            for(int i=0;i<Danh_Sach_Bang.P.Length;i++)
            {
                for(int j=0;j<S_nhiphan.Length;j++)
                {
                    if((Danh_Sach_Bang.P[i]-1) == j)
                    {
                        hoanviP[i] = S_nhiphan[j];
                    }
                }
            }
        }
        public void hienthi_P()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================HOÁN VỊ QUA BẢNG P==========================");
            int tach = 0;
            for (int i = 0; i <hoanviP.Length; i++)
            {
                Console.Write(hoanviP[i] + " ");
                tach++;
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
            }
        }
        public int[] L_XOR_P(int[] l)
        {
            int[] tmp = new int[32];
            for(int i=0; i < l.Length; i++)
            {
                if(hoanviP[i] == l[i])
                {
                    tmp[i] = 0;
                }
                else
                {
                    tmp[i] = 1;
                }
            }
            return tmp;
        }
        public void hienthi_L_R()
        {
            int tach = 0;
            Console.WriteLine("==========================DANH SÁCH HOÁN VỊ 16 LẦN L0 - R0==========================");
            Console.WriteLine("");
            Console.Write("1: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L1[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R1[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //2
            Console.Write("2: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L2[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R2[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //3
            Console.Write("3: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L3[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R3[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //4
            Console.Write("4: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L4[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R4[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //5
            Console.Write("5: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L5[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R5[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //6
            Console.Write("6: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L6[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R6[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //7
            Console.Write("7: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L7[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R7[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //8
            Console.Write("8: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L8[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R8[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //9
            Console.Write("9: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L9[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R9[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //10
            Console.Write("10: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L10[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R10[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //11
            Console.Write("11: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L11[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R11[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //12
            Console.Write("12: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L12[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R12[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //13
            Console.Write("13: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L13[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R13[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //14
            Console.Write("14: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L14[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R14[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //15
            Console.Write("15: ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(L15[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R15[i] );
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
            //16
            Console.Write("16: ");
            for (int i = 0; i <32; i++)
            {
                tach++;
                Console.Write(L16[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 32; i++)
            {
                tach++;
                Console.Write(R16[i]);
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }

            }
            Console.WriteLine("");
        }
        public void tim_L_R()
        {
            Dich_C0_D0 dcd = new Dich_C0_D0();
            dcd.dich(); dcd.key_16();
            Console.WriteLine("");
            dcd.hienthiDich();
            Console.WriteLine("");
            dcd.hienthi_16key();
            Console.WriteLine("");
            Tim_L0_R0 tlr = new Tim_L0_R0();
            tlr.nhapKey();
            int[] R0 = new int[32];
            int [] L0 = new int[32];
            R0 = tlr.getR0(); L0= tlr.getL0();
            for(int i=1;i<=16;i++)
            {
                switch(i)
                {
                    case 1:
                        {
                            
                            L1 = R0;
                            timEr(R0);
                            K_XOR_Er(dcd.key1);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R1 = L_XOR_P(L0);
                            // hiển thị
                            Console.WriteLine("");
                            Console.WriteLine("L1-R1");
                            Console.WriteLine("");
                            hienthiEr();Console.WriteLine("");
                            hienthiXOR();Console.WriteLine("");
                            hienthi_S();Console.WriteLine("");
                            hienthi_S_nhiphan(); Console.WriteLine("");
                            hienthi_P(); Console.WriteLine("");
                        };break;
                    case 2:
                        {
                            L2 = R1;
                            timEr(R1);
                            K_XOR_Er(dcd.key2);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R2 = L_XOR_P(L1);
                            // hiển thị
                        }; break;
                    case 3:
                        {
                            L3 = R2;
                            timEr(R2);
                            K_XOR_Er(dcd.key3);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R3 = L_XOR_P(L2);
                        }; break;
                    case 4:
                        {
                            L4 = R3;
                            timEr(R3);
                            K_XOR_Er(dcd.key4);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R4 = L_XOR_P(L3);
                        }; break;
                    case 5:
                        {
                            L5 = R4;
                            timEr(R4);
                            K_XOR_Er(dcd.key5);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R5 = L_XOR_P(L4);
                        }; break;
                    case 6:
                        {
                            L6 = R5;
                            timEr(R5);
                            K_XOR_Er(dcd.key6);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R6 = L_XOR_P(L5);
                        }; break;
                    case 7:
                        {
                            L7 = R6;
                            timEr(R6);
                            K_XOR_Er(dcd.key7);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R7 = L_XOR_P(L6);
                        }; break;
                    case 8:
                        {
                            L8 = R7;
                            timEr(R7);
                            K_XOR_Er(dcd.key8);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R8 = L_XOR_P(L7);
                        }; break;
                    case 9:
                        {
                            L9 = R8;
                            timEr(R8);
                            K_XOR_Er(dcd.key9);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R9 = L_XOR_P(L8);
                        }; break;
                    case 10:
                        {
                            L10 = R9;
                            timEr(R9);
                            K_XOR_Er(dcd.key10);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R10 = L_XOR_P(L9);
                        }; break;
                    case 11:
                        {
                            L11 = R10;
                            timEr(R10);
                            K_XOR_Er(dcd.key11);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R11 = L_XOR_P(L10);
                        }; break;
                    case 12:
                        {
                            L12 = R11;
                            timEr(R11);
                            K_XOR_Er(dcd.key12);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R12 = L_XOR_P(L11);
                        }; break;
                    case 13:
                        {
                            L13 = R12;
                            timEr(R12);
                            K_XOR_Er(dcd.key13);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R13 = L_XOR_P(L12);
                        }; break;
                    case 14:
                        {
                            L14 = R13;
                            timEr(R13);
                            K_XOR_Er(dcd.key14);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R14 = L_XOR_P(L13);
                        }; break;
                    case 15:
                        {
                            L15 = R14;
                            timEr(R14);
                            K_XOR_Er(dcd.key15);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R15 = L_XOR_P(L14);
                        }; break;
                    case 16:
                        {
                            L16 = R15;
                            timEr(R15);
                            K_XOR_Er(dcd.key16);
                            tim_S();
                            timS_nhiphan();
                            timHoan_Vi_P();
                            R16 = L_XOR_P(L15);
                        }; break;
                }
            }
        }
        public void tim_Ma()
        {
            int[] sub_key = new int[L16.Length + R16.Length];
            Array.Copy(R16, 0, sub_key, 0, R16.Length);
            Array.Copy(L16, 0, sub_key, R16.Length, L16.Length);
            int tach = 0;
            Console.WriteLine("");
            Console.WriteLine("=========================Đây là bản được nối đảo R16 - L16=========================");
            Console.WriteLine("");
            for (int i = 0; i < sub_key.Length; i++)
            {
                Console.Write(sub_key[i]);
                tach++;
                if(tach == 8)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
            }
            for(int j = 0; j < Danh_Sach_Bang.IP_1.Length; j++)
            {
                for(int i=0; i<sub_key.Length;i++)
                {
                    if((Danh_Sach_Bang.IP_1[j] - 1) == i)
                    {
                        bang_Ma_Nhi_Phan[j] = sub_key[i];
                    }
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=========================Bảng mã sau khi đối chiếu qua bảng IP_1=========================");
            Console.WriteLine("");
            for (int i = 0; i < sub_key.Length; i++)
            {
                Console.Write(bang_Ma_Nhi_Phan[i]);
                tach++;
                if (tach == 8)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=========================Bảng quy đổi dãy nhị phân ra số nguyên=========================");
            Console.WriteLine("");
            int[] giatri_ASCII = new int[8];int jj=0; int k = 0;
            int[] bang_tmp = new int[8];
            for (int i = 0; i < sub_key.Length; i++)
            {
                bang_tmp[k] = bang_Ma_Nhi_Phan[i];
                tach++;k++;
                if (tach == 8)
                {
                    giatri_ASCII[jj] = (bang_tmp[0] * 128) + (bang_tmp[1] * 64) + (bang_tmp[2] * 32) + (bang_tmp[3] * 16) + (bang_tmp[4] * 8) + (bang_tmp[5] * 4) + (bang_tmp[6] * 2) + bang_tmp[7];
                    tach = 0;jj++; k = 0;
                }
            }
            for (int i = 0; i < giatri_ASCII.Length; i++)
            {
                Console.Write(giatri_ASCII[i] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("=========================Bảng quy đổi các số nguyên trên theo bảng ASCII tự định nghĩa=========================");
            Chuyen_Doi_Nhi_Phan cdnp = new Chuyen_Doi_Nhi_Phan();
            Console.WriteLine("Độ dài bảng ASCII: "+ cdnp.bangASCII.Length);
            Console.WriteLine("=> Số thứ tự lớn hơn '"+ cdnp.bangASCII.Length+"' thì sẽ quay về đầu");
            Console.WriteLine("==================Bảng giá trị nhị phân mới tương ứng với bảng ASCII tự định nghĩa==================");
            for (int i = 0; i < giatri_ASCII.Length; i++)
            {
                while(giatri_ASCII[i] >= cdnp.bangASCII.Length)
                {
                    giatri_ASCII[i] = giatri_ASCII[i] - cdnp.bangASCII.Length;
                }
            }
            for (int i = 0; i < giatri_ASCII.Length; i++)
            {
                Console.Write(String.Format("{0,2}", giatri_ASCII[i]));
                Console.Write(" | ");
            }
            Console.WriteLine();
            for (int i = 0; i < giatri_ASCII.Length; i++)
            {
                Console.Write(String.Format("{0,2}",cdnp.bangASCII[giatri_ASCII[i]]));
                Console.Write(" | ");
            }
        }
    }
}
