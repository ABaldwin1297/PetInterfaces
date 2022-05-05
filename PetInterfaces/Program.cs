using PetInterfaces;

var Fred = new Boxer();
var Roxy = new Bully();
var Beans = new Mut();

IDog[] dogs = {Fred, Roxy, Beans};

foreach (var dog in dogs) {
    Console.WriteLine($"Name {dog.Name}, color is {dog.Color}, and is {(dog.IsLarge ? "large" : "small")}" + 
           $" and makes the sound {dog.Bark()}");
}