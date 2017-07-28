using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PobTest.Models
{
    public class Carrera
    {
        public int IdDependencia { get; set; }
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
    }

    public class RepositoryCarrera
    {
        private static List<Carrera> carreras = new List<Carrera>() { 
        
            new Carrera(){IdCarrera=1,IdDependencia=1,Nombre="Historia De los Numeros"},
            new Carrera(){IdCarrera=2,IdDependencia=1,Nombre="Geometia"},
            new Carrera(){IdCarrera=3,IdDependencia=1,Nombre="Zootecnia"},
            new Carrera(){IdCarrera=4,IdDependencia=2,Nombre="CarreraN"},
            new Carrera(){IdCarrera=12,IdDependencia=2,Nombre="Matematicas"},
            new Carrera(){IdCarrera=5,IdDependencia=2,Nombre="Ciencias "},
            new Carrera(){IdCarrera=6,IdDependencia=3,Nombre="Historias"},
            new Carrera(){IdCarrera=7,IdDependencia=3,Nombre="Carrera22"},
            new Carrera(){IdCarrera=8,IdDependencia=3,Nombre="Fisica"},
            new Carrera(){IdCarrera=9,IdDependencia=4,Nombre="Computacion"},
            new Carrera(){IdCarrera=10,IdDependencia=4,Nombre="Ingenieria"},
            new Carrera(){IdCarrera=11,IdDependencia=4,Nombre="Odonoto"},
        
        
        };
        public static List<Carrera> getCarrerasByIdDep(int id)
        {
            return carreras.Where(d => d.IdDependencia == id).ToList();
        }
    }
}