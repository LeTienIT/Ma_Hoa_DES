using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_DES
{
    public class Chuyen_Doi_Nhi_Phan
    {
        public string[] bangASCII ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v",
                            "w","x","y","z"
                            ,"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V",
                            "W","X","Y","Z"," ","~","`","!","@","#","$","%"
                            ,"^","&","*","(",")","-","_","+","=","|","\\","\"","\n","\t","{","[","]","}",":",";","'","<",",",".",">","?","/"
                            ,"0","1","2","3","4","5","6"
                            ,"7","8","9"};
        public int[] inputKey = new int[64];
        public int[] inputP = new int[64];
        public string input;
        public string input2;
        public void chuyen_doi_K()
        {
            Console.WriteLine("Độ dài bảng mã ASCII định nghĩa là: " + bangASCII.Length);
            Console.Write("Nhập key để chuyển đổi: ");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();
                int index = Array.IndexOf(bangASCII, character);
                if (index >= 0)
                {
                    //Console.Write("index: " + i + " :" + index);
                    //Console.WriteLine("");
                    string binary = Convert.ToString(index, 2).PadLeft(8, '0');
                    for (int j = 0; j < binary.Length; j++)
                    {
                        inputKey[i * 8 + j] = int.Parse(binary[j].ToString());
                    }
                }
            } 
            
        }
        public void chuyen_doi_P()
        {
            Console.WriteLine("");
            Console.WriteLine("Độ dài bảng mã ASCII định nghĩa là: " + bangASCII.Length);
            Console.Write("Nhập P để chuyển đổi: ");
            input2 = Console.ReadLine();

            for (int i = 0; i < input2.Length; i++)
            {
                string character = input2[i].ToString();
                int index = Array.IndexOf(bangASCII, character);
                if (index >= 0)
                {
                    //Console.Write("index: " + i + " :" + index);
                    //Console.WriteLine("");
                    string binary = Convert.ToString(index, 2).PadLeft(8, '0');
                    for (int j = 0; j < binary.Length; j++)
                    {
                        inputP[i * 8 + j] = int.Parse(binary[j].ToString());
                    }
                }
            }
        }
        public void hienThi_P()
        {
            Console.WriteLine("");
            Console.WriteLine("Bảng nhị phân của bản P: ");
            for (int i = 0; i < inputP.Length; i++)
            {
                Console.Write(inputP[i] + " ");
            }
        }
        public void hienThi_Key()
        {
            Console.WriteLine("");
            Console.WriteLine("Bảng nhị phân của khóa K: ");
            for (int i = 0; i < inputKey.Length; i++)
            {
                Console.Write(inputKey[i] + " ");
            }
        }

    }
}
