//
using Eindtoets;

var destinations = new List<Destination>();
destinations.Add(new Destination { Country = "Germany", City = "Berlin", Rating = 4.19 });
destinations.Add(new Destination { Country = "Spain", City = "Valencia", Rating = 3.92 });
destinations.Add(new Destination { Country = "Hungary", City = "Budapest", Rating = 4.52 });
destinations.Add(new Destination { Country = "Germany", City = "Munich", Rating = 4.01 });
destinations.Add(new Destination { Country = "Austria", City = "Vienna", Rating = 3.56 });
destinations.Add(new Destination { Country = "Germany", City = "Dresden", Rating = 2.95 });

int counter = 0;
double total = 0;

foreach(var destination in destinations)
{
    counter++;
    total += destination.Rating;
}
//berekenen
double totalPrice = total / counter;
//count


Console.WriteLine(totalPrice.ToString());