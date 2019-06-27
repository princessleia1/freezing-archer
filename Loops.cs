// Loops for counter operations
// While statement keeps checking condition and executing statements until condition is false
// Ensure while loop condition reaches a false
// New operator ++ increment
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Use loops to repeat operations, counter is {counter}.");
  counter++;
}

// Do while loop same
// Executes code first then checks condition
int count = 0;
do
{
    Console.WriteLine($"Counter is {count}.");
    count++;
}
while (count < 100);

// Common loop for statement
// Initionalise counter first to 0
// Counter for condition until less than 10
// For iterator counter ++ specifies how to modify loop var after executing
// block following for statement
for (int countLoop = 0; countLoop < 10; countLoop++)
{
    Console.WriteLine($"For loop counter is {countLoop}.");
}

// Change initialiser to start at diff value and condition to stop at diff value
for (int countValue = 99; countValue < 199; countValue++)
{
    Console.WriteLine($"For loop counter is {countValue}.");
}