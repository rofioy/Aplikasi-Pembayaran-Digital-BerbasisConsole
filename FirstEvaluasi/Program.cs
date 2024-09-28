using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEvaluasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Dompet Digital Dengan jumlah saldo 500.000

            // 1. Lihat saldo
            // 2. Pembayaran : (Tagihan Indihome, Tagihan PDAM, result Indihome, result PDAM )

            int jumlahSaldo = 500000, pembayaran;
            int choice, pilihTagihan, bayarTagihan, tagihanIndihome = 150000, tagihanPDAM = 150000, resultIndihome, resultPDAM;

            while (true)
            {
                Console.WriteLine("Selamat Datang di Pembayaran Digital \n");
                Console.WriteLine("1. Lihat Saldo \n");
                Console.WriteLine("2. Lihat Tagihan \n");
                Console.WriteLine("===================== \n\n");
                Console.WriteLine("Masukan Pilihan : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Jumlah saldo anda Rp. " + jumlahSaldo);
                        break;
                    case 2:
                        Console.WriteLine("Pilih tagihan anda : \n");
                        Console.WriteLine("1. Tagihan Indihome \n");
                        Console.WriteLine("2. Tagihan PDAM \n");
                        pilihTagihan = int.Parse(Console.ReadLine());
                        switch (pilihTagihan)
                        {
                            case 1:
                                Console.WriteLine("Tagihan Indihome anda sebesar : " + tagihanIndihome);
                                Console.WriteLine("1. Bayar tagihan sekarang \n");
                                Console.WriteLine("2. Bayar tagihan nanti \n");
                                Console.WriteLine("===================== \n\n");
                                Console.WriteLine("Masukan Pilihan : ");
                                bayarTagihan = int.Parse(Console.ReadLine());

                                switch (pilihTagihan)
                                {
                                    case 1:
                                        if (jumlahSaldo >= tagihanIndihome)
                                        {
                                            Console.WriteLine("Tagihan berhasil dibayar. \n");
                                            resultIndihome = jumlahSaldo - tagihanIndihome;
                                            Console.WriteLine("Saldo anda tersisa Rp. " + resultIndihome);
                                        } else
                                        {
                                            Console.WriteLine("Saldo anda tidak cukup untuk membayar!!");
                                        }                                  
                                        break;
                                    case 2:
                                        // Kembali ke menu sebelumnya
                                        Console.WriteLine("Anda memilih untuk membayar tagihan nanti.\n");
                                        break;

                                    default:
                                        Console.WriteLine("Pilihan tidak valid.");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Tagihan PDAM anda sebesar : " + tagihanPDAM);
                                Console.WriteLine("1. Bayar tagihan sekarang \n");
                                Console.WriteLine("2. Bayar tagihan nanti \n");
                                Console.WriteLine("===================== \n\n");
                                Console.WriteLine("Masukan Pilihan : ");
                                bayarTagihan = int.Parse(Console.ReadLine());

                                switch (pilihTagihan)
                                {
                                    case 1:
                                        if (jumlahSaldo >= tagihanPDAM)
                                        {
                                            Console.WriteLine("Tagihan berhasil dibayar. \n");
                                            resultPDAM = jumlahSaldo - tagihanPDAM;
                                            Console.WriteLine("Saldo anda tersisa Rp. " + resultPDAM);
                                        } else
                                        {
                                            Console.WriteLine("Saldo anda tidak cukup untuk membayar!!");
                                        }
                                        break;
                                    case 2:
                                        // Kembali ke menu sebelumnya
                                        Console.WriteLine("Anda memilih untuk membayar tagihan nanti.\n");
                                        break;

                                    default:
                                        Console.WriteLine("Pilihan tidak valid.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }

        }
    }
}
