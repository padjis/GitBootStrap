using GitBootStrap.Domain.Entities;
using GitBootStrap.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitBootStrap
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Team> detailsList()
        {
            TeamService ts = new TeamService();
            var query = ts.Get().AsQueryable();
            return query;
        }
    }
}