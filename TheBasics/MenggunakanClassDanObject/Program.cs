using System;

namespace TheBasics
{
    class MenggunakanObjectBuku
    {
        static void Main(string[] args)
        {
            Buku bukuSatu = new Buku();
            bukuSatu.judulBuku="Buku Saku";
            bukuSatu.jumlahHalaman=129;
            bukuSatu.penulis="Penulis Buku Saku";
            
            Console.WriteLine(bukuSatu.judulBuku);
            Console.WriteLine(bukuSatu.jumlahHalaman);
            Console.WriteLine(bukuSatu.penulis);
            Console.ReadLine();
        }
    }
}