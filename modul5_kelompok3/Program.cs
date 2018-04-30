using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_andro
{
    class Program
    {
        public void handle()
        {
            Main(null);
        }
        public void mainprog()
        {
            Process proses = new Process();
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Selamat Datang di Toko Baju BLOODS!!");
            Console.WriteLine("Cepat Belanja Terus Keluar!");
            Console.WriteLine("Hari ini spesial: 1 customer 1 tipe item");
            Console.WriteLine("Ga boleh beli lebih dari 1 tipe item");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Silakan pilih: ");
            Console.WriteLine("\n1.BloodsSweater (Rp. 200.000)     \t 3.BloodsTasWaistbag (Rp. 85.000)");
            Console.WriteLine("\n2.BloodsKaos    (Rp. 90.000)      \t 4.BloodsTopiSkate   (Rp. 45.000)\n");
            Console.WriteLine("Pilih dengan nomor, ex:BloodsTopiSkate");
            Console.Write("\nPilihan: ");
            proses.hargaproduk(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Program main = new Program();
            IO io = new IO();
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Andro Adhita Pratama 21120117140013");
                Console.WriteLine("Miranti Faninda Alif 21120112140084");
                Console.WriteLine("Kelompok 3");
                Console.WriteLine("Shift 1");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ");
                Console.WriteLine("\n1\tBeli Baju");
                Console.WriteLine("q\tQuit");
                Console.Write("\nPilih 1 atau q: ");
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        main.mainprog();
                        break;
                    case "q":
                        io.exit();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
            while (response != "q");
        }
    }
}
