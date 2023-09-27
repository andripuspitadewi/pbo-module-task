using System;

//class Laptop (base class)
public class Laptop
{
    public string Merk;
    public string Tipe;
    public string Vga;
    public string Processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} dengan VGA {Vga} dan Processor {Processor} menyala.");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} dengan VGA {Vga} dan Processor {Processor} dimatikan.");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} dengan VGA {Vga} dan Processor {Processor} sedang memainkan game.");
    }

    public void Ngoding()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} dengan VGA {Vga} dan Processor {Processor} sedang ngoding. Ctak Ctak Ctak, error lagi!!");
    }
}

//class Vivobook (inherits from Laptop)
public class Vivobook : Laptop
{
}

//class IdeaPad (inherits from Laptop)
public class IdeaPad : Laptop
{
}

//class Predator (inherits from Laptop)
public class Predator : Laptop
{
}

//class ACER
public class ACER : Laptop
{
}

public class Program
{
    public static void Main()
    {
        //buat objek laptop1 (Vivobook)
        Vivobook laptop1 = new Vivobook
        {
            Merk = "Vivobook",
            Tipe = "Tipe Laptop 1",
            Vga = "Nvidia",
            Processor = "Core i5"
        };

        //buat objek laptop2 (IdeaPad)
        IdeaPad laptop2 = new IdeaPad
        {
            Merk = "IdeaPad",
            Tipe = "Tipe Laptop 2",
            Vga = "AMD",
            Processor = "Ryzen"
        };

        //buat objek predator (Predator)
        Predator predator = new Predator
        {
            Merk = "Predator",
            Tipe = "Tipe Laptop Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        //buat objek acer menjadi objek predator (Predator)
        ACER predator = new ACER
        {
            Merk = "Predator",
            Tipe = "Tipe Laptop Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        //panggil method pada laptop1, laptop2, dan predator
        laptop1.LaptopDinyalakan();
        laptop2.LaptopDinyalakan();
        predator.LaptopDinyalakan();
        predator.LaptopDinyalakan();

        laptop1.LaptopDimatikan();
        laptop2.LaptopDimatikan();
        predator.LaptopDimatikan();
        predator.LaptopDimatikan();

        laptop1.BermainGame();
        laptop2.BermainGame();
        predator.BermainGame();
        predator.BermainGame();

        laptop1.Ngoding();
        laptop2.Ngoding();
        predator.Ngoding();
        predator.Ngoding();
    }
}
