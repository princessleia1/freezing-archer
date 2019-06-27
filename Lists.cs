// Create list of strings calling name.ToUpper method all caps
// String interpolation feature
var names = new List<string> { "Princess Leia", "Luke", "Han"};
foreach (var name in names)
{
    Console.WriteLine($"Hi Jedi {name.ToUpper()}!");
}

// Modify list contents list <t> type to grow
Console.WriteLine();
names.Add("Chewbacca");
names.Add("Darth Vader");
names.Add("C3-PO");
names.Remove("Han");
foreach (var name in names)
{
    Console.WriteLine($"Hi Jedi {name.ToUpper()}!");
}

// List <T> enables reference to items by index using []
Console.WriteLine($"Jedi Name is {names[0]}.");
Console.WriteLine($"Jedi Names added are {names[2]} and {names[3]} and {names[4]} to the list.");
// Add count property
Console.WriteLine($"The list has {names.Count} Jedi in it.");

// Search and sort List <T>
var index = names.IndexOf("Vader");
if (index != -1)
    Console.WriteLine($"6. The Jedi {names[index]} is at index {index}.");
    
// Always check index returned by IndexOf -1
    var notFound = names.IndexOf("Not Found");
        Console.WriteLine($"7. When an item is not found, IndexOf returns {notFound}");

// Call Sort method
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"8. Hi Jedi {name.ToUpper()}!");
}