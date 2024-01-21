using UI.Services.Contracts;

namespace UI.Services.Notes;

public interface INotesService
{
    Task<IEnumerable<Note>> GetNotes();
}