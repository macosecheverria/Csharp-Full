namespace DemoConsolaCodigoFacilito.crudconsole;

public class BookService
{

    private List<Book> _bookList = new List<Book>();

    public string CreateBook()
    {
        Console.WriteLine("Crear Libro");
        Console.WriteLine("Ingresa el author del libro");
        string? title = Console.ReadLine();
        string? author = Console.ReadLine();
        Console.WriteLine("Ingrese la categoria del libro");
        string? category = Console.ReadLine();
        Console.WriteLine("Esta disponible el tipo de dato debe de set true o falso");
        bool isAvailable = Convert.ToBoolean(Console.ReadLine());

        Book newBook = new Book(1, title, author, category, isAvailable);

        this._bookList.Add(newBook);

        return $"El nuevo libro creado {newBook}, y este esta es la lista de libros completa {this._bookList}";
    }

    public string UpdateBook()
    {
        Console.WriteLine("Actualizar Libro");
        Console.WriteLine("Ingrese el id del libro a actualizar");
        long bookId = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Ingrese el titulo del libro");
        string title = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el nombre del author");
        string author = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese la categoria del libro");
        string category = Console.ReadLine() ?? string.Empty;

    var existId = this._bookList.FirstOrDefault(book => book.Id == bookId);

        if (existId == null)
        {
            return $"El id {existId} no existe";
        }

        existId.Title = title;
        existId.Category = category;
        existId.Author = author;

        return $"El nuevo libro actualizado con los nuevos parametros {existId}";
    }

    public List<Book> GetAllBook()
    {
        return this._bookList;
    }

    public string DeleteBook()
    {

        Console.WriteLine("Ingrese el id del libro que quiera eliminar");
        long bookId = Convert.ToInt64(Console.ReadLine());

        var existId = this._bookList.FirstOrDefault(book => book.Id == bookId);

        if (existId == null)
        {
            return "";
        }



        return "";
    }


    private Book? FindById(long id)
    {
        var existBook = this._bookList.FirstOrDefault(book => book.Id == id);

        if (existBook == null)
        {
            return null;
        }

        return existBook;
    }
}