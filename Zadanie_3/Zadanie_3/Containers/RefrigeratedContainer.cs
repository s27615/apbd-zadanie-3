namespace Zadanie_3.Containers;

public class RefrigeratedContainer : Container

{
    public PossibleProducts ProductType;
    public double Temperature;
    
    public RefrigeratedContainer(PossibleProducts product, double temperature, double cargoWeight, double height, double weight, double depth, double max) : base(cargoWeight, height, weight, depth, max)
    {
        if (!IsTemperatureValidForProductType(temperature, product))
        {
            throw new InvalidOperationException($"Temperature {temperature} is not valid for product type {product}.");
        }
        Temperature = temperature;
        NumberSer += "-R-" + Id;
        ProductType = product;
        Console.WriteLine("Utworzono kontener " + NumberSer);
    } 
    private bool IsTemperatureValidForProductType(double temperature, PossibleProducts productType)
    {
        switch (productType)
        {
            case PossibleProducts.Banana:
                return temperature >= 13.3;
            case PossibleProducts.Chocolate:
                return temperature >= 18;
            case PossibleProducts.Fish:
                return temperature >= 2;
            case PossibleProducts.Meat:
                return temperature >= -15;
            case PossibleProducts.IceCream:
                return temperature >= -18;
            case PossibleProducts.FrozenPizza:
                return temperature >= -30;
            default:
                return true;
        }
    }
    public virtual void show()
    {
        base.show();
        Console.WriteLine("Przewożone produkty: " + ProductType);
        Console.WriteLine("Temperatura: " + Temperature);
    }
}