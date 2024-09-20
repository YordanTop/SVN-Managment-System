﻿using DataBaseLayer.DataBaseContext;
using DataBaseLayer.Models;
using ServiceLayer.Repositories.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repositories
{
    public class PctolineRepository : Repository<Pctoline>
    {
        public PctolineRepository(SvnStatusInfoContext dbContext) : base(dbContext)
        {
        }


    }
}
