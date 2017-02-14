using Parcial1Ap1_AnthonySP.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_AnthonySP.DAL
{
    class Parcial1Aplicada1Db : DbContext

    {
        public Parcial1Aplicada1Db(): base ("ConStr")
        {

        }

        public DbSet<Empleados> empleado { get; set; }


    }
}
