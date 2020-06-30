using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tugas_PolydanCol.Class_Induk;

namespace Tugas_PolydanCol.Class_anak
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public double jumlah { get; set; }
      
        public override void Data()
        {
            Console.WriteLine();
        }

        internal override object Gaji()
        {
            return jumlah = Komisi * JumlahPenjualan; ;
        }
    }
}
