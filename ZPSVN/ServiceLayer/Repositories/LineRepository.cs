using DataBaseLayer.DataBaseContext;
using DataBaseLayer.Models;

namespace ServiceLayer.Repositories
{
    public class LineRepository : Repository<Line>
    {
        public LineRepository(SvnStatusInfoContext dbContext) : base(dbContext)
        {
        }
    }
}
