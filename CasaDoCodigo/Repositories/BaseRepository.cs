using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly AplicationContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(AplicationContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
    }
}
