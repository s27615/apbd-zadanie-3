using Zadanie_3.Containers;

//tworzenie kontenerow oraz statku
Container c = new GasContainer(2.5, 90, 34, 4, 5);
Container c1 = new LiquidContainer(2.5, 900, 34, 4, 5);
Container c2 = new RefrigeratedContainer(PossibleProducts.Meat, -12,2.5, 90, 34, 4, 5);
Container c3 = new LiquidContainer(233, 544, 753, 23, 456);
Ship s = new Ship(4, 300, 7);
//zaladowanie kontenera
c.Load(PossibleProducts.Banana, 30);

//wyswietlenie informacji o kontenerach oraz statku
s.show();
c.show();
c1.show();
c2.show();

//dodanie kontenera do statku
s.addContainer(c3);

//dodawanie listy kontenerow do statku
List<Container> con = new List<Container>(){ c, c1, c2 };
Ship b = new Ship(2, 30, 900);
b.addContainers(con);

//usuniecie kontenera o numerze
b.removeContainer("KON-G-1");

//rozladowanie kontenera
c.Unload();

//zastapienie kontenera
s.change(c1.NumberSer, c2.NumberSer);

//przeniesienie kontenera do drugiego statku
Container container1 = new GasContainer(2, 4, 3, 3, 5);
Container container2 = new GasContainer(2, 1, 333, 3454, 52);
Ship ship1 = new Ship(3, 5, 7);
Ship ship2 = new Ship(33, 25, 73);

ship1.addContainer(container1);
ship2.addContainer(container2);

ship1.change(container1.NumberSer, container2.NumberSer);
ship2.addContainer(container2);