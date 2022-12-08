using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
