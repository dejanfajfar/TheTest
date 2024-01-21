using API.Contracts;

namespace API.Services;

public interface INotesService
{
    Task<IEnumerable<NoteListItem>> GetAllNotes();
}