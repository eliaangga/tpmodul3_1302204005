using System;
using System.Collections.Generic;

namespace tpmodul3_1302204005 {
    class MainClass {
        public static void Main(string[] args) {
            KodePos table_Kodepos = new KodePos();
            Console.WriteLine("=== Kode Pos ===");
            table_Kodepos.getKodepos("Margasari");
            Console.WriteLine("==== Semua Kode Pos ====");
            table_Kodepos.getAllkodepos();

            Console.WriteLine("==== KUNCI PINTU ====");
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();
        }
    }

    class KodePos{
        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari","40287" },
            {"Mengger"  ,"40267" },
            {"Wates"    ,"40256" },
            {"Cijaura"  ,"40287"},
            {"Jatisari" ,"40286" },
            {"Margasari","40286"},
            {"Sekejati" ,"40286" },
            {"Kebonwaru","40272"},
            {"Maleer"   ,"40274"},
            {"Samoja"   ,"40273"} };
        public void getKodepos(string nice) {
            if (dic.ContainsKey(nice)) {
                Console.WriteLine(nice + " : " + dic[nice]);
            }
            else {
                Console.WriteLine(nice + " tidak ketemu");
            }
        }

        public void getAllkodepos() {
            foreach (KeyValuePair<string, string> ele1 in dic) {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }


    class DoorMachine {
        enum State { Dikunci, Dibuka };
        public void kunci() {
            State state = State.Dikunci;

            String[] screenName = { "Dikunci", "Dibuka" };
            do {
                Console.WriteLine("Pintu " + screenName[(int)state]);
                Console.Write("Enter Command : ");
                String command = Console.ReadLine();
                switch (state) {
                    case State.Dikunci:
                        if (command == "BukaPintu") {
                            state = State.Dibuka;
                        }
                        break;
                    case State.Dibuka:
                        if (command == "KunciPintu") {
                            state = State.Dikunci;
                        }
                        break;
                }
            } while (state != State.Dikunci);
        }
    }
}
