// Specify alignment by comma (",") after interpolation expression and designating minimum field width. 
var inventory = new Dictionary<string, int>()
  {
      ["hammer, ball pein"] = 18,
      ["hammer, cross pein"] = 5,
      ["screwdriver, Phillips #2"] = 14
  };

  Console.WriteLine($"Inventory on {DateTime.Now:d}");
  Console.WriteLine(" ");
  Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
  foreach (var item in inventory)
     Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");

// Item names right aligned.
  Console.WriteLine($"Inventory on {DateTime.Now:d}");
  Console.WriteLine(" ");
  Console.WriteLine($"|{"Item",25}|{"Quantity",10}|");
  foreach (var item in inventory)
     Console.WriteLine($"|{item.Key,25}|{item.Value,10}|");

// Combine alignment specifier and a format string for a single interpolation expression.
Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");