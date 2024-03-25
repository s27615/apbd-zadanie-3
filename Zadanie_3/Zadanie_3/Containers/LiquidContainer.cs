﻿using Zadanie_3.interfaces;

namespace Zadanie_3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        NumberSer += "-L-" + Id;
    }
    
    public override void Load(PossibleProducts product, double cargoWeight)
    {
        if (product == PossibleProducts.fuel)
        {
            MaxCargo /= 2;
            Console.Write("Wykryto niebezpieczną substancją. Maksymalna pojemność kontenera zostala zmniejszona o połowę.");
        }
        else
        {
            MaxCargo = 0.9 * MaxCargo;
        }
        base.Load(product, cargoWeight);
        if (cargoWeight > MaxCargo)
        {
            Notification(this);
        }
    }

    public void Notification(Container container)
    {
        Console.Write("Zaszła niebezpieczna sytuacja dla kontenera o numerze seryjnym: " + container.NumberSer);
    }
}