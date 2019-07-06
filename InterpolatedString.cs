// Must have string literal that begins with $ before quotation
// Must have 1 or more interpolation expressions opening and closing bracket, Add WriteLine method
var name = "Princess Leia";
Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

// Interpolated string can be of any data types
var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
var date = DateTime.Now;

// "C2" is a standard numeric format string that represents a number as a currency value with two digits after the decimal point. 
Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");

// "F3" for numeric value 3 decimal points after the decimal point.
Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price:F3} per {item.perPackage} items.");

// Specify a format string by following the interpolation expression with a colon (":") and the format string. 
Console.WriteLine($"On {date:y}, the price of {item.Name} was {item.Price} per {item.perPackage} items");

// "d" is a standard date and time format string that represents the short date format. 
Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price} per {item.perPackage} items");

// "t" is standard time
Console.WriteLine($"On {date:t}, the price of {item.Name} was {item.Price} per {item.perPackage} items");

// "e" is exponential notation
Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price:e2} per {item.perPackage} items.");