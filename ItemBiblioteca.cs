// ItemBiblioteca.cs
using System;

// Classe abstrata que representa um item na biblioteca
public abstract class ItemBiblioteca
{
    public int Id { get; set; } // Propriedade para o ID do item
    public string Titulo { get; set; } // Propriedade para o título do item
    protected string DescricaoInterna { get; set; } // Propriedade protegida para a descrição interna do item

    // Construtor que inicializa as propriedades básicas e a descrição interna padrão
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }
}