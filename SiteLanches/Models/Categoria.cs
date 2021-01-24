﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteLanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Display(Name = "Nome")]
        [Required]
        [StringLength(100)]
        public string CategoriaNome { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        public virtual List<Lanche> Lanches { get; set; }
    }
}