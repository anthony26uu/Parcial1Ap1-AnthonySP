using Parcial1Ap1_AnthonySP.DAL;
using Parcial1Ap1_AnthonySP.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_AnthonySP.BLL
{
    public class EmpleadoBLL
    {

        public static bool Guardar(Empleados empleado)
        {
            using (var conec = new Parcial1Aplicada1Db())
            {
                try
                {
                    if (Buscar(empleado.EmpleadoId) == null)
                    {
                        conec.empleado.Add(empleado);
                        conec.SaveChanges();
                        return true;
                    }
                    else
                    {
                        conec.Entry(empleado).State = EntityState.Modified;
                        conec.SaveChanges();
                        return true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }




        public static bool Eliminar(Empleados n)
        {
            bool interruptor = false;

            using (var conec = new Parcial1Aplicada1Db())
            {
                try
                {
                    conec.Entry(n).State = EntityState.Deleted;
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }

        public static Empleados Buscar(int EmpleadoId)
        {
            var buscar = new Empleados();

            using (var conec = new Parcial1Aplicada1Db())
            {
                try
                {
                    buscar = conec.empleado.Find(EmpleadoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return buscar;
        }





        public static List<Empleados> GetList(DateTime Nacimiento)
        {
            var list = new List<Empleados>();

            using (var conec = new Parcial1Aplicada1Db())
            {
                try
                {
                    list = conec.empleado.Where(p => p.FechaNacimiento == Nacimiento).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return list;
        }


        public static List<Empleados> GetList()
        {
            using (var conec = new Parcial1Aplicada1Db())
            {
                try
                {
                    return conec.empleado.ToList();
                }
                catch (Exception)
                {
                    return new List<Empleados>();
                    throw;
                }
            }

        }


    }
}
