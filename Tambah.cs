using System;
using System.Collections.Generic;
namespace responsi2
{
	public class Tambah
	{
		public Tambah(List<Data> list)
		{
            Console.Clear();
            Console.WriteLine("INPUT DATA BUKU");
            Console.WriteLine("===============");
            Console.Write("ISBN\t\t\t: ");
            int isbn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Judul\t\t\t: ");
            string judul = Console.ReadLine();

            Console.Write("Kode bahasa[ID/EN]\t: ");
            string bahasa = Console.ReadLine();
            if (bahasa.ToUpper() == "ID")
            {
                bahasa = "Bahasa Indonesia";
            }
            else if(bahasa.ToUpper() == "EN")
            {
                bahasa = "English";
            }

            Console.Write("Jumlah buku\t\t: ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            list.Add(new Data
            {
                ISBN = isbn,
                Judul = judul,
                Bahasa = bahasa,
                Jumlah = jumlah
            });
        }
	}
}