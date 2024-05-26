

//TODO: Try out your skills with inheritance here!
using Cats;

Console.WriteLine("Hello, Cats!");

HouseCat garfield = new HouseCat("Garfield", 12.0);

garfield.Eat();
Console.WriteLine(garfield.Tired);

HouseCat spike = new HouseCat("Spike");
Console.WriteLine(spike.Weight);


HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

Console.WriteLine(cheshireCat.Noise());
spike.Eat();
Console.WriteLine(spike.Family);
Cat suki = new HouseCat ("suki", 27);
Console.WriteLine(suki.Noise());
Console.WriteLine((suki as HouseCat).IsSatisfied());

CatSitter annie = new CatSitter(suki);
annie.FeedTheCat();
