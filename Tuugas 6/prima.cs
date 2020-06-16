using System;
using System.Collections.Generic;
using System.Text;

namespace tugasInterface {
    class Prima : IDeret {
        int awal;
        int nil;

        public Prima() {
            awal = 2;
            nil  = 2;

        }

        public int getBerikut() {
            bool apaprima;
            nil++;

            for (int i = nil; i < 5; i++) {
                apaprima = true;
                
                for (int j = 2; j <= i / j; j++) {
                    if ( (i % j) == 0) {
                        apaprima = false;
                        break;
                    }
                    if (apaprima) {
                        nil = i;
                        break;
                    }
                }
            }
            return  nil;
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