namespace responsi2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> list = new List<Data>();
            while (true)
            {
                
                Console.WriteLine("Pilih menu aplikasi:");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Tampilkan");
                Console.WriteLine("3. Keluar");
                Console.WriteLine();

                Console.Write("Nomor menu [1..3] : ");
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Tambah tambah = new Tambah(list);
                    Console.Clear();
                    Console.WriteLine("=========================");
                    Console.WriteLine("Buku berhasil ditambahkan");
                    Console.WriteLine("=========================");
                }
                else if (menu == 2)
                {
                    Tampilan tampilan = new Tampilan(list);
                }
                else if (menu == 3)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Maaf inputan tidak valid :(");
                    Console.WriteLine("===========================");
                }
            }
            Console.ReadKey();
        }
    }
}