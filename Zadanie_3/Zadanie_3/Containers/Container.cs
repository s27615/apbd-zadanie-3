using Zadanie_3.Exceptions;
using Zadanie_3.interfaces;

namespace Zadanie_3.Containers;

public class Container : IContainer
{
    //prop, tabulacja, to jest to samo co to wyzej
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    
    public Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }

    //mozna tu dodac abstract
    public void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new OverfillException();
    }

    
}