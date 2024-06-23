namespace DemoConsolaCodigoFacilito.crudconsole;

public class Book(long id, string? title, string? author, string? category, bool isAvailable)
{
    public  long Id { get; set; } = id;

    public string Title { get; set; } = title;

    public string Author { get; set; } = author;

    public string? Category { get; set; } = category;

    public bool IsAvailable { get; set; } = isAvailable;


}