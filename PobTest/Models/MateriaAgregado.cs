using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PobTest.Models
{
    public class MateriaAgregado
    {
        public string Codigo { get; set; }
        public string evaluacion { get; set; }
        public List<Materia> Materias { get; set; }
    }
}