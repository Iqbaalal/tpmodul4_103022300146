using System;

public class DoorMachine
{
    // Enum untuk menyimpan state (status) pintu
    private enum State { Terkunci, Terbuka }

    // Variabel untuk menyimpan state saat ini
    private State currentState = State.Terkunci;

    // Method untuk mengunci pintu
    public void Lock()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    // Method untuk membuka kunci pintu
    public void Unlock()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }
}