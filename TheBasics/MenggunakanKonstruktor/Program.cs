using System;

namespace TheBasics
{
    class MenggunakanKonstruktor
    {
        static void Main(string[] args)
        {
            Buku bukuSatu = new Buku("Buku Saku", 129, "Penulis Buku Saku");
            Buku bukuDua = new Buku("Buku Dua", 901, "Penulis Buku Dua");

            Console.WriteLine(bukuSatu.judulBuku);
            Console.WriteLine(bukuSatu.jumlahHalaman);
            Console.WriteLine(bukuSatu.penulis);

            Console.WriteLine(bukuDua.judulBuku);
            Console.WriteLine(bukuDua.jumlahHalaman);
            Console.WriteLine(bukuDua.penulis);

            Console.ReadLine();
        }
    }
}