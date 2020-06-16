using System;

namespace Mahasiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mahasiswa mhs = new Mahasiswa();

            mhs.namaMhs ("Adi Pranomo");
            mhs.nim  = "19.11.3204";
            Console.WriteLine("Menampilkan Data Mahasiswa : ");

            Console.WriteLine("Nama : " + mhs.GetNama()); 
            Console.WriteLine("Nim : "  + mhs.nim); 

        }
    }
}
