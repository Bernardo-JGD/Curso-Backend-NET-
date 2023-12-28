string[] names =
{
    "Héctor", "Francisco", "Ana", "Hugo", "Pedro"
};

var namesAsc = from n in names
               orderby n
               select n;
Console.WriteLine("Nombres ascendentes");
foreach (var name in namesAsc)
{
    Console.WriteLine(name);
}

var namesDesc = from n in names
                orderby n descending
                select n;
Console.WriteLine("\nNombres descendentes");
foreach (var name in namesDesc)
{
    Console.WriteLine(name);
}

var namesLength3 = from n in names
                   where n.Length > 3
                   orderby n
                   select n;

Console.WriteLine("\nNombres ascendentes tamaño mayor a 3");
foreach (var name in namesLength3)
{
    Console.WriteLine(name);
}

var names3_5Orderby = names.Where(n => n.Length > 3 && n.Length < 5)
                           .OrderByDescending(n => n)
                           .Select(d => d);

Console.WriteLine("\nNombres con mas de 3 y menos de 5 desc");
foreach (var name in names3_5Orderby)
{
    Console.WriteLine(name);
}