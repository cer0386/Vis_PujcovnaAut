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

        List<Zakaznik> zakaznici;
        Zakaznik zakaznik;
        List<Rezervace> rezervace;
        Faktura faktura;
        Platba platba;
        List<Auto> auta;
        int cisloR;
        string jm, pr, ri;

        protected void Page_Load(object sender, EventArgs e)
        {
            rezervace = new List<Rezervace>();
            zakaznici = new List<Zakaznik>();
            zakaznik = new Zakaznik();
            faktura = new Faktura();
            platba = new Platba();
            auta = new List<Auto>();

            zakaznici = mapper.FindZak();
            vsichniZak.DataSource = zakaznici;
            vsichniZak.DataBind();


        }

        protected void vsichniZak_SelectedIndexChanged(object sender, EventArgs e)
        {
            zakaznik.ID = Int32.Parse(vsichniZak.SelectedRow.Cells[1].Text);
            zakaznik.Jmeno = vsichniZak.SelectedRow.Cells[2].Text;
            zakaznik.Prijmeni = vsichniZak.SelectedRow.Cells[3].Text;
            zakaznik.Mesto = vsichniZak.SelectedRow.Cells[4].Text;
            zakaznik.Ulice = vsichniZak.SelectedRow.Cells[5].Text;
            zakaznik.CisloPopisne = Int32.Parse(vsichniZak.SelectedRow.Cells[6].Text);
            zakaznik.PSC = Int32.Parse(vsichniZak.SelectedRow.Cells[7].Text);
            zakaznik.Email = vsichniZak.SelectedRow.Cells[8].Text;
            zakaznik.cisloRidicskehoPrukazu = vsichniZak.SelectedRow.Cells[9].Text;

            rezervace = mapper.FindRezZ(zakaznik.ID);
            rezervaceZak.DataSource = rezervace;
            rezervaceZak.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu/Index");
        }

        protected void rezervaceZak_SelectedIndexChanged(object sender, EventArgs e)
        {
            cisloR = Int32.Parse(rezervaceZak.SelectedRow.Cells[1].Text);
            faktura = mapper.FindFak(cisloR);
            platba = mapper.FindPlat(cisloR);
            auta = mapper.FindAutaOnRez(cisloR);
            DateTime nope = new DateTime(0001, 01, 01, 0, 0, 0);
            string f = "Číslo faktury " + faktura.cisloFaktury + " Vytvořeno " + faktura.vytvorena + " Potvrzeno " + faktura.potvrzena + " Zaplaceno ";
            if (faktura.zaplacena == nope)
            {
                f += "ne";   
            }
            else
            {
                f +=  faktura.zaplacena;
            }
            

            
            string p = "Rezervace nebyla zaplacena";
            if (platba != null)
            {
                p = "Číslo platby " + platba.id_platby + " Typ platby " + platba.typ_platby + " Částka " + platba.castka; 
            }

            fak.Text = f;
            plat.Text = p;
            autaRez.DataSource = auta;
            autaRez.DataBind();
        }

        protected void hledat_Click(object sender, EventArgs e)
        {
            jm = jmeno.Text;
            pr = prijmeni.Text;
            ri = ridicak.Text;

            
            if (jm == "" && pr == "" && ri == "")
            {
                zakaznici = mapper.FindZak();
            }
            else if((jm == "" && pr == "" && ri != "")|| (jm != "" && pr != "" && ri != ""))
            {
                zakaznici.Clear();
                zakaznici.Add(mapper.FindZak(ri));
            }
            else if (jm != "" && pr != "" && ri == "")
            {
                zakaznici.Clear();
                zakaznici = mapper.FindZak(jm, pr);
            }

            vsichniZak.DataSource = zakaznici;
            vsichniZak.DataBind();
        }
    }
}