using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Bede.Models;

public partial class Movie
{
    [Key]
    public int MovieId { get; set; }

    public int? CategoryId { get; set; }

    [Required]
    public string Title { get; set; } = null!;

    [Required]
    [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    [Required]
    public int Edited { get; set; }

    public string? LentTo { get; set; }

    [Required]
    public int CopiedToPlex { get; set; }

    [StringLength(25)]
    public string? Notes { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Category? Category { get; set; }
}
