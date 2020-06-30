using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_PolydanCol.Class_anak;
using Tugas_PolydanCol.Class_Induk;

namespace Tugas_PolydanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9";
            int pilihan;
            List<Karyawan> listkaryawan = new List<Karyawan>();
            do
            {
                Console.Clear();
                Console.WriteLine( "Pilih Menu Aplikasi" );
                Console.WriteLine();
                Console.WriteLine( "1. Tambah Data Karyawan" );
                Console.WriteLine( "2. Hapus Data Karyawan" );
                Console.WriteLine( "3. Tampilkan Data Karyawan" );
                Console.WriteLine( "4. Keluar" );
                Console.WriteLine();
                Console.Write( "Nomor Menu [1..4] : " );
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine( "Tambah Data Karyawan\n" );
                        Console.Write( "Jenis Karyawan[1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : " );
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                Karyawan_tetap karyawan_Tetap = new Karyawan_tetap();
                                Console.Write( "NIK : ");
                                karyawan_Tetap.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                karyawan_Tetap.Nama = Console.ReadLine();
                                Console.Write("Gaji Bulanan : ");
                                karyawan_Tetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                                listkaryawan.Add(karyawan_Tetap);
                                break;
                            case 2:
                                karyawan_Harian karyawan_Harian = new karyawan_Harian();
                                Console.Write("NIK : ");
                                karyawan_Harian.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                karyawan_Harian.Nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                karyawan_Harian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah PerJam : ");
                                karyawan_Harian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                                listkaryawan.Add(karyawan_Harian);
                                break;
                            case 3:
                                Sales sales = new Sales();
                                Console.Write("NIK : ");
                                sales.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                sales.Nama = Console.ReadLine();
                                Console.Write("Jumlah Penjualan : ");
                                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah PerJual : ");
                                sales.Komisi = Convert.ToDouble(Console.ReadLine());
                                listkaryawan.Add(sales);
                                break;
                            default:
                                Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                                break;
                        }
                        break;
                    case 2:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        foreach (Karyawan karyawan in listkaryawan)
                        {
                            no++;
                            if (karyawan.Nik == nik)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            listkaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nData Berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nData Nik tidak ditemukan");
                        }
                        break;
                    case 3:
                        int nourut = 0;
                        string jenis = " ";
                        Console.WriteLine("Data Karyawan : \n");
                        foreach (Karyawan karyawan in listkaryawan)
                        {
                            if (karyawan is Karyawan_tetap)
                            {
                                jenis = "Karyawan Tetap";
                            }
                            else if (karyawan is karyawan_Harian)
                            {
                                jenis = "Karyawan Harian";
                            }
                            else
                            {
                                jenis = "Sales";
                            }
                            nourut++;
                            Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}, {4}", 
                                nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), jenis);
                        }
                        if (nourut < 1)
                        {
                            Console.WriteLine("Data Karyawan Kosong");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Menu Yang  Di Masukkan Salah!!!");
                        break;
                }
                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}