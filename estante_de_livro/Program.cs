int QtdLivros = 0;
Livro[] Livros;

Console.Write("Informe a quantidade de livros que deseja guardar: ");
QtdLivros = int.Parse(Console.ReadLine());
Livros = new Livro[QtdLivros];

Livro CriarLivro(int indice)
{
    Livro livro = new Livro();

    Console.WriteLine($"LIVRO {indice + 1}:");
    Console.Write("\nInforme o TITULO: ");
    livro.Titulo = Console.ReadLine();

    Console.Write("\nInforme o autor ou autores: ");
    livro.Autor = Console.ReadLine();

    Console.Write("\nInforme a data de lancamento: ");
    livro.DataLancamento = DateOnly.Parse(Console.ReadLine());

    Console.Write("\nInforme a editora: ");
    livro.Editora = Console.ReadLine();

    Console.Write("\nInforme a edicao: ");
    livro.Edicao = Console.ReadLine();

    Console.Write("\nInforme o ISBN: ");
    livro.ISBN = int.Parse(Console.ReadLine());

    Console.Write("\nInforme a quantidade de paginas: ");
    livro.QtdPaginas = int.Parse(Console.ReadLine());

    return livro;
}

for (int l = 0; l < QtdLivros; l++)
{
    Livros[l] = CriarLivro(l);
}

for (int l = 0; l < QtdLivros; l++)
{
    Console.WriteLine("\n--------------------------------------------------\n");
    Livros[l].ImprimirLivro();
    Console.WriteLine("\n--------------------------------------------------\n");
}