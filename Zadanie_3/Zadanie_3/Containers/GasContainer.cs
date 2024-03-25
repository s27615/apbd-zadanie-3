using Zadanie_3.interfaces;

namespace Zadanie_3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        NumberSer += "-G-" + Id;
    }
    
    public override void Load(PossibleProducts product, double cargoWeight)
    {
        base.Load(product, cargoWeight);
        if (CargoWeight > MaxCargo)
        {
            throw new Exception("Przekroczono dopuszczalną łądowność");
        }
    }
    public void Unload()
    {
        CargoWeight = 0.05 * CargoWeight;
        Console.WriteLine("Opróżniono ładunek");
    }

    public void Notification(Container container)
    {
        Console.Write("Zaszła niebezpieczna sytuacja dla kontenera o numerze seryjnym: " + container.NumberSer);
    }
}