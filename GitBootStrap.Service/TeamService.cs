using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitBootStrap.Domain.Entities;
using GitBootStrap.Data.Infrastructure;

namespace GitBootStrap.Service
{
    public interface ITeamService
    {
        void Add(Team team);
        List<Team> Get();
        void Save();
    }
    public class TeamService : ITeamService
    {
        static DatabaseFactory dbFactory=new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public TeamService()
        {
           
        }


        public void Save()
        {
            utOfWork.Commit();
        }

        public void Add(Team t)
        {
            utOfWork.TeamRepository.Add(t);
        }

        public List<Team> Get()
        {
            return utOfWork.TeamRepository.GetAll().ToList();
        }


   
    }
}
