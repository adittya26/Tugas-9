using System;
using System.Text;

namespace TugasLab9.ClassInduk
{
    public abstract class Karyawan
    {
        public string Name { get; set; }
        public string Nik { get; set; }
        public string Number_of_employees { get; set; }
        public abstract double Pendapatan();
    }
}