public class Livro
{
    private string titulo;
    private string autor;
    private DateOnly dataLancamento;
    private string editora;
    private string edicao;
    private int iSBN;
    private int qtdPaginas;

    public Livro() { }

    public string Titulo { get => titulo; set => titulo = value; }
    public string Autor { get => autor; set => autor = value; }
    public DateOnly DataLancamento { get => dataLancamento; set => dataLancamento = value; }
    public string Editora { get => editora; set => editora = value; }
    public string Edicao { get => edicao; set => edicao = value; }
    public int ISBN { get => iSBN; set => iSBN = value; }
    public int QtdPaginas { get => qtdPaginas; set => qtdPaginas = value; }

    public void ImprimirLivro()
    {
        Console.WriteLine($"Titulo: {this.Titulo}");
        Console.WriteLine($"Autor: {this.Autor}");
        Console.WriteLine($"Data de lancamento: {this.DataLancamento}");
        Console.WriteLine($"Editora: {this.Editora}");
        Console.WriteLine($"Edicao: {this.Edicao}");
        Console.WriteLine($"ISBN: {this.ISBN}");
        Console.WriteLine($"Quantidade de paginas: {this.QtdPaginas}");
    }
}