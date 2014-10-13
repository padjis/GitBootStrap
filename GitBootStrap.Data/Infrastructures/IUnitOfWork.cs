using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBootStrap.Data.Repositories;

namespace GitBootStrap.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit(); 
        ITeamRepository TeamRepository { get; }
        IPlayerRepository PlayerRepository { get; } 
    }
}
