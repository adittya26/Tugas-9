using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TugasLab9.ClassAnak;
using TugasLab9.ClassInduk;

namespace TugasLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listkaryawan = new List<Karyawan>();

            void Employee_Formation()
            {
                int Serialnumber = 1;
                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}, {4}",
                    Serialnumber, karyawan.Nik, karyawan.Name, karyawan.Pendapatan(), karyawan.Number_of_employees); Serialnumber++;
                }
            }

            void Remove_Employee()
            {
                int Serialnumber = 1;
                int number_ofemployees = 0;

                foreach (Karyawan karyawan in listkaryawan)

                {
                    Console.WriteLine("{0}. Nik: {1}", Serialnumber, karyawan.Nik); Serialnumber++; number_ofemployees += 1;
                }

                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1...");
                Console.Write(number_ofemployees);
                Console.Write("] : ");
                int list = int.Parse(Console.ReadLine());
                list = list-1;

                listkaryawan.RemoveAt(list);
                Console.WriteLine("==================================");
                Console.WriteLine("||Data Karyawan Berhasil Dihapus|| ");
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter");
            }

            bool Exit = false;
            while (Exit == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("=============================");
                Console.WriteLine("\tPilih Menu Aplikasi :");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("=============================");

                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");

                int Menu = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if (Menu < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Dipilih Tidak Ada");
                }
                else if (Menu > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Dipilih Tidak Ada");
                }

                else if (Menu == 1)

                {

                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int NOE = int.Parse(Console.ReadLine());
                    Console.WriteLine("================================================================");

                    if (NOE == 1)

                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string name = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int Monthlysalary = int.Parse(Console.ReadLine());
                        string Tipe = "Karyawan Tetap";

                        AddPermanentEmployees( Tipe, nik, name, Monthlysalary);

                    }

                    else if (NOE == 2)

                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string name = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int workinghours = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int wage = int.Parse(Console.ReadLine());
                        string Tipe = "Karyawan Harian";

                        AddDailyEmployees(Tipe, nik, name, workinghours, wage);

                    }

                    else if (NOE == 3)

                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string name = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int NumberofSell = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int commission = int.Parse(Console.ReadLine());
                        string Tipe = "Sales";

                        AddSalesMan(Tipe, nik, name, NumberofSell, commission);

                    }

                    else

                    {
                        Console.WriteLine("Menu salah");
                    }

                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter");
                }

                else if (Menu == 2)

                {
                    Remove_Employee();
                }

                else if (Menu == 3)

                {
                    Console.WriteLine("=================");
                    Console.WriteLine("||Data Karyawan||");
                    Console.WriteLine("=================");
                    Console.WriteLine();
                    Employee_Formation();
                    Console.WriteLine("\nTekan Enter");
                }

                else if (Menu == 4)

                {
                    Exit = true;
                }
            }

            void AddDailyEmployees (string name, string nik, string number_of_employees, int number_of_hours_worked, int hourlywages)
            {
                listkaryawan.Add (new KaryawanHarian 
                { Name = name, Nik = nik, Number_of_employees = number_of_employees, Number_of_hours_worked = number_of_hours_worked, Hourly_Wages = hourlywages });
            }

            void AddPermanentEmployees (string name, string nik, string numberofemployees, double income)
            {
                listkaryawan.Add (new KaryawanTetap 
                { Name = name, Nik = nik, Income = income, Number_of_employees = numberofemployees });
            }

            void AddSalesMan (string name, string nik, string number_of_employees, int sales_amount, int bonus)
            {
                listkaryawan.Add (new Sales 
                { Name = name, Nik = nik, Number_of_employees = number_of_employees, Sales_amount = sales_amount, Bonus = bonus });
            }

            Console.ReadLine();
        }
    }
}
