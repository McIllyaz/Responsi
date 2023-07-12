using System;
using System.Collections.Generic;

namespace responsi2
{
	public class Tampilan
    { 
		public Tampilan(List<Data> list)
		{
            Console.Clear();
            Console.WriteLine("DAFTAR BUKU");
            Console.WriteLine("===========");
            foreach(Data buku in list)
            {
                int i = list.IndexOf(buku);
                Console.WriteLine("Buku ke-{0}", i + 1);
                Console.WriteLine("===========");
                Console.WriteLine($"ISBN\t\t\t: {buku.ISBN}\nJudul\t\t\t: {buku.Judul}\nBahasa\t\t\t: {buku.Bahasa}\nJumlah Buku\t\t: {buku.Jumlah}");
                Console.WriteLine("==================================================");
            }
            Console.WriteLine("Tekan enter / spasi untuk kembali ke menu :)");
            Console.ReadKey();
            Console.Clear();
        }
	}
}