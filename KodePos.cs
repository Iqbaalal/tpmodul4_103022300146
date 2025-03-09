using System;
using System.Collections.Generic;

public class KodePos
{
    // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
    public static string GetKodePos(string kelurahan)
    {
        // Membuat dictionary untuk menyimpan data kode pos
        var kodePos = new Dictionary<string, string>
        {
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

        // Mengembalikan kode pos jika kelurahan ditemukan
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}