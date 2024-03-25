using System.Xml;

namespace Zadanie_3.Containers;

public abstract class Ship
{
    public Container[] Containers;
    public double Speed;
    public int MaxContainers;
    public double MaxWeight;
    protected Ship(int maxContainers, double speed, double maxWeight)
    {
        Containers = new Container[maxContainers];
        Speed = speed;
        MaxWeight = maxWeight;
    }

    public void show()
    {
        Console.WriteLine("Prędkość statku: " + Speed.ToString());
        Console.WriteLine("Maksymalna waga wszystkich kontenerów: " + MaxWeight.ToString());
        Console.WriteLine("Maksymalna liczba kontenerów na statku: " + MaxContainers.ToString());
        showContainers();
    }

    public void showContainers()
    {
        Console.WriteLine("Na statku znajdują się: ");
        foreach (Container c in Containers)
        {
            Console.WriteLine("Kontener " + c.NumberSer);
        }

    }
}