using Parcial1Ap1_AnthonySP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_AnthonySP.BLL
{


    public class RepositorioBLL
    {
        public static bool Guardar(Empleados nuevo)
        {
            bool retorno = false;
            using (var db = new Repositorio<Empleados>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }

        public static bool Eliminar(Empleados Id)
        {
            bool resultado = false;
            using (var db = new Repositorio<Empleados>())
            {
                resultado = db.Eliminar(Id);

            }
            return resultado;
        }
    }
}
