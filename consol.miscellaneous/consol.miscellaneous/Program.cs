// See https://aka.ms/new-console-template for more information
using consol.miscellaneous;

Console.WriteLine("Utilities!");
var numbers = Utilities.fill(10, 0, 9);
Console.WriteLine(Utilities.ToString(numbers));
Console.WriteLine("Moda!");
var modas = Utilities.Moda(numbers);
Console.WriteLine(Utilities.ToString(modas));