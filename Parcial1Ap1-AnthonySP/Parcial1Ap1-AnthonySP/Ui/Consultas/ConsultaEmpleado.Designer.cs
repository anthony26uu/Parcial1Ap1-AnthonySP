﻿namespace Parcial1Ap1_AnthonySP.Ui.Consultas
{
    partial class ConsultaEmpleado
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
            this.dataGridViewNombre = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNombre
            // 
            this.dataGridViewNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNombre.Location = new System.Drawing.Point(7, 157);
            this.dataGridViewNombre.Name = "dataGridViewNombre";
            this.dataGridViewNombre.Size = new System.Drawing.Size(399, 150);
            this.dataGridViewNombre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "SELECIONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "DESDE";
            // 
            // buscaText
            // 
            this.buscaText.Location = new System.Drawing.Point(257, 33);
            this.buscaText.Name = "buscaText";
            this.buscaText.Size = new System.Drawing.Size(105, 20);
            this.buscaText.TabIndex = 22;
            this.buscaText.TextChanged += new System.EventHandler(this.buscaText_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // HastadateTimePicker1
            // 
            this.HastadateTimePicker1.CustomFormat = "yyy/MM/dd";
            this.HastadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker1.Location = new System.Drawing.Point(244, 81);
            this.HastadateTimePicker1.Name = "HastadateTimePicker1";
            this.HastadateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.HastadateTimePicker1.TabIndex = 19;
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.CustomFormat = "yyy/MM/dd";
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(57, 81);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.desdeDateTimePicker.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CONSULTA EMPLEADOS";
            // 
            // ConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.HastadateTimePicker1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.dataGridViewNombre);
            this.Name = "ConsultaEmpleado";
            this.Text = "CONSULTA EMPLEADOS";
            this.Load += new System.EventHandler(this.ConsultaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscaText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}