using System.ComponentModel.DataAnnotations;

namespace API.Persistence.Entities;

public class NoteEntity
{
    [MaxLength(256)]
    public string Title { get; set; } = "";

    public Guid Id { get; set; } = Guid.NewGuid();
}