using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PobTest.Models;
namespace PobTest.PaginaA
{
    public partial class CarreraCombo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idDep;
           Boolean convertido = int.TryParse(Request.QueryString["idDepe"], out idDep);

           if (convertido)
           {
               BindDatosCarreraACombo(idDep);
           }
           


        }
        private void BindDatosCarreraACombo(int idDepe)
        {
            RepositoryCarrera.getCarrerasByIdDep(idDepe)
                .ForEach(f => carreras.Items.Add(new ListItem { Value = f.IdCarrera.ToString(), Text = f.Nombre }));

            carreras.Items.Insert(0, new ListItem { Value = "0",Text="Seleccione.." });
        }
    }
}