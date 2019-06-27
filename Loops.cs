// While statement keeps checking condition, executing statements until condition false
// Ensure while loop condition reaches false, new operator ++ increment
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"1. Use loops to repeat operations, counter is {counter}.");
  counter++;
}

// Do while loop same
// Executes code first then checks condition
int count = 0;
do
{
    Console.WriteLine($"2. Counter is {count}.");
    count++;
}
while (count < 100);

// Common loop for statement
// Initiate counter first to 0
// Counter for condition until less than 10
// For iterator counter ++ specifies how to modify loop var after executing block following statement
for (int CountLoop = 0; CountLoop < 10; CountLoop++)
{
    Console.WriteLine($"1. For loop counter is {CountLoop}.");
}

// Change initialiser to start at diff value and condition to stop at diff value
for (int CountValue = 99; CountValue < 199; CountValue++)
{
    Console.WriteLine($"2. For loop counter is {CountValue}.");
}

// Find sum of all integers 1 through 20 divisible by 3
int sum = 0;

for (int number = 1; number < 21; number ++)
{
   if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"3. Sum is {sum}.");