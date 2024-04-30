internal class Livro
{
    private string titulo;
    private string autor;
    private DateOnly dataLancamento;
    private string editora;
    private string edicao;
    private string iSBN;
    private int qtdPaginas;

    public string Titulo { get => titulo; set => titulo = value; }
    public string Autor { get => autor; set => autor = value; }
    public DateOnly DataLancamento { get => dataLancamento; set => dataLancamento = value; }
    public string Editora { get => editora; set => editora = value; }
    public string Edicao { get => edicao; set => edicao = value; }
    public string ISBN { get => iSBN; set => iSBN = value; }
    public int QtdPaginas { get => qtdPaginas; set => qtdPaginas = value; }

    public void ImprimirLivro()
    {
        Console.WriteLine(
            $"1 - Titulo: {this.Titulo}\n" +
            $"2 - Autor: {this.Autor}\n" +
            $"3 - Data de lancamento: {this.DataLancamento}\n" +
            $"4 - Editora: {this.Editora}\n" +
            $"5 - Edicao: {this.Edicao}\n" +
            $"6 - ISBN: {this.ISBN}\n" +
            $"7 - Quantidade de paginas: {this.QtdPaginas}"
            );
    }
}