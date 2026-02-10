using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models;

public class UpdateGameDto
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    public int GenreId { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }

    public DateOnly releaseDate { get; set; }
}
