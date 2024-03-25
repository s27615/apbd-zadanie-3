namespace Zadanie_3.Containers;

public class GasContainer : Container
{
    public GasContainer(double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        NumberSer += "-G-" + Id;
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }
}