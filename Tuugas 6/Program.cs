using System;

namespace tugasInterface {

    class Program {

        static void Main(string[] args) {

            Dua duaOb = new Dua();
            Prima primaOb = new Prima();
            IDeret ob;

                for (int i = 0; i < 5; i++) {
                    
                    ob = duaOb;
                    Console.WriteLine("Nilai dengan dua berikutnya adalah " + ob.getBerikut());

                    ob = primaOb;
                     Console.WriteLine("Nilai prima berikutnya adalah " + ob.getBerikut());
                }
        }
    }
}
