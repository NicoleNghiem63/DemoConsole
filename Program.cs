using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static int ioInput(string loaiDuLieu)
        {
            int soNhapVao;
            Console.Write("Nhap vao " + loaiDuLieu + ": ");

            return soNhapVao = int.Parse(Console.ReadLine());
        }
        
        static bool ChiaHet3 ()
        //Control bai 1
        {
            bool ketqua;
            int number;

            number = ioInput("so nguyen duong");
            if (number % 3 == 0)
                // Chia het cho 3
                ketqua = true;
            else
                ketqua = false;
                Console.WriteLine("Chia het cho 3: " + ketqua);
                return ketqua;
        }
        static void inBangCuuChuong()
        //Control bai 2

        {
            int endNumber;            
            int i; 
            int j;

            endNumber = ioInput("so nguyen duong");
            
            i = 1;
            while (i <= endNumber)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(" ");
                i++;
            }
        }
        static long TinhTongGiaiThua()
        //Control bai 3
        {
            int endNumber;
            int i = 1;
            int j = 1;
            long sumAll = 0;
            long giaiThua = 1;

            endNumber = ioInput("so nguyen duong");
                    
            while (i <= endNumber)
            {
                for (j=1; j <= i; j++)
                {
                    giaiThua *= j;
                }
                sumAll += giaiThua;
                giaiThua = 1;
                i++;
            }
            return sumAll;
        }
        static string Fibonacci()
        //Control bai 10
        {
            int number;
            string ketqua = "0";

            number = ioInput("so nguyen duong");

            if (number == 1)
            { 
                Console.WriteLine("Day Fibonacci voi {0} phan tu la:\n {1}", number, ketqua); 
            }
            else if (number == 2)
            {
                ketqua = ketqua + "\t 1";
                Console.WriteLine("Day Fibonacci voi {0} phan tu la:\n {1}", number, ketqua); 
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = 0;

                int i = 1;
                ketqua = ketqua + "\t 1";

                while (i <= number - 2) // hai phan tu dau tien luon la 0, 1
                {
                    c = a + b;
                    ketqua += "\t " + c;

                    a = b;
                    b = c;
                    i++;
                }
            }
            return ketqua;
        }

        static void btArray()
        {
            int n;
            int i;
            int j;
            int count=0;
            int[] numbers;

            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap vao phan tu {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\n1) Mang da nhap la:");
            foreach (var item in numbers)
            {
                Console.Write(item + "\t");
            }
            //=========== Array Bai 2
            Array.Reverse(numbers);
            Console.WriteLine("\n2) Mang theo chieu dao nguoc la:");
            foreach (var item in numbers)
            {
                Console.Write(item + "\t");
            }
            //=========== Array Bai 3

            for (i = 0; i < n; i++)
            {
                for (j = i+1; j < n; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count += 1;
                    }                        
                }                   
            }
            Console.Write("\n3) So luong bi trung lap la: " + count);

            //=========== Array Bai 4
            return;
        }
        public static void Main(string[] args)
        {
            ////========================= Control Bai 1: Kiểm tra chia hết cho 3
            //bool bai1;
            //bai1 = ChiaHet3();

            ////========================= Control Bai 2: In bảng cửu chương từ 1 đến n
            //inBangCuuChuong();

            ////========================= Control Bai 3: Tính tổng giai thừa từ 1 đến n  
            //long tongGiaiThua;
            //tongGiaiThua = TinhTongGiaiThua();
            //Console.WriteLine("Tong giai thua la: " + tongGiaiThua);

            ////========================= Control Bai 4: Kiểm tra số chính phương
            ////========================= Control Bai 5: In số ngày trong tháng
            ////========================= Control Bai 10: In Fibonacci
            //string bai10;
            //bai10 = Fibonacci();
            //Console.WriteLine("Day Fibonacci: \n" + bai10);
            

            ////========================= Bai tap Array: 
            btArray();
            



        }
    }
}
