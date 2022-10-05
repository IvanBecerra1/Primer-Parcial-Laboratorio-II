namespace WinFormulario.Controlador
{
    partial class frmRegistrarCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorDatosPersonales = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorDatosPasaporte = new System.Windows.Forms.Label();
            this.fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaValida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIndentificador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErrorDatosEquipaje = new System.Windows.Forms.Label();
            this.lblValija2 = new System.Windows.Forms.Label();
            this.textBoxValija2 = new System.Windows.Forms.TextBox();
            this.checkBoxBolsoMano = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxValija1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCostoPasaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxCamarotesPremiunDisponibles = new System.Windows.Forms.TextBox();
            this.textBoxCamarotesTuristaDisponibles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar pasajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(38, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(38, 93);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 23);
            this.textBoxApellido.TabIndex = 5;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(38, 137);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 23);
            this.textBoxEdad.TabIndex = 7;
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(38, 186);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(100, 23);
            this.textBoxDocumento.TabIndex = 9;
            this.textBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDocumento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNacionalidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblErrorDatosPersonales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxEdad);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 297);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(38, 240);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(100, 23);
            this.textBoxNacionalidad.TabIndex = 12;
            this.textBoxNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nacionalidad";
            // 
            // lblErrorDatosPersonales
            // 
            this.lblErrorDatosPersonales.AutoSize = true;
            this.lblErrorDatosPersonales.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosPersonales.Location = new System.Drawing.Point(6, 279);
            this.lblErrorDatosPersonales.Name = "lblErrorDatosPersonales";
            this.lblErrorDatosPersonales.Size = new System.Drawing.Size(44, 15);
            this.lblErrorDatosPersonales.TabIndex = 10;
            this.lblErrorDatosPersonales.Text = "label13";
            this.lblErrorDatosPersonales.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblErrorDatosPasaporte);
            this.groupBox2.Controls.Add(this.fechaVencimiento);
            this.groupBox2.Controls.Add(this.fechaValida);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxIndentificador);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(234, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 297);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasaporte";
            // 
            // lblErrorDatosPasaporte
            // 
            this.lblErrorDatosPasaporte.AutoSize = true;
            this.lblErrorDatosPasaporte.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosPasaporte.Location = new System.Drawing.Point(6, 279);
            this.lblErrorDatosPasaporte.Name = "lblErrorDatosPasaporte";
            this.lblErrorDatosPasaporte.Size = new System.Drawing.Size(38, 15);
            this.lblErrorDatosPasaporte.TabIndex = 9;
            this.lblErrorDatosPasaporte.Text = "label7";
            this.lblErrorDatosPasaporte.Visible = false;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.Location = new System.Drawing.Point(6, 163);
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Size = new System.Drawing.Size(149, 23);
            this.fechaVencimiento.TabIndex = 8;
            // 
            // fechaValida
            // 
            this.fechaValida.Location = new System.Drawing.Point(6, 107);
            this.fechaValida.Name = "fechaValida";
            this.fechaValida.Size = new System.Drawing.Size(149, 23);
            this.fechaValida.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Indentificador";
            // 
            // textBoxIndentificador
            // 
            this.textBoxIndentificador.Location = new System.Drawing.Point(6, 37);
            this.textBoxIndentificador.Name = "textBoxIndentificador";
            this.textBoxIndentificador.Size = new System.Drawing.Size(100, 23);
            this.textBoxIndentificador.TabIndex = 3;
            this.textBoxIndentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblErrorDatosEquipaje);
            this.groupBox3.Controls.Add(this.lblValija2);
            this.groupBox3.Controls.Add(this.textBoxValija2);
            this.groupBox3.Controls.Add(this.checkBoxBolsoMano);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxValija1);
            this.groupBox3.Location = new System.Drawing.Point(434, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 297);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipaje";
            // 
            // lblErrorDatosEquipaje
            // 
            this.lblErrorDatosEquipaje.AutoSize = true;
            this.lblErrorDatosEquipaje.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosEquipaje.Location = new System.Drawing.Point(0, 279);
            this.lblErrorDatosEquipaje.Name = "lblErrorDatosEquipaje";
            this.lblErrorDatosEquipaje.Size = new System.Drawing.Size(44, 15);
            this.lblErrorDatosEquipaje.TabIndex = 16;
            this.lblErrorDatosEquipaje.Text = "label14";
            this.lblErrorDatosEquipaje.Visible = false;
            // 
            // lblValija2
            // 
            this.lblValija2.AutoSize = true;
            this.lblValija2.Location = new System.Drawing.Point(24, 147);
            this.lblValija2.Name = "lblValija2";
            this.lblValija2.Size = new System.Drawing.Size(115, 15);
            this.lblValija2.TabIndex = 14;
            this.lblValija2.Text = "Peso valija #2 (25KG)";
            // 
            // textBoxValija2
            // 
            this.textBoxValija2.Location = new System.Drawing.Point(24, 165);
            this.textBoxValija2.Name = "textBoxValija2";
            this.textBoxValija2.Size = new System.Drawing.Size(100, 23);
            this.textBoxValija2.TabIndex = 15;
            this.textBoxValija2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // checkBoxBolsoMano
            // 
            this.checkBoxBolsoMano.AutoSize = true;
            this.checkBoxBolsoMano.Location = new System.Drawing.Point(24, 39);
            this.checkBoxBolsoMano.Name = "checkBoxBolsoMano";
            this.checkBoxBolsoMano.Size = new System.Drawing.Size(105, 19);
            this.checkBoxBolsoMano.TabIndex = 13;
            this.checkBoxBolsoMano.Text = "Bolso de mano";
            this.checkBoxBolsoMano.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Peso valija #1 (25KG)";
            // 
            // textBoxValija1
            // 
            this.textBoxValija1.Location = new System.Drawing.Point(24, 109);
            this.textBoxValija1.Name = "textBoxValija1";
            this.textBoxValija1.Size = new System.Drawing.Size(100, 23);
            this.textBoxValija1.TabIndex = 3;
            this.textBoxValija1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pasaje turista";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 19);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pasaje premiun";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCostoPasaje);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(32, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 163);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costo del pasaje";
            // 
            // textBoxCostoPasaje
            // 
            this.textBoxCostoPasaje.Enabled = false;
            this.textBoxCostoPasaje.Location = new System.Drawing.Point(25, 99);
            this.textBoxCostoPasaje.Name = "textBoxCostoPasaje";
            this.textBoxCostoPasaje.Size = new System.Drawing.Size(112, 23);
            this.textBoxCostoPasaje.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Costo del pasaje";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxCamarotesPremiunDisponibles);
            this.groupBox5.Controls.Add(this.textBoxCamarotesTuristaDisponibles);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(234, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 163);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion del viaje";
            // 
            // textBoxCamarotesPremiunDisponibles
            // 
            this.textBoxCamarotesPremiunDisponibles.Enabled = false;
            this.textBoxCamarotesPremiunDisponibles.Location = new System.Drawing.Point(19, 99);
            this.textBoxCamarotesPremiunDisponibles.Name = "textBoxCamarotesPremiunDisponibles";
            this.textBoxCamarotesPremiunDisponibles.Size = new System.Drawing.Size(100, 23);
            this.textBoxCamarotesPremiunDisponibles.TabIndex = 3;
            // 
            // textBoxCamarotesTuristaDisponibles
            // 
            this.textBoxCamarotesTuristaDisponibles.Enabled = false;
            this.textBoxCamarotesTuristaDisponibles.Location = new System.Drawing.Point(18, 44);
            this.textBoxCamarotesTuristaDisponibles.Name = "textBoxCamarotesTuristaDisponibles";
            this.textBoxCamarotesTuristaDisponibles.Size = new System.Drawing.Size(100, 23);
            this.textBoxCamarotesTuristaDisponibles.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Camarotes disponibles premiun";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Camarotes disponibles turista";
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 563);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarCliente";
            this.Load += new System.EventHandler(this.frmRegistrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIndentificador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxValija1;
        private System.Windows.Forms.Label lblValija2;
        private System.Windows.Forms.TextBox textBoxValija2;
        private System.Windows.Forms.CheckBox checkBoxBolsoMano;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCostoPasaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxCamarotesPremiunDisponibles;
        private System.Windows.Forms.TextBox textBoxCamarotesTuristaDisponibles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker fechaVencimiento;
        private System.Windows.Forms.DateTimePicker fechaValida;
        private System.Windows.Forms.Label lblErrorDatosPersonales;
        private System.Windows.Forms.Label lblErrorDatosPasaporte;
        private System.Windows.Forms.Label lblErrorDatosEquipaje;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.Label label7;
    }
}