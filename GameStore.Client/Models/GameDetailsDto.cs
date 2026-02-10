namespace GameStore.Client.Models;

public record GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly releaseDate
);
