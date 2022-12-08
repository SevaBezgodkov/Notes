using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DbInitializer
    {
        public static void Initializer(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
