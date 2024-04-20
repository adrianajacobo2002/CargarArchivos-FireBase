using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaLabMVC.Models;

public partial class Marca
{
    [Key]

    [Display(Name = "ID")]
    public int IdMarcas { get; set; }

    [Required(ErrorMessage ="El nombre de la marca no es opcional!")]
    [Display(Name = "Nombre de la Marca")]
    public string? NombreMarca { get; set; }

    [Display(Name = "Estados")]
    public string? Estados { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    
}
