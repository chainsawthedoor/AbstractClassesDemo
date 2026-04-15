using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle's driving now!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motocycle is going on a virtual drive using the virtual method!");
    }
}