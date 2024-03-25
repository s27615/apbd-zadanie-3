using Zadanie_3.interfaces;

namespace Zadanie_3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        NumberSer += "-L-" + Id;
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public void Notification(Container container)
    {
        Console.Write("Zaszła niebezpieczna sytuacja dla kontenera o numerze seryjnym: " + container.NumberSer);
    }
}