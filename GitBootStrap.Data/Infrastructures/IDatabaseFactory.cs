using GitBootStrap.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBootStrap.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Model1Container Get();
    }
}
