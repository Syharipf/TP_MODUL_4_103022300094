class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos(); // Membuat objek KodePos

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine(); // Membaca input pengguna

        string hasil = kodePos.GetKodePos(kelurahan); // Mencari kode pos

        Console.WriteLine($"Kode Pos untuk {kelurahan}: {hasil}"); // Menampilkan hasil

        DoorMachine pintu = new DoorMachine(); // Pintu mulai dalam keadaan terkunci

        Console.WriteLine("\nSimulasi perubahan state:");
        Console.Write("Buka pintu: "); 
        pintu.BukaPintu();  // Ubah ke "Terbuka"
        Console.Write("Kunci pintu: ");
        pintu.KunciPintu(); // Ubah ke "Terkunci"
        Console.Write("Kunci pintu: ");
        pintu.KunciPintu(); // Coba kunci lagi (tidak berubah)
    }
}
