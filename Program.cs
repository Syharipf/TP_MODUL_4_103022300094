class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine(); // Pintu mulai dalam keadaan terkunci

        Console.WriteLine("\nSimulasi perubahan state:");
        pintu.BukaPintu();  // Ubah ke "Terbuka"
        pintu.KunciPintu(); // Ubah ke "Terkunci"
        pintu.KunciPintu(); // Coba kunci lagi (tidak berubah)
    }
}
