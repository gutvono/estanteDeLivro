int QtdLivros = 0, opcao = 0;
Livro[] Livros = new Livro[1];

void Menu()
{
    do
    {
        Console.WriteLine("Insira o numero relacionado ao que você precisa:");
        Console.WriteLine("1 - Criar estante de livros;");
        Console.WriteLine("2 - Adicionar livros na estante;");
        Console.WriteLine("3 - Mostrar livros da estante;");
        Console.WriteLine("4 - Sair do sistema.");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CriarEstante();
                break;
            case 2:
                AdicionarLivros();
                break;
            case 3:
                MostrarLivros();
                break;
            default:
                break;
        }
    } while (opcao != 4);
}

void CriarEstante()
{
    Console.Write("Informe a quantidade de livros que deseja guardar: ");
    QtdLivros = int.Parse(Console.ReadLine());
    Livros = new Livro[QtdLivros];
}

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

void AdicionarLivros()
{
    for (int l = 0; l < QtdLivros; l++)
    {
        Livros[l] = CriarLivro(l);
    }
}

void MostrarLivros()
{
    for (int l = 0; l < QtdLivros; l++)
    {
        Console.WriteLine("\n--------------------------------------------------\n");
        Livros[l].ImprimirLivro();
        Console.WriteLine("\n--------------------------------------------------\n");
    }
}

//-----PROGRAMA-----
Menu();