using System;

class Program
{
    static void Main(string[] args)
    {
        // Memanggil method GetKodePos dari class KodePos
        string kodePos = KodePos.GetKodePos("Batununggal");
        Console.WriteLine($"Kode Pos Batununggal: {kodePos}");

        // Membuat objek dari class DoorMachine
        DoorMachine door = new DoorMachine();

        // Mensimulasikan perubahan state
        door.Unlock(); // Pintu tidak terkunci
        door.Lock();   // Pintu terkunci
    }
}