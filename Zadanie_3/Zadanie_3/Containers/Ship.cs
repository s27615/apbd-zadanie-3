using System.Xml;

namespace Zadanie_3.Containers;

public class Ship
{
    public List<Container> Containers = new List<Container>();
    public double Speed;
    public int MaxContainers;
    public double MaxWeight;
    public int counter = 0;
    private int cont = 0;

    public Ship(int maxContainers, double speed, double maxWeight)
    {
        MaxContainers = maxContainers;
        Speed = speed;
        MaxWeight = maxWeight;
        Console.WriteLine("Utworzono kontenerowiec");
    }

    public void addContainer(Container container)
    {
        if (cont < MaxContainers && totalWeight() < MaxWeight)
        {
            Containers[counter++] = container;
            cont++;
            Console.WriteLine("Dodano kontener na statek");
        }
        Console.WriteLine("Nie można załadować kontenera na statek");
    }
    public void removeContainer(String code)
    {
        
        for(int i = Containers.Count - 1; i >= 0; i--)
        {
            if (Containers[i].NumberSer == code)
            {
                Containers.RemoveAt(i);
                Console.WriteLine("Usunięto kontener ze statku.");
            }
            Console.WriteLine("Kontenera nie znaleziono.");
        }
    }
    
    public void addContainers(List<Container> containers)
    {
        if (cont < MaxContainers && totalWeight() < MaxWeight)
        {
            Containers = containers;
            Console.WriteLine("Dodano kontenery na statek");
        }
        Console.WriteLine("Nie można załadować kontenerów na statek");
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
    
    public void unload()
    {
        Containers = new List<Container>();
        Console.WriteLine("Usunięto wszystkie kontenery ze statku");
    }

    public double totalWeight()
    {
        double total = 0;
        foreach (Container c in Containers)
        {
            total += c.Weight + c.CargoWeight;
        }

        return total;
    }
    
    public void change(String codeA, String codeB)
    {
        for(int i = Containers.Count - 1; i >= 0; i--)
        {
            if (Containers[i].NumberSer == codeA)
            {
                Containers[i] = find(codeB);
                Console.WriteLine("Zamieniono kontenery");
            }
        }
    }

    public Container find(String code)
    {
        foreach (Container c in Containers)
        {
            if (c.NumberSer == code)
            {
                return c;
            }
        }
        return null;
    }
}