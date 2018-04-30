using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_andro
{
    class Process
    {
        IO io = new IO();
        int bs = 200000, jmlbs;
        int bk = 90000, jmlbk;
        int btw = 85000, jmlbtw;
        int bts = 45000, jmlbts;
        public Process()
        {
            Console.WriteLine("Process Class activated");
        }

        public void notabs()
        {
            Console.Write("\nJumlah BloodsSweater yang anda inginkan: ");
            try
            {
                jmlbs = int.Parse(Console.ReadLine()); io.setBaju(jmlbs);
                bs = bs * io.getBaju();
            }
            catch (Exception) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: Rp. " + bs);
        }
        public void notabk()
        {
            Console.Write("\nJumlah BloodsKaos yang anda inginkan: ");
            try
            {
                jmlbk = int.Parse(Console.ReadLine()); io.setBaju(jmlbk);
                bk = bk * io.getBaju();
            }
            catch (Exception) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: Rp. " + bk);
        }
        public void notabtw()
        {
            Console.Write("\nJumlah BloodsTasWaistbag yang anda inginkan: ");
            try
            {
                jmlbtw = int.Parse(Console.ReadLine()); io.setBaju(jmlbtw);
                btw = btw * io.getBaju();
            }
            catch (Exception) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: Rp. " + btw);
        }
        public void notabts()
        {
            Console.Write("\nJumlah BloodsTopiSkate yang anda inginkan: ");
            try
            {
                jmlbts = int.Parse(Console.ReadLine()); io.setBaju(jmlbts);
                bts = bts * io.getBaju();
            }
            catch (Exception) { io.salah(); }
            Console.WriteLine("\nTotal belanja anda: Rp. " + bts);
        }
        public string hargaproduk(string inputnama)
        {
            io.setNama(inputnama);

            switch (io.getNama().ToLower())
            {
                case "1":
                    notabs();
                    io.balek();
                    break;
                case "2":
                    notabk();
                    io.balek();
                    break;
                case "3":
                    notabtw();
                    io.balek();
                    break;
                case "4":
                    notabts();
                    io.balek();
                    break;
                default:
                    io.salah();
                    io.exit();
                    break;
            }

            return null;
        }
    }
}
