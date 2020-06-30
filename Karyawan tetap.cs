using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Tugas_PolydanCol.Class_Induk;

namespace Tugas_PolydanCol.Class_anak
{
    public class Karyawan_tetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override void Data()
        {
            Console.WriteLine();
        }

        internal override object Gaji()
        {
            return GajiBulanan = GajiBulanan;
        }
    }
}
