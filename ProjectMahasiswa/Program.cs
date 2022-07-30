using System;                            // merupakan deklarasi library yang dibutuhkan untuk menggunakan class Console dan method WriteLine().
using System.Collections.Generic;       // merupakan deklarasi library program yang digunakan apabila Element dalam Collection untuk menyimpan maupun memanipulasi Data
using System.Linq;                     // merupakan deklarasi library yang Menyediakan class dan Antarmuka untuk mendukung LINQ query
using System.Text;                    // merupakan deklarasi library program berisi class yang mewakili pengkodean karakter ASCII dan Unicode

namespace ProjectMahasiswa
{
    public class program     // terdapat class object dengan nama variabel program
    {

        static List<mahasiswa> daftarMahasiswa = new List<mahasiswa>();        // mendeklarasikan object colection untuk menampung object mahasiswa

        static void Main(string[] args)   // untuk menyimpan nilai argumen yang diberikan dari CMD atau terminal, sehingga kita bisa mengolahnya dalam program
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";    //  untuk ditampilkan pada judul console

            while (true)           // konstruksi perulangan while bernilai true
            {
                TampilMenu();      // method pilihan menu program

                Console.Write("\nNomor Menu [1..3]: ");               // menampilkan nomor menu 1-3
                int nomorMenu = Convert.ToInt32(Console.ReadLine());  // Mengkonversi nilai nomorMenu tertentu ke sebuah nilai integer 

                switch (nomorMenu)  // terdapat pernyataan Switch dengan beberapa case
                {
                    case 1:
                        TambahMahasiswa();          //  pernyataan nilai tambahmahasiswa
                        break;                      //keluar dari sistem switch kemudian meneruskan pada program selanjutnya

                    case 2:
                        TampilMahasiswa();          //  pernyataan nilai tampilmahasiswa
                        break;                      // keluar dari sistem switch kemudian meneruskan pada program selanjutnya

                    case 3:                    // keluar dari program 
                        return;               // untuk mengakhiri program

                    default:                    //default dapat difungsikan sebagai penolakan apabila nilai variabel tidak ada yang sama dengan Case pada statement Switch
                      break;                    //untuk menghentikan proses perulangan ( Loop ) pada program
                }
            }
        }

        static void TampilMenu()                            // sebuah method tipe data void untuk menjalankan perintah menampilkan piliham menu program
        {
            Console.Clear();                                 // untuk menghapus tampilan yang dibuat

            Console.WriteLine("\tPilih Menu Aplikasi");      // menampilkan pilihan menu aplikasi dan \t untuk memberi spasi
            Console.WriteLine("\n 1. Tambah Mahasiswa");     // menampilkan pilihan 1. tambah mahasiswa dan \n untuk menambah 1 baris
            Console.WriteLine(" 2. Tampilkan Mahasiswa");    // menampilkan pilihan 2. tampilkan mahasiswa
            Console.WriteLine(" 3. Keluar");                 // menampilkan pilihan keluar untuk mengakhiri program

        }

        static void TambahMahasiswa()   // // sebuah method tipe data void untuk menjalankan perintah dalam menambahkan data mahasiswa 
        {
            Console.Clear();                                          // untuk menghapus tampilan yang dibuat
            mahasiswa Mhs = new mahasiswa();                          // sebuah class mahasiswa dan Mhs yaitu variable berrfungsi sebagai string

            Console.WriteLine("\nTambah Data Mahasiswa           ");  // menampilkan "Tambah Data Mahasiswa" dengan Console.WriteLine berarti menampilkan data pada baris baru 

            Console.Write("\n Nim                 : ");               // menampilkan "Nim" dengan Console.Write berarti akan menampilkan data pada baris yang sama
            Mhs.Nim = Convert.ToInt32(Console.ReadLine());            // perintah input nim dengan mhs merupakan variabel berfungsi sebagai string dikonversi ke tipe data integer

            Console.Write(" Nama Lengkap        : ");                // menampilkan "Nama Lengkap" dengan Console.Write berarti akan menampilkan data pada baris yang sama
            Mhs.Nama = Console.ReadLine();                           //  perintah input Nama dengan mhs merupakan variabel berfungsi sebagai string

            Console.Write(" Jenis Kelamin [L/P] : ");               // menampilkan "Jenis Kelamin [L/P]" dengan Console.Write berarti akan menampilkan data pada baris yang sama
            string jenis = Console.ReadLine();                      // perintah untuk meminta input,berupa tipe data string, "jenis" adalah variabel untuk jenis kelamin

            Console.Write(" Ipk                 : ");               // menampilkan "Ipk" dengan Console.Write berarti akan menampilkan data pada baris yang sama
            Mhs.Ipk = Console.ReadLine();                           // perintah input ipk dengan mhs merupakan variabel berfungsi sebagai string

            Mhs.Jenis = (jenis == "L" || jenis == "P") ? "Laki-laki" : "Perempuan"; // ini merupakan Logical operators or untuk pemilihan jenis kelamin

            daftarMahasiswa.Add(Mhs);      // membaca sebuah data nilai dari keseluruhan daftarmahasiswa dari inputan mhs

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu"); //menampilkan pilihan kembali ke menu awal
            Console.ReadKey();        //berupa data karakter biasa digunakan untuk menahan program saat di run tidak langsung close jadi menunggu karakter yang diketikan
        }

        static void TampilMahasiswa()                        // sebuah method tipe data void untuk menjalankan perintah menampilkan program dari data mahasiswa
        {
            Console.Clear();                                 // untuk menghapus tampilan yang dibuat

            Console.WriteLine("\n Data Mahasiswa");          // menampilkan "Tambah Data Mahasiswa" dengan Console.WriteLine berarti menampilkan data pada baris baru

            if (daftarMahasiswa.Count > 0) //kondisi jika bernilai 0 berarti false 
            {
                for (int i = 0; i < daftarMahasiswa.Count; i++) //index i bernilai true
                {
                    Console.WriteLine("\n{0}| {1} |  {2} , {3} , {4}, {5} ", " ", i + 1,daftarMahasiswa[i].Nim, daftarMahasiswa[i].Nama, 
                                                                                       daftarMahasiswa[i].Jenis, daftarMahasiswa[i].Ipk);
                    // menampilkan data mahasiswa yaitu nim, nama, jenis kelamin , dan ipk// menampilkan data mahasiswa yaitu nim, nama, jenis kelamin , dan ipk
                }
            }

            else //jika bernilai 0 false maka
            {
                Console.WriteLine("\n Tidak Ada Data Mahasiswa"); // akan menampilkan tidak ada data Mahasiswa
            }

                    Console.WriteLine("\nTekan enter untuk kembali ke menu"); //menampilkan pilihan kembali ke menu awal
            Console.ReadKey();    // berupa data karakter biasa digunakan untuk menahan program saat di run tidak langsung close jadi menunggu karakter yang diketikan
        }
    }
}