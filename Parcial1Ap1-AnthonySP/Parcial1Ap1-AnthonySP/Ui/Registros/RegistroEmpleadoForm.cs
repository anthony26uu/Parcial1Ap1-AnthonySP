using Parcial1Ap1_AnthonySP.DAL;
using Parcial1Ap1_AnthonySP.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_AnthonySP.Ui.Registros
{
    public partial class RegistroEmpleadoForm : Form
    {
        public RegistroEmpleadoForm()
        {
            InitializeComponent();
        }

        private void RegistroEmpleadoForm_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            empleadoIdTextBox.Clear();
            nombreTextBox.Clear();
            sueldoTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTextBox, "El Campo esta vacio");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(sueldoTextBox.Text))
            {
                errorProviderSueldo.SetError(sueldoTextBox, "El campo esta vacio");
                retorno = false;
            }
            return retorno;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            var guardar = new Empleados();
            guardar.Nombre = nombreTextBox.Text;
            guardar.Sueldo = sueldoTextBox.Text;
            guardar.FechaNacimiento = fechaNacimientoDateTimePicker.Value.Date;

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos");
            }
            else if (BLL.RepositorioBLL.Guardar(guardar))
            {
                MessageBox.Show("La Empleado se guardo con exito.");
            }

            Limpiar();


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empleadoIdTextBox.Text);
            Empleados empleado;
            using (var db = new BLL.Repositorio<Empleados>())
            {
                empleado = db.Buscar(p => p.EmpleadoId == id);

                if (empleado != null)
                {
                    nombreTextBox.Text = empleado.Nombre;
                    sueldoTextBox.Text = empleado.Sueldo;
                    fechaNacimientoDateTimePicker.Text = empleado.FechaNacimiento.ToString();
                    MessageBox.Show("Este es el Empleado");
                }
                else
                {
                    MessageBox.Show("No existe ningun Empleado con ese Id.");
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //   var eliminar = BLL..Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));
            int id = int.Parse(empleadoIdTextBox.Text);
            using (var db = new BLL.Repositorio<Empleados>())
            {
                if (db.Eliminar(db.Buscar(p => p.EmpleadoId == id)))
                {

                    MessageBox.Show("Empleado eliminado con exito.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar  Empleado.");
                }
            }

        }
    }
}
