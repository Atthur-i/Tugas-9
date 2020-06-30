using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_PolydanCol.Class_Induk
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public virtual void Data()
        {
            Console.WriteLine();
        }


        internal abstract object Gaji();
    }
}
