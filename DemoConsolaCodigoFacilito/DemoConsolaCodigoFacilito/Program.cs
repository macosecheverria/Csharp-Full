using DemoConsolaCodigoFacilito;

var suma = Example.Suma(20,20);

var mult = (int number1, int number2) =>
{
    return number1 * number2;

};

Console.WriteLine($"La suma es: {suma}");
Console.WriteLine(($"La multiplicacion es: {mult(10,10)}"));

List<string> nombres = new List<string>(){"Marcos", "manuel", "Jose"};

nombres.ForEach(nombre => Console.WriteLine(nombre.ToUpper()));

var nameStartWithM = nombres.Select(
    name => name.StartsWith("m")).ToList();

Console.WriteLine($"Name start with m: {nameStartWithM}");

var calcularResta = (int a, int b) =>
{

    return Resta();

    int Resta()
    {
        return a - b;
    }
};

Console.WriteLine($"calculando resta : {calcularResta}");

