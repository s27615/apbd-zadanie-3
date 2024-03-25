using Zadanie_3.Exceptions;
using Zadanie_3.interfaces;

namespace Zadanie_3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public String NumberSer = "KON";
    public int Id;
    public static int Number = 1;
    public double MaxCargo;

    protected Container(double cargoWeight, double height, double weight, double depth, double maxCargo)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxCargo = maxCargo;
        Id = Number++;
    }

    public void Unload()
    {
        if (CargoWeight == 0)
        {
            throw new NotImplementedException();
        }
        CargoWeight = 0;
        Console.WriteLine("Kontener rozładowano");
    }

    public virtual void Load(PossibleProducts product, double LCargoWeight)
    {
        CargoWeight += LCargoWeight;
        if (CargoWeight > MaxCargo)
        {
            //CargoWeight -= LCargoWeight;
            throw new OverfillException();
        }
        Console.WriteLine("Kontener załadowano");
    }

    public virtual void show()
    {
        Console.WriteLine("Numer seryjny: " + NumberSer);
        Console.WriteLine("Cargo weight: " + CargoWeight);
        Console.WriteLine("Weight: " + Weight);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Depth: " + Depth);
    }
}