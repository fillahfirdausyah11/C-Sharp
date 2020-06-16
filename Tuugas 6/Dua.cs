using System;
using System.Collections.Generic;
using System.Text;

namespace tugasInterface {
    class Dua : IDeret {
        int awal;
        int nil;

        public Dua() {
            awal = 0;
            nil  = 0;
        }

        public int getBerikut() {
            nil += 2;
            return nil;
        }

        public void reset() {
            nil = awal;
        }

        public void setAwal(int x) {
            awal = x;
            nil = awal;
        }
    }
}