using System.Net.Http.Json;
using GameStore.Client.Models;

namespace GameStore.Client.Services;

public class GamesService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "http://localhost:5108"; // Update this to match your API URL

    public GamesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<GameSummaryDto>> GetGamesAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<List<GameSummaryDto>>($"{BaseUrl}/games") ?? new List<GameSummaryDto>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting games: {ex.Message}");
            return new List<GameSummaryDto>();
        }
    }

    public async Task<GameDetailsDto?> GetGameAsync(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<GameDetailsDto>($"{BaseUrl}/games/{id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting game {id}: {ex.Message}");
            return null;
        }
    }

    public async Task<GameDetailsDto?> CreateGameAsync(CreateGameDto game)
    {
        try
        {
            // Convert class-based DTO to record for API call
            var apiGame = new Models.ApiCreateGameDto(game.Name, game.GenreId, game.Price, game.releaseDate);
            var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}/games", apiGame);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<GameDetailsDto>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating game: {ex.Message}");
            return null;
        }
    }

    public async Task<bool> UpdateGameAsync(int id, UpdateGameDto game)
    {
        try
        {
            // Convert class-based DTO to record for API call
            var apiGame = new Models.ApiUpdateGameDto(game.Name, game.GenreId, game.Price, game.releaseDate);
            var response = await _httpClient.PutAsJsonAsync($"{BaseUrl}/games/{id}", apiGame);
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating game {id}: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> DeleteGameAsync(int id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"{BaseUrl}/games/{id}");
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting game {id}: {ex.Message}");
            return false;
        }
    }

    public async Task<List<GenreDto>> GetGenresAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<List<GenreDto>>($"{BaseUrl}/genres") ?? new List<GenreDto>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting genres: {ex.Message}");
            return new List<GenreDto>();
        }
    }
}
