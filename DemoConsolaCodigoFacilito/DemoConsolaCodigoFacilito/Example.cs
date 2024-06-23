namespace DemoConsolaCodigoFacilito;

public class Example(long id, string name, string description)
{
    private long Id { get; set; } = id;

    private string Name { get; set; } = name;

    private string Description { get; set; } = description;

    public static  Func<int, int, int> Suma = (a, b) => a + b;

}