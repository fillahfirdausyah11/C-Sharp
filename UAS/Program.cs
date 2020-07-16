using System;

namespace dataProvinsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kecamatan kecamatan = new Kecamatan();
            kecamatan.kabupaten();
            kecamatan.kecamatan();
            kecamatan.kelurahan();

            Console.WriteLine("\n Demikian beberapa kabupaten, kecamatan, dan kelurahan di DIY ");
        }
    }
}
