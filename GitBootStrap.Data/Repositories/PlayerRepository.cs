using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GitBootStrap.Data.Infrastructure;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Data.Entity;
using GitBootStrap.Domain.Entities;

namespace GitBootStrap.Data.Repositories
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
    {
        public PlayerRepository(DatabaseFactory dbFactory) : base(dbFactory) { } 
        
    }
   
}
