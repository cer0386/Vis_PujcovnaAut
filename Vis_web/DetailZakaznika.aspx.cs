using DataLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vis_web
{
    public partial class DetailZakaznika : System.Web.UI.Page
    {
        DataMapper mapper = new DataMapper();

        List<Zakaznik> zakaznici = new List<Zakaznik>();
        protected void Page_Load(object sender, EventArgs e)
        {
            zakaznici = mapper.FindZak();
            List<Rezervace> rezervaces = new List<Rezervace>();

            vsichniZak.DataSource = zakaznici;
            vsichniZak.DataBind();


        }
    }
}