using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models;

public record ApiCreateGameDto(
    [Required][StringLength(50)] string Name,
    int GenreId,
    [Range(1, 100)] decimal Price,
    DateOnly releaseDate
);
