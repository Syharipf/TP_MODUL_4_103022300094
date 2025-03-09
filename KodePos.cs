using System;

class KodePos
{
    // Array dua dimensi untuk menyimpan kelurahan dan kode pos
    private string[,] daftarKodePos = {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
    public string GetKodePos(string kelurahan)
    {
        for (int i = 0; i < daftarKodePos.GetLength(0); i++) // Iterasi semua baris
        {
            if (daftarKodePos[i, 0].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
            {
                return daftarKodePos[i, 1]; // Mengembalikan kode pos
            }
        }
        return "Kelurahan tidak ditemukan!";
    }
}
