using System;

namespace TheBasics
{
    class Buku
    {
        public string judulBuku;
        public int jumlahHalaman;
        public string penulis;
    
        public Buku(string aJudul, int aHalaman, string aPenulis)
        {
            judulBuku = aJudul;
            jumlahHalaman = aHalaman;
            penulis = aPenulis;
        }

    }
}