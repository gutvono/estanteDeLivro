int QtdLivros = 0, opcao = 0;
Livro[] Estante = new Livro[1];

void Menu()
{
    do
    {
        Console.WriteLine(
            "Insira o numero relacionado ao que você precisa:\n" +
            "1 - Criar estante de livros;\n" +
            "2 - Adicionar livros na estante;\n" +
            "3 - Mostrar livros da estante;\n" +
            "4 - Imprimir um livro específico;\n" +
            "5 - Sair do sistema."
            );
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
            case 4:
                Console.Write("Informe o índice do livro");
                BuscarLivro(int.Parse(Console.ReadLine()) - 1);
                break;
            case 5:
                break;
            default:
                Console.WriteLine("ERRO: Insira um número válido.");
                break;
        }
    } while (opcao != 5);
}

void CriarEstante()
{
    do
    {
        if (QtdLivros > 10) Console.WriteLine("Nossa estante só terá espaço para até 10 livros. Favor inserir um valor menor que 10!");
        
        Console.Write("Informe a quantidade de livros que deseja guardar: ");
        QtdLivros = int.Parse(Console.ReadLine());
        Estante = new Livro[QtdLivros];
    } while (QtdLivros > 10);
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
    livro.ISBN = Console.ReadLine();

    Console.Write("\nInforme a quantidade de paginas: ");
    livro.QtdPaginas = int.Parse(Console.ReadLine());

    return livro;
}

void AdicionarLivros()
{
    for (int l = 0; l < QtdLivros; l++)
    {
        Estante[l] = CriarLivro(l);
    }
}

void MostrarLivros()
{
    for (int l = 0; l < QtdLivros; l++)
    {
        Console.WriteLine("\n--------------------------------------------------\n");
        Estante[l].ImprimirLivro();
        Console.WriteLine("\n--------------------------------------------------\n");
    }
}

void BuscarLivro(int i)
{
    Estante[i].ImprimirLivro();
    Console.WriteLine
    (
        "Deseja editar este livro?\n" +
        "1 - SIM\n" +
        "2 - NÃO"
    );
    int editar = int.Parse(Console.ReadLine());

    if (editar == 1) Estante[i] = EditarLivro(Estante[i]);
}

Livro EditarLivro(Livro livro)
{
    Livro l = livro;
    Console.WriteLine("\nQual índice deseja editar?");
    int i = int.Parse(Console.ReadLine()); 
    
    switch (i)
    {
        case 1:
            l.Titulo = Console.ReadLine();
            break;
        case 2:
            l.Autor = Console.ReadLine();
            break;
        case 3:
            l.DataLancamento = DateOnly.Parse(Console.ReadLine());
            break;
        case 4:
            l.Editora = Console.ReadLine();
            break;
        case 5:
            l.Edicao = Console.ReadLine();
            break;
        case 6:
            l.ISBN = Console.ReadLine();
            break;
        case 7:
            l.QtdPaginas = int.Parse(Console.ReadLine());
            break;
        default:
            Console.WriteLine("ERRO: Insira um índice válido.");
            break;
    }

    return l;
}

//-----PROGRAMA-----//
Menu();