using System;
using System.Text;
using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class Sales: Karyawan
    {
        public double Sales_amount { get; set; }
        public double Bonus { get; set; }
        public override double Pendapatan()
        {
            return Sales_amount * Bonus;
        }
    }
}
