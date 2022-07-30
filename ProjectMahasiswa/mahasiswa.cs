using System;                               // merupakan deklarasi library yang dibutuhkan untuk menggunakan class Console dan method WriteLine().
using System.Collections.Generic;           // merupakan deklarasi library program yang digunakan apabila Element dalam Collection untuk menyimpan maupun memanipulasi Data
using System.Linq;                          // merupakan deklarasi library yang Menyediakan class dan Antarmuka untuk mendukung LINQ query
using System.Text;                          // merupakan deklarasi library program berisi class yang mewakili pengkodean karakter ASCII dan Unicode

namespace ProjectMahasiswa
{
    public class mahasiswa       // merupakan class object dengan nama variabel mahasiswa
    {                                                  //tipe data string untuk menyatakan sekumpulan karakter
        public int Nim { get; set; }                // ini merupakan property "Nim" dengan tipe data string dan get set adalah accessors , artinya mereka dapat mengakses data
        public string Nama { get; set; }               // ini merupakan property "Nama" dengan tipe data string dan get set adalah accessors , artinya mereka dapat mengakses data
        public string Ipk { get; set; }                // ini merupakan property "Ipk" dengan tipe data string dan get set adalah accessors , artinya mereka dapat mengakses data
        public string Jenis { get; set; }              // ini merupakan property "Jenis" dengan tipe data string dan get set adalah accessors , artinya mereka dapat mengakses data

    }
}