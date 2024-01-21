using API.Contracts;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Notes")]
    public class Notes(INotesService notesService) : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<NoteListItem>> Get()
        {
            return await notesService.GetAllNotes();
        }
    }
}
