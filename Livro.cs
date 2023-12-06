// Livro.cs
using System;

// Classe derivada de ItemBiblioteca, representando um livro
public class Livro : ItemBiblioteca
{
    public string Autor { get; set; } // Propriedade adicional para o autor do livro

    // Construtor que chama o construtor da classe base e inicializa a propriedade adicional
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

    // Método para exibir a descrição interna do livro
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Livro - Autor: {Autor}, Descrição Interna: {DescricaoInterna}");
    }
}
