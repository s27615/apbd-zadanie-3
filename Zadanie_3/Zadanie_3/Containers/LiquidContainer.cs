namespace Zadanie_3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight, double height) : base(cargoWeight, height)
    {
        
    }
    
    //virtual to javowy override, przeciagniecie
    
    public virtual void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }
}