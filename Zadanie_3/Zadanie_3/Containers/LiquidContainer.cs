namespace Zadanie_3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }
}