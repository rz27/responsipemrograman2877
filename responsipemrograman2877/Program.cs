using System;

namespace responsipemrograman2877

{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Karyawan karyawan1= new Karyawan (1, 19112877, "reza", 8000000);
            karyawan1.gaji();
            Karyawan karyawan2 = new Karyawan(2, 1911289, "aniq ", 9000000);
            karyawan2.gaji();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" GAJI NAIK 10%!");
            Console.WriteLine(" ");
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Karyawan karyawan3 = new Karyawan(1, 19112877, "reza", 8000000);
            karyawan3.gajinaik();
            Karyawan karyawan4 = new Karyawan(2, 1911289, "aniq ", 9000000);
            karyawan4.gajinaik();
        }
    }
}