using System;

class Program
{
    static void Main(string[] args)
    {
        // Memanggil method GetKodePos dari class KodePos
        string kodePos = KodePos.GetKodePos("Batununggal");
        Console.WriteLine($"Kode Pos Batununggal: {kodePos}");
    }
}