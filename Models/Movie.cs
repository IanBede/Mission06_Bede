using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Bede.Models;

public partial class Movie
{
    [Key]
    public int MovieId { get; set; }

    public int? CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    public int Edited { get; set; }

    public string? LentTo { get; set; }

    public int CopiedToPlex { get; set; }

    public string? Notes { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Movies")]
    public virtual Category? Category { get; set; }
}
