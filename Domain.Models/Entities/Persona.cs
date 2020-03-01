using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Persona
    {
        //Atributos
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Nac { get; set; }
        //Comportamientos / Reglas empresariales  
    }
}
