using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tugas_PolydanCol.Class_Induk;

namespace Tugas_PolydanCol.Class_anak
{
    public class karyawan_Harian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public double Jumlah { get; set; }

        public override void Data()
        {
            Console.WriteLine();
        }

        internal override object Gaji()
        {
            return Jumlah = UpahPerJam * JumlahJamKerja;
        }
    }
}
