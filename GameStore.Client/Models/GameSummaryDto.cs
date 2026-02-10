namespace GameStore.Client.Models;

public record GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly releaseDate
);
