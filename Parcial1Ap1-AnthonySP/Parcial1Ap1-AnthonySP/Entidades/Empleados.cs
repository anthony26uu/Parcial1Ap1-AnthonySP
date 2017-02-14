using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_AnthonySP.Entidades
{
   public class Empleados 
         
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sueldo { get; set; }

        public Empleados()
        {

        }
    }
}
