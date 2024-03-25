using Zadanie_3.Containers;

namespace Zadanie_3.interfaces;

public interface IContainer
{
    void Unload();
    void Load(PossibleProducts product, double cargoWeight);
}