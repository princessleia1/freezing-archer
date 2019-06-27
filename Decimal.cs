double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

// m suffix with math more digits to right of decimal point
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

decimal min = decimal.MinValue;
decimal max = decimal.MinValue;
// type with greater precision
Console.WriteLine($"Range of decimal type is {min} to {max}");
