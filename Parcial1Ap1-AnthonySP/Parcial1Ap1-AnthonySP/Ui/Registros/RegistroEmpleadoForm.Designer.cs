namespace Parcial1Ap1_AnthonySP.Ui.Registros
{
    partial class RegistroEmpleadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.empleadoIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSueldo = new System.Windows.Forms.ErrorProvider(this.components);
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(27, 101);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 1;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // empleadoIdTextBox
            // 
            this.empleadoIdTextBox.Location = new System.Drawing.Point(129, 98);
            this.empleadoIdTextBox.Name = "empleadoIdTextBox";
            this.empleadoIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.empleadoIdTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 127);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(129, 124);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(27, 154);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(129, 150);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(27, 179);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 7;
            sueldoLabel.Text = "Sueldo:";
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.Location = new System.Drawing.Point(129, 176);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoTextBox.TabIndex = 8;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(67, 231);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 9;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(282, 231);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(176, 231);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(254, 91);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderSueldo
            // 
            this.errorProviderSueldo.ContainerControl = this;
            // 
            // RegistroEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 357);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Name = "RegistroEmpleadoForm";
            this.Text = "RegistroEmpleadoForm";
            this.Load += new System.EventHandler(this.RegistroEmpleadoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox empleadoIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderSueldo;
    }
}