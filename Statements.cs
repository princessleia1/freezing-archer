// True branch
// If statement checks value of bool
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("1. The answer is greater than 10.");

// False branch
// If statement checks value of bool
int c = 3;
int d = 8;
if (c + d > 10)
{
    Console.WriteLine("2. The answer is greater than 10.");
}
// Combine else with bool conditions
// Else only executes when condition tested is false
int e = 5;
int f = 6;
if (e + f > 10)
{
    Console.WriteLine("3. The answer is greater than 10.");
}
else
{
    Console.WriteLine("3. The answer is not greater than 10.");
}

int g = 5;
int k = 5;
int l = 10;
if ((g + k + l > 10) && (g == k))
{
    Console.WriteLine("5. The answer is greater than 10.");
    Console.WriteLine("5. And the first number is equal to the second.");
}
else
{   
    Console.WriteLine("5. The answer is not greater than 10.");
    Console.WriteLine("5. Or the first number is not equal to the second.");
}

// || Or condition
int m = 5;
int n = 3;
int o = 1;
if ((m + n + o > 10) || (m == o))
{
    Console.WriteLine("6. The answer is greater than 10.");
    Console.WriteLine("6. And the first number is equal to the second.");
}
else
{   
    Console.WriteLine("6. The answer is not greater than 10.");
    Console.WriteLine("6. Or the first number is not equal to the second.");
}