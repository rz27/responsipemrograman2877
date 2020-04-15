using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsipemrograman2877 {
    public class Karyawan {
        public Karyawan(int no, int nik, string nama, int gb) {
            No = no;
            Nik = nik;
            Nama = nama;
            GB = gb;
        }

        public int No {
            get;
            set;
        }

        public int Nik {
            get;
            set;
        }

        public string Nama {
            get;
            set;
        }

        public int GB {
            get;
            set;
        }

        public void gaji() {
            Console.WriteLine("{0}. {1} {2} {3}", No, Nik, Nama, GB);

            if (GB < 0) {
                Console.WriteLine("Maaf Gaji Kurang dari 0");
            }
        }

        public void gajinaik() {
            Console.WriteLine("{0}. {1} {2} {3}", No, Nik, Nama, GB + (GB * 10 / 100));

            if (GB < 0) {
                Console.WriteLine("Maaf Gaji Kurang dari 0");
            }
        }
    }
}