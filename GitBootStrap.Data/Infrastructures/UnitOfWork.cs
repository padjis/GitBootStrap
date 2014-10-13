using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBootStrap.Data.Repositories;

namespace GitBootStrap.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private Model1Container dataContext; DatabaseFactory dbFactory;

        public UnitOfWork(DatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        private ITeamRepository teamRepository;
        ITeamRepository IUnitOfWork.TeamRepository
        {
            get
            {
                return teamRepository ?? (teamRepository = new TeamRepository(dbFactory)); 
            } 
        }

        private IPlayerRepository playerRepository;
        IPlayerRepository IUnitOfWork.PlayerRepository
        {
            get
            {
                return playerRepository ?? (playerRepository = new PlayerRepository(dbFactory));
            }
        }
        
        protected Model1Container DataContext { 
            get { return dataContext ?? (dataContext = dbFactory.Get()); 
            } 
        } 
        
        public void Commit() { 
            DataContext.Commit(); 
        }
    }
}
