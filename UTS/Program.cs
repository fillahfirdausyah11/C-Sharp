﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threaading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread me1 = new Thread(Header);
            Thread me2 = new Thread(Body);

            me2.Start();
            me1.Start();

            Console.ReadKey();
        }

        static void Header()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("||              BIODATA MAHASISWA               ||");
            Console.WriteLine("||         UNIVERSITAS AMIKOM YOGYAKARTA        ||");
            Console.WriteLine("==================================================");
        }
        static void Body()
        {
            Console.WriteLine("||NAMA LENGKAP   : Fillah Akbar Firdausyah      ||");
            Console.WriteLine("||NAMA PANGGILAN : Fillah                       ||");
            Console.WriteLine("||TTL            : Bitung, 11 January 2000      ||");
            Console.WriteLine("||Asal SMK       : SMK Negeri 2 Bitung          ||");
            Console.WriteLine("||FAKULTAS       : Ilmu Komputer                ||");
            Console.WriteLine("||NIM            : 19.11.3204                   ||");
            Console.WriteLine("||JURUSAN        : S1-Informatika               ||");
            Console.WriteLine("||Cita-cita      : Software Engineer            ||");
            Console.WriteLine("||Agama          : ISLAM                        ||");
            Console.WriteLine("||Hobi           : Main Game                    ||");
            Console.WriteLine("--------------------------------------------------");
            // Console.ReadLine();
        }
    }
}