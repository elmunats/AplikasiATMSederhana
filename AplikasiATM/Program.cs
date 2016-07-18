using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiATM
{
    class Program
    {
        public static int pilihan;
        static void Main(string[] args)
        {
            Program menu = new Program();
            
            Console.WriteLine("Selamat Datang di Aplikasi ATM");
            //Nasabah(id,"nama","gender",'norekening',saldo,pin)
            Nasabah all = new Nasabah();
            Nasabah n1 = new Nasabah(203, "Muhammad Natsir", "L", "003214567", 1000, 1323);//set data
            Nasabah n2 = new Nasabah(204, "M Agus Arianto", "L", "003212311", 1000, 2222);//set data
            Awal:
            Console.Write("Masukan id Account : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Pin anda : ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            PilihanMenu :
            
            if (id == n1.getId() && pin == n1.getPin())
            {
                menu.menu();
                if (pilihan == 1)
                {
                    n1.cekSaldo();
                    goto PilihanMenu;
                }
                else if (pilihan == 2)
                {
                    double saldo;
                    Console.Write("Masukkan nomer rekening tujuan : ");
                    string noRekTujuan = Console.ReadLine();

                    if (noRekTujuan == n2.getNoRekening())
                    {
                        Console.Write("Masukkan Jumlah uang yang dikirim : ");
                        double nominal = Convert.ToInt32(Console.ReadLine());

                        n1.saldoBerkurang(nominal);
                        n2.saldoTambah(nominal);
                        n1.cekSaldo();

                        goto PilihanMenu;
                        
                    }
                    else
                    {
                        Console.WriteLine("Maaf nomer yanga anda masukkan salah");
                        goto PilihanMenu;
                    }

                }
                else if (pilihan == 3)
                {
                    Console.Write("Masukkan Jumlah uang yang di Tambah : ");
                    double nominal = Convert.ToInt32(Console.ReadLine());
                    n1.saldoTambah(nominal);
                    n1.cekSaldo();
                    goto PilihanMenu;
                }
                else if (pilihan == 4)
                {
                    Console.WriteLine("Terimakasih");
                    Environment.Exit(0);
                }
            }
            else if(id == n2.getId() && pin == n2.getPin())
            {
                menu.menu();
                if (pilihan == 1)
                {
                    n1.cekSaldo();
                    goto PilihanMenu;
                }
                else if (pilihan == 2)
                {
                    double saldo;
                    Console.Write("Masukkan nomer rekening tujuan : ");
                    string noRekTujuan = Console.ReadLine();

                    if (noRekTujuan == n1.getNoRekening())
                    {
                        Console.Write("Masukkan Jumlah uang yang dikirim : ");
                        double nominal = Convert.ToInt32(Console.ReadLine());

                        n2.saldoBerkurang(nominal);
                        n1.saldoTambah(nominal);
                        n2.cekSaldo();

                        goto PilihanMenu;

                    }
                    else
                    {
                        Console.WriteLine("Maaf nomer yanga anda masukkan salah");
                        goto PilihanMenu;
                    }

                }
                else if (pilihan == 3)
                {
                    Console.Write("Masukkan Jumlah uang yang di Tambah : ");
                    double nominal = Convert.ToInt32(Console.ReadLine());
                    n2.saldoTambah(nominal);
                    n2.cekSaldo();
                    goto PilihanMenu;
                }
                else if (pilihan == 4)
                {
                    Console.WriteLine("Terimakasih");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Maaf Id atau Pin yang anda masukkan salah");
                goto Awal;
            }


            Console.WriteLine();

            Console.ReadKey();
        }

        public void menu()
        {
            Console.WriteLine("Piliha Menu : ");
            Console.WriteLine("1. Cek Saldo");
            Console.WriteLine("2. Kirim Uang");
            Console.WriteLine("3. Tambah Saldo");
            Console.WriteLine("4. Keluar");
            Console.Write("Masukan pilihan : ");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
