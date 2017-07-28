using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PobTest.PaginaA
{
    public partial class TablaDos : System.Web.UI.Page
    {
        const int TotalFilas = 6;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<string> CrearFilas()
        {
            List<string> filas = new List<string>();
            foreach (var item in Enumerable.Range(1, TotalFilas))
            {
                filas.Add(@"
                     <tr> <td><input type='text' />  </td><td><input type='text' /></td><td><input type='text' /> </td></tr>
                ");
            }
            return filas;
        }
        
    }
}