﻿using Parcial1Ap1_AnthonySP.Ui.Consultas;
using Parcial1Ap1_AnthonySP.Ui.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_AnthonySP
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleadoForm db = new RegistroEmpleadoForm();
            db.Show();
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEmpleado db = new ConsultaEmpleado();
            db.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
