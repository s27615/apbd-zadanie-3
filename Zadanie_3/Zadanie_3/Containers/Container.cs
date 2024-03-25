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
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWeight = cargoWeight;
        throw new OverfillException();
    }
}