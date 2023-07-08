using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    public class Dich_C0_D0
    {
        int[] C1 = new int[28]; int[] D1 = new int[28];
        int[] C2 = new int[28]; int[] D2 = new int[28];
        int[] C3 = new int[28]; int[] D3 = new int[28];
        int[] C4 = new int[28]; int[] D4 = new int[28];
        int[] C5 = new int[28]; int[] D5 = new int[28];
        int[] C6 = new int[28]; int[] D6 = new int[28];
        int[] C7 = new int[28]; int[] D7 = new int[28];
        int[] C8 = new int[28]; int[] D8 = new int[28];
        int[] C9 = new int[28]; int[] D9 = new int[28];
        int[] C10 = new int[28]; int[] D10 = new int[28];
        int[] C11 = new int[28]; int[] D11 = new int[28];
        int[] C12 = new int[28]; int[] D12 = new int[28];
        int[] C13 = new int[28]; int[] D13 = new int[28];
        int[] C14 = new int[28]; int[] D14 = new int[28];
        int[] C15 = new int[28]; int[] D15 = new int[28];
        int[] C16 = new int[28]; int[] D16 = new int[28];

        public int[] key1 = new int[48]; public int[] key8 = new int[48]; 
        public int[] key2 = new int[48]; public int[] key9 = new int[48]; 
        public int[] key3 = new int[48]; public int[] key10 = new int[48];
        public int[] key4 = new int[48]; public int[] key11 = new int[48];
        public int[] key5 = new int[48]; public int[] key12 = new int[48];
        public int[] key6 = new int[48]; public int[] key13 = new int[48];
        public int[] key7 = new int[48]; public int[] key14 = new int[48];
        public int[] key15 = new int[48];public int[] key16 = new int[48];
        public void dich()
        {
            Tim_C0_D0 khoa = new Tim_C0_D0(); 
            khoa.nhapKey();
            int[] tmpC = khoa.getCo();
            int[] tmpD = khoa.getDo();
            Console.WriteLine("");
            for (int i = 1; i <= 16; i++)
            {
                if(i==1||i==2||i==9||i==16)
                {
                    int tmpC1 = tmpC[0];
                    int tmpD1 = tmpD[0];
                    for(int j=0;j<27;j++)
                    {
                        tmpC[j] = tmpC[j + 1];
                        tmpD[j] = tmpD[j + 1];
                    }
                    tmpC[27] = tmpC1;
                    tmpD[27] = tmpD1;
                }
                else
                {
                    int tmpC1 = tmpC[0]; int tmpC2 = tmpC[1];
                    int tmpD1 = tmpD[0]; int tmpD2 = tmpD[1];
                    for (int j = 0; j < 26; j++)
                    {
                        tmpC[j] = tmpC[j + 2];
                        tmpD[j] = tmpD[j + 2];
                    }
                    tmpC[26] = tmpC1; tmpC[27] = tmpC2;
                    tmpD[26] = tmpD1; tmpD[27] = tmpD2;
                }
                switch(i)
                {
                    case 1: tmpC.CopyTo(C1, 0); tmpD.CopyTo(D1, 0); break;
                    case 2: tmpC.CopyTo(C2, 0); tmpD.CopyTo(D2, 0); break;
                    case 3: tmpC.CopyTo(C3, 0); tmpD.CopyTo(D3, 0); break;
                    case 4: tmpC.CopyTo(C4, 0); tmpD.CopyTo(D4, 0); break;
                    case 5: tmpC.CopyTo(C5, 0); tmpD.CopyTo(D5, 0); break;
                    case 6: tmpC.CopyTo(C6, 0); tmpD.CopyTo(D6, 0); break;
                    case 7: tmpC.CopyTo(C7, 0); tmpD.CopyTo(D7, 0); break;
                    case 8: tmpC.CopyTo(C8, 0); tmpD.CopyTo(D8, 0); break;
                    case 9: tmpC.CopyTo(C9, 0); tmpD.CopyTo(D9, 0); break;
                    case 10: tmpC.CopyTo(C10, 0); tmpD.CopyTo(D10, 0); break;
                    case 11: tmpC.CopyTo(C11, 0); tmpD.CopyTo(D11, 0); break;
                    case 12: tmpC.CopyTo(C12, 0); tmpD.CopyTo(D12, 0); break;
                    case 13: tmpC.CopyTo(C13, 0); tmpD.CopyTo(D13, 0); break;
                    case 14: tmpC.CopyTo(C14, 0); tmpD.CopyTo(D14, 0); break;
                    case 15: tmpC.CopyTo(C15, 0); tmpD.CopyTo(D15, 0); break;
                    case 16: tmpC.CopyTo(C16, 0); tmpD.CopyTo(D16, 0); break;
                }
            }
        }
        public void hienthiDich()
        {
            int tach = 0;
            Console.WriteLine("");
            Console.WriteLine("==========================DANH SÁCH DỊCH 16 LẦN C0 - D0==========================");
            Console.WriteLine("");
            Console.Write("1: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C1[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D1[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //2
            Console.Write("2: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C2[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D2[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //3
            Console.Write("3: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C3[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D3[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //4
            Console.Write("4: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C4[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D4[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //5
            Console.Write("5: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C5[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D5[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //6
            Console.Write("6: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C6[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D6[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //7
            Console.Write("7: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C7[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D7[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //8
            Console.Write("8: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C8[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D8[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
               
            }
            Console.WriteLine("");
            //9
            Console.Write("9: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C9[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D9[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //10
            Console.Write("10: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C10[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D10[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //11
            Console.Write("11: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C11[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D11[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //12
            Console.Write("12: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C12[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D12[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //13
            Console.Write("13: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C13[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D13[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //14
            Console.Write("14: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C14[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D14[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //15
            Console.Write("15: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C15[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D15[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
            //16
            Console.Write("16: ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(C16[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.Write(" <-----> ");
            for (int i = 0; i < 28; i++)
            {
                tach++;
                Console.Write(D16[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                
            }
            Console.WriteLine("");
        }
        public void key_16()
        {
            int dodaibangPC_2 = Danh_Sach_Bang.PC2.Length;
            for(int i =1; i <= 16; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            int[] sub_key = new int[C1.Length + D1.Length];
                            Array.Copy(C1, 0, sub_key, 0, C1.Length);
                            Array.Copy(D1, 0, sub_key, C1.Length, D1.Length);
                            for(int k=0;k<Danh_Sach_Bang.PC2.Length;k++)
                            {
                                for(int j=0;j<sub_key.Length;j++)
                                {
                                    if((Danh_Sach_Bang.PC2[k]-1)==j)
                                    {
                                        key1[k] = sub_key[j];
                                    }
                                }
                            }
                            
                        };break;
                    case 2:
                        {
                            int[] sub_key = new int[C2.Length + D2.Length];
                            Array.Copy(C2, 0, sub_key, 0, C2.Length);
                            Array.Copy(D2, 0, sub_key, C2.Length, D2.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key2[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 3:
                        {
                            int[] sub_key = new int[C3.Length + D3.Length];
                            Array.Copy(C3, 0, sub_key, 0, C3.Length);
                            Array.Copy(D3, 0, sub_key, C3.Length, D3.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key3[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 4:
                        {
                            int[] sub_key = new int[C4.Length + D4.Length];
                            Array.Copy(C4, 0, sub_key, 0, C4.Length);
                            Array.Copy(D4, 0, sub_key, C4.Length, D4.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key4[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 5:
                        {
                            int[] sub_key = new int[C5.Length + D5.Length];
                            Array.Copy(C5, 0, sub_key, 0, C5.Length);
                            Array.Copy(D5, 0, sub_key, C5.Length, D5.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key5[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 6:
                        {
                            int[] sub_key = new int[C6.Length + D6.Length];
                            Array.Copy(C6, 0, sub_key, 0, C6.Length);
                            Array.Copy(D6, 0, sub_key, C6.Length, D6.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key6[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 7:
                        {
                            int[] sub_key = new int[C7.Length + D7.Length];
                            Array.Copy(C7, 0, sub_key, 0, C7.Length);
                            Array.Copy(D7, 0, sub_key, C7.Length, D7.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key7[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 8:
                        {
                            int[] sub_key = new int[C8.Length + D8.Length];
                            Array.Copy(C8, 0, sub_key, 0, C8.Length);
                            Array.Copy(D8, 0, sub_key, C8.Length, D8.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key8[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 9:
                        {
                            int[] sub_key = new int[C9.Length + D9.Length];
                            Array.Copy(C9, 0, sub_key, 0, C9.Length);
                            Array.Copy(D9, 0, sub_key, C9.Length, D9.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key9[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 10:
                        {
                            int[] sub_key = new int[C10.Length + D10.Length];
                            Array.Copy(C10, 0, sub_key, 0, C10.Length);
                            Array.Copy(D10, 0, sub_key, C10.Length, D10.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key10[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 11:
                        {
                            int[] sub_key = new int[C11.Length + D11.Length];
                            Array.Copy(C11, 0, sub_key, 0, C11.Length);
                            Array.Copy(D11, 0, sub_key, C11.Length, D11.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key11[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 12:
                        {
                            int[] sub_key = new int[C12.Length + D12.Length];
                            Array.Copy(C12, 0, sub_key, 0, C12.Length);
                            Array.Copy(D12, 0, sub_key, C12.Length, D12.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key12[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 13:
                        {
                            int[] sub_key = new int[C13.Length + D13.Length];
                            Array.Copy(C13, 0, sub_key, 0, C13.Length);
                            Array.Copy(D13, 0, sub_key, C13.Length, D13.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key13[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 14:
                        {
                            int[] sub_key = new int[C14.Length + D14.Length];
                            Array.Copy(C14, 0, sub_key, 0, C14.Length);
                            Array.Copy(D14, 0, sub_key, C14.Length, D14.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key14[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 15:
                        {
                            int[] sub_key = new int[C15.Length + D15.Length];
                            Array.Copy(C15, 0, sub_key, 0, C15.Length);
                            Array.Copy(D15, 0, sub_key, C15.Length, D15.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key15[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                    case 16:
                        {
                            int[] sub_key = new int[C16.Length + D16.Length];
                            Array.Copy(C16, 0, sub_key, 0, C16.Length);
                            Array.Copy(D16, 0, sub_key, C16.Length, D16.Length);
                            for (int k = 0; k < Danh_Sach_Bang.PC2.Length; k++)
                            {
                                for (int j = 0; j < sub_key.Length; j++)
                                {
                                    if ((Danh_Sach_Bang.PC2[k] - 1) == j)
                                    {
                                        key16[k] = sub_key[j];
                                    }
                                }
                            }

                        }; break;
                }
            }
        }
        public void hienthi_16key()
        {
            int tach = 1;
            Console.WriteLine("");
            Console.WriteLine("==========================16 KEY TƯƠNG ỨNG C1->C16 VÀ D1->D16==========================");
            Console.WriteLine(""); 
            Console.Write("KEY_1: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key1[i]+" ");
                if(tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_2: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key2[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_3: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key3[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_4: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key4[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_5: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key5[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_6: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key6[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_7: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key7[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_8: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key8[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_9: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key9[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_10: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key10[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_11: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key11[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_12: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key12[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_13: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key13[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_14: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key14[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_15: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key15[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
            Console.Write("KEY_16: ");
            for (int i = 0; i < key1.Length; i++)
            {
                Console.Write(key16[i] + " ");
                if (tach == 4)
                {
                    Console.Write(" | ");
                    tach = 0;
                }
                tach++;
            }
            Console.WriteLine(""); Console.WriteLine("");
        }

    }
}
