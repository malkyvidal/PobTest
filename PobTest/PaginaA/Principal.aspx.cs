using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PobTest.Models;
using System.Web.UI.HtmlControls;
namespace PobTest.PaginaA
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombo();
                
            }
        }
        private void CargarCombo()
        {
            List<Dependencia> deps = new List<Dependencia>() { 
                new Dependencia{Id=1,Descripcion="Rectorado"},
                new Dependencia{Id=2,Descripcion="Economicas"},
                new Dependencia{Id=3,Descripcion="Exactas"},
                new Dependencia{Id=4,Descripcion="Derecho"},
            
            };
            deps.ForEach(d => ddlDep.Items.Add(new ListItem { Value = d.Id.ToString(), Text = d.Descripcion }));
            ddlDep.Items.Insert(0, new ListItem { Value = "0", Text = "Seleccione" });

        }

        public string GetCarreraComboUrl()
        {
            return "CarreraCombo.aspx?idDepe=";
        }
    }
}