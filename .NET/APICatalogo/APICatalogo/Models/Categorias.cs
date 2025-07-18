﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;
public class Categorias
{

    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }


    public ICollection<Produtos>? Produtos { get; set; }

    public Categorias()
    {
        Produtos = new Collection<Produtos>();
    }
}
