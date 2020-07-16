using System;

namespace dataProvinsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kecamatan kecamatan = new Kecamatan();
            kecamatan.provinsi();
            kecamatan.kabupaten();
            kecamatan.kecamatan();

            Console.WriteLine(" Hello Manusia!");
        }
    }
}
