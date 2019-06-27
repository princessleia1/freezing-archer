int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
int max = int.MaxValue;
int min = int.MinValue;
int what = max + 3;

// Integer example
Console.WriteLine($"Quotient: {d}");
Console.WriteLine($"Remainder: {e}");
// Min and max limits
Console.WriteLine($"Range of Integers is {min} to {max}");
// Overflow example
Console.WriteLine($"An example of overflow: {what}");
