using System.Text.Json;
using UI.Services.Contracts;

namespace UI.Services.Notes;

public class NotesService : INotesService
{
    public const string serviceUrl = "https://localhost:7017/Notes";

    public async Task<IEnumerable<Note>> GetNotes()
    {
        using var apiClient = new HttpClient();
        var response =  await apiClient.GetAsync(serviceUrl);

        if (response.IsSuccessStatusCode is false)
        {
            return Array.Empty<Note>();
        }

        var jsonResponse = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<Note[]>(jsonResponse, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? Array.Empty<Note>();
    }
}