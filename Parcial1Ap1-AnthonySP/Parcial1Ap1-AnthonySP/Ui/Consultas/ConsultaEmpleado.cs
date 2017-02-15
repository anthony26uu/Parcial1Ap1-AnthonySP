using Parcial1Ap1_AnthonySP.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_AnthonySP.Ui.Consultas
{
    public partial class ConsultaEmpleado : Form
    {
        public ConsultaEmpleado()
        {
            InitializeComponent();
        }



        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {
            Llenar();
        }



        public void Llenar()
        {
            //  comboBox1.Items.Insert(3, "Nombre1");
            comboBox1.Items.Insert(0, "NOMBRE");
            comboBox1.Items.Insert(1, "FECHA");
            comboBox1.Items.Insert(2, "TODO");

            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Nombre";


        }

        public void Selecionar()
        {
            using (var db = new BLL.Repositorio<Empleados>())
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridViewNombre.DataSource = db.GetListNombre(p => p.Nombre == buscaText.Text);
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    if (desdeDateTimePicker.Value.Date <= HastadateTimePicker1.Value.Date)
                    {
                        dataGridViewNombre.DataSource = db.GetListFecha(p => p.FechaNacimiento >= desdeDateTimePicker.Value.Date && p.FechaNacimiento <= HastadateTimePicker1.Value.Date);
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    dataGridViewNombre.DataSource = db.GetList();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void buscaText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
