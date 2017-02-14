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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool retorno = false;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTextBox, "El Campo esta vacio");
                retorno = true;
            }

            if (string.IsNullOrWhiteSpace(sueldoTextBox.Text))
            {
                errorProviderSueldo.SetError(sueldoTextBox, "El campo esta vacio");
                retorno = true;
            }



            return retorno;
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
            else if (BLL.EmpleadoBLL.Guardar(guardar))
            {
                MessageBox.Show("La Empleado se guardo con exito.");
            }

            Limpiar();


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
          
            var buscar = BLL.EmpleadoBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));
            
            if (buscar != null)
            {
                nombreTextBox.Text = buscar.Nombre;
                sueldoTextBox.Text = buscar.Sueldo;
                fechaNacimientoDateTimePicker.Text = buscar.FechaNacimiento.ToString();
                MessageBox.Show("Este es el Empleado");
            }
            else
            {
                MessageBox.Show("No existe ningun Empleado con ese Id.");
            }
}

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var eliminar = BLL.EmpleadoBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));

            if (eliminar != null)
            {
                BLL.EmpleadoBLL.Eliminar(eliminar);
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
