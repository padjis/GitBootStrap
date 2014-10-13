﻿using GitBootStrap.Data.Infrastructure;
using GitBootStrap.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBootStrap.Data.Repositories
{
    public interface IPlayerRepository : IRepository<Player>
    { 
    }
}
