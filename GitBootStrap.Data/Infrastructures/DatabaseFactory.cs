using GitBootStrap.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBootStrap.Data.Infrastructure
{
    public class DatabaseFactory : Disposable,IDatabaseFactory
    {
        private Model1Container dataContext = null; 

        public Model1Container Get() { return dataContext ?? (dataContext = new Model1Container()); } 
        
        protected override void DisposeCore() { if (dataContext != null) dataContext.Dispose(); }
    }
}
