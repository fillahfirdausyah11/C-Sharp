using System;

namespace Mahasiswa {

    class Mahasiswa {
        private string nama;
        public string nim;


        public void namaMhs(string nama) {
             this.nama = nama;
        }

        public string GetNama() {
            return this.nama;
        }
    }

}