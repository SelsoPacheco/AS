// Biblioteca.cs
using System;
using System.Collections.Generic;

// Classe que gerencia uma coleção de itens biblioteca (Livros)
public class Biblioteca
{
    private List<Livro> livros; // Lista para armazenar os livros

    // Construtor que inicializa a lista de livros
    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    // Método para adicionar um livro à biblioteca
    public void AdicionarItem(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
    }

    // Método para buscar um livro pelo título
    public Livro BuscarItemPorTitulo(string titulo)
    {
        return livros.Find(livro => livro.Titulo == titulo);
    }

    // Método para buscar um livro pelo ID
    public Livro BuscarItemPorId(int id)
    {
        return livros.Find(livro => livro.Id == id);
    }

    // Método para remover um livro da biblioteca
    public void RemoverItem(Livro livro)
    {
        livros.Remove(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca.");
    }

    // Método para exibir todos os livros na biblioteca
    public void ExibirLivros()
    {
        Console.WriteLine("Livros na Biblioteca:");
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Id}: {livro.Titulo} - Autor: {livro.Autor}");
        }
    }
}