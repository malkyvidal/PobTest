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
    public partial class TestWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRepeater();
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var esd = e.Item.ItemType;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DropDownList combo = e.Item.FindControl("DropDownList1") as DropDownList;
                List<Materia> materias = (e.Item.DataItem as MateriaAgregado).Materias;
                materias.ForEach(i => combo.Items.Add(new ListItem { Value = i.IdMateria.ToString(), Text = i.Nombre }));
                combo.Items.Insert(0, new ListItem { Value = "0", Text = "Seleccione" });

            }
        }
        private void CargarRepeater()
        {
            MateriaAgregado ma = new MateriaAgregado()
            {
                Codigo = "",
                evaluacion = "",
                Materias = new List<Materia>() { new Materia { IdMateria = 1, Nombre = "Quimica" }, new Materia { IdMateria = 2, Nombre = "QuimicaII" } }
            };
            MateriaAgregado ma1 = new MateriaAgregado()
            {
                Codigo = "",
                evaluacion = "",
                Materias = new List<Materia>() { new Materia { IdMateria = 1, Nombre = "Quimica" }, new Materia { IdMateria = 2, Nombre = "QuimicaII" } }
            };

            List<int> ides = new List<int>();
            Session["ides"] = ides;

            List<MateriaAgregado> mas = new List<MateriaAgregado>();
            mas.Add(ma);
            mas.Add(ma1);
            Repeater1.DataSource = mas;
            Repeater1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList combo = sender as DropDownList;
            RepeaterItem item = combo.NamingContainer as RepeaterItem;

            Label LblMensaje = item.FindControl("LblMensaje") as Label;

            List<int> ides = (List<int>)Session["ides"];
            if (ides.Contains(int.Parse(combo.SelectedValue)))
            {
               
                LblMensaje.Visible = true;
                hdnMr.Value = "1";
                combo.CssClass = "err";
            }
            else
            {
                ides.Add(int.Parse(combo.SelectedValue));
                Session["ides"] = null;
                Session["ides"] = ides;

                TextBox txt1 = item.FindControl("TextBox1") as TextBox;
                TextBox txt2 = item.FindControl("TextBox2") as TextBox;
                txt1.Text = "Nuevo Dato";
                txt2.Text = "Otro Dato";
                txt1.Enabled = false;
                txt2.Enabled = false;
                LblMensaje.Visible = false;
                hdnMr.Value = "0";
                combo.CssClass = "";
            }
            
        }


    }
}