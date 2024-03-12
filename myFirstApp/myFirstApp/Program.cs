// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("mod1");
Console.WriteLine("mod2");
Console.WriteLine("mod3");

static double GetAverage(int[] numbers)
{
    var suma = 0;
    foreach (var number in numbers)
    {
        suma += number;
    }

    return (double) suma / numbers.Length;
}