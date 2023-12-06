// Program.cs
using System;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        // Loop principal para interação com o usuário
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Buscar Livro por Título");
            Console.WriteLine("3. Remover Livro");
            Console.WriteLine("4. Exibir Livros na Biblioteca");
            Console.WriteLine("5. Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Adicionar Livro
                    Console.Write("Digite o ID do livro: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();

                    Livro novoLivro = new Livro(id, titulo, autor);
                    biblioteca.AdicionarItem(novoLivro);
                    break;

                case 2:
                    // Buscar Livro por Título
                    Console.Write("Digite o título do livro a ser buscado: ");
                    string tituloBusca = Console.ReadLine();
                    Livro livroEncontrado = biblioteca.BuscarItemPorTitulo(tituloBusca);
                    if (livroEncontrado != null)
                    {
                        livroEncontrado.ExibirDescricaoInterna();
                    }
                    else
                    {
                        Console.WriteLine($"Livro com título '{tituloBusca}' não encontrado.");
                    }
                    break;

                case 3:
                    // Remover Livro
                    Console.Write("Digite o título do livro a ser removido: ");
                    string tituloRemover = Console.ReadLine();
                    Livro livroRemover = biblioteca.BuscarItemPorTitulo(tituloRemover);
                    if (livroRemover != null)
                    {
                        biblioteca.RemoverItem(livroRemover);
                    }
                    else
                    {
                        Console.WriteLine($"Livro com título '{tituloRemover}' não encontrado.");
                    }
                    break;

                case 4:
                    // Exibir Livros na Biblioteca
                    biblioteca.ExibirLivros();
                    break;

                case 5:
                    // Sair do programa
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}