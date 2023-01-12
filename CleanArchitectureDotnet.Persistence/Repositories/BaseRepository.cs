using CleanArchitectureDotnet.Application.Contracts.BaseConstracts;

namespace CleanArchitectureDotnet.Persistence.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public BaseDbContext _dbContext;

        public BaseRepository(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
