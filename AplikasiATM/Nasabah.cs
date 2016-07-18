using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiATM
{
    class Nasabah
    {
        int idNasabah;
        string nama;
        string gender;
        string noRekening;
        double saldo;
        int pin;
        public Nasabah()
        {

        }
        public Nasabah(int id, string n, string g, string nr, double s, int p )
        {
            this.idNasabah = id;
            this.nama = n;
            this.gender = g;
            this.noRekening = nr;
            this.saldo = s;
            this.pin = p;
        }

        public int getId()
        {
            return idNasabah;
        }

        public int getPin()
        {
            return pin;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public string getNoRekening()
        {
            return noRekening;
        }

        public int cariNasabah(int id)
        {

            do
            {
                if (id == this.idNasabah)
                {
                    Console.WriteLine(this.idNasabah);
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
            while (id != this.idNasabah);
            return idNasabah;
        }

        public void TampilData()
        {
            Console.WriteLine("Nama : "+this.nama);
            Console.WriteLine("Jenis Kelamin : "+this.gender);
            Console.WriteLine("No Rekening : "+this.noRekening);
            
        }

        
        public double cekSaldo()
        {
            Console.WriteLine("Saldo saat ini: "+this.saldo);
            return saldo;
        }
        
        public double saldoTambah(double nominal)
        {
            double saldoTambah = saldo + nominal;
            this.saldo = saldoTambah;
            return saldo;
        }

        public double saldoBerkurang(double nominal)
        {
            double saldoTambah = saldo - nominal;
            this.saldo = saldoTambah;
            return saldo;
        }
        /**
        public int tambahSaldo()
        {

        }

        **/
    }
}
