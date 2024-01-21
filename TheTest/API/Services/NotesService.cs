using API.Contracts;
using API.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class NotesService : INotesService
{
    public async Task<IEnumerable<NoteListItem>> GetAllNotes()
    {
        await using var db = new DatabaseContext();

        var notes = await db.Notes.OrderBy(b => b.Title).ToListAsync();

        return notes.Select(n => new NoteListItem(n.Id, n.Title));
    }
}