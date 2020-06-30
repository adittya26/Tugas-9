using System;
using System.Text;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
  public class KaryawanTetap: Karyawan
    { 
        public double Income { get; set; }
        public override double Pendapatan()
        {
            return Income;
        }
    }
}