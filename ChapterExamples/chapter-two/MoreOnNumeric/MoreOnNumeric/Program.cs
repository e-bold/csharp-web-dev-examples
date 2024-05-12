//More on Numeric Types
Console.WriteLine("How many miles have you driven? (miles)");
string miles = Console.ReadLine();
Console.WriteLine("How much gas did you use? (gallons)");
string gas = Console.ReadLine();
double mpg = Int32.Parse(miles) / Int32.Parse(gas);

Console.WriteLine("The MPG for the trip was: " + mpg);

