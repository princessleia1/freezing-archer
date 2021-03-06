double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

// M suffix with math more digits to right of decimal point
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

decimal min = decimal.MinValue;
decimal max = decimal.MinValue;
// Type with greater precision
Console.WriteLine($"Range of decimal type is {min} to {max}");

// Using Math.PI field
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
Console.WriteLine($"Calculation of circle: {area}");