using DataBaseLayer.DataBaseContext;
using DataBaseLayer.Models;

namespace ServiceLayer.Repositories
{
    public class PctolineRepository : Repository<Pctoline>
    {
        public PctolineRepository(SvnStatusInfoContext dbContext) : base(dbContext)
        {
        }


    }
}
