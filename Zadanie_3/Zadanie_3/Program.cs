﻿using Zadanie_3;
using Zadanie_3.Containers;

// var container = new Container(10.0, 15.0) 
//     { 
//         CargoWeight = 12.0,
//         Height = 12.0
//     };
// container.CargoWeight = 10.0;

int? a = 1;
a = null;

bool? b = true;
b = null;

Exception? ex = new Exception();
ex = null;


// ArrayList
List<int> numbers = new List<int>() { 1, 2, 3 };
List<int> numbers2 = new() { 1, 3, 4};
var numbers3 = new List<int>() { 4, 5, 6};

// HashMap
Dictionary<PossibleProducts, double> products = new();