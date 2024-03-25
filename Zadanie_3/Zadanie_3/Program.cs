using Zadanie_3;
using Zadanie_3.Containers;

Container c = new GasContainer(2.5, 90, 34, 4, 5);
Container c1 = new GasContainer(2.5, 90, 34, 4, 5);
Container c2 = new GasContainer(2.5, 90, 34, 4, 5);
Console.WriteLine(c.NumberSer);
Console.WriteLine(c1.NumberSer);
Console.WriteLine(c2.NumberSer);


// ArrayList
List<int> numbers = new List<int>() { 1, 2, 3 };
List<int> numbers2 = new() { 1, 3, 4};
var numbers3 = new List<int>() { 4, 5, 6};

// HashMap
Dictionary<PossibleProducts, double> products = new();