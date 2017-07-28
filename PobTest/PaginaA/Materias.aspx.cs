using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PobTest.Models;
using Newtonsoft.Json;
using System.Web.UI.HtmlControls;
namespace PobTest.PaginaA
{
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idCarrera;

            Boolean hayCarrera = int.TryParse(Request.QueryString["idCarrera"], out idCarrera);
            if (hayCarrera)
            {
                //obtener materias de la carrera
                List<Materia> materias;
                if (idCarrera==1)
                {
                    materias = new List<Materia>() {
                
                    new Materia(){IdMateria=1,Nombre="Materia1"},
                    new Materia(){IdMateria=2,Nombre="Materia2"},
                    new Materia(){IdMateria=3,Nombre="Materia3"},
                    new Materia(){IdMateria=4,Nombre="Materia4"},
                    new Materia(){IdMateria=5,Nombre="Materia5"},
                    new Materia(){IdMateria=6,Nombre="Materia6"},
                    };
                    materias.Insert(0, new Materia { IdMateria = 0, Nombre = "Seleccione" });
                }
                else
                {
                    materias = new List<Materia>() {
                
                    new Materia(){IdMateria=1,Nombre="OtraMateria1"},
                    new Materia(){IdMateria=2,Nombre="OtraMateria2"},
                    new Materia(){IdMateria=3,Nombre="OtraMateria3"},
                    new Materia(){IdMateria=4,Nombre="OtraMateria4"},
                    new Materia(){IdMateria=5,Nombre="OtraMateria5"},
                    new Materia(){IdMateria=6,Nombre="OtraMateria6"},
                    };
                    materias.Insert(0, new Materia { IdMateria = 0, Nombre = "Seleccione" });
                }
                 


                

                Response.ContentType="application/json";
                //List<ListItem> itemsMat = new List<ListItem>();
                //materias.ForEach(m => itemsMat.Add(new ListItem { Value = m.IdMateria.ToString(), Text = m.Nombre }));
                //itemsMat.Insert(0, new ListItem {Value="0",Text="Seleccione.." });
                Response.Write(JsonConvert.SerializeObject(materias));
                Response.End();
               
                
            }

        }
    }
}