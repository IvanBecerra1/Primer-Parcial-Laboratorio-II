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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblErrorDatosPersonales = new System.Windows.Forms.Label();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblErrorDatosPasaporte = new System.Windows.Forms.Label();
            this.textBoxIndentificador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaValida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblErrorDatosEquipaje = new System.Windows.Forms.Label();
            this.checkBoxBolsoMano = new System.Windows.Forms.CheckBox();
            this.textBoxValija1 = new System.Windows.Forms.TextBox();
            this.lblValija2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxValija2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCostoPasaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCamarotesPremiunDisponibles = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCamarotesTuristaDisponibles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar pasajero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(209, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNombre.Location = new System.Drawing.Point(100, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(91, 23);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxApellido.Location = new System.Drawing.Point(100, 55);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(91, 23);
            this.textBoxApellido.TabIndex = 5;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEdad.Location = new System.Drawing.Point(100, 107);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(91, 23);
            this.textBoxEdad.TabIndex = 7;
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDocumento.Location = new System.Drawing.Point(100, 159);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(91, 23);
            this.textBoxDocumento.TabIndex = 9;
            this.textBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDocumento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 338);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblErrorDatosPersonales, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.textBoxNombre, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxNacionalidad, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxApellido, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDocumento, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxEdad, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 316);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblErrorDatosPersonales
            // 
            this.lblErrorDatosPersonales.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.lblErrorDatosPersonales, 2);
            this.lblErrorDatosPersonales.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosPersonales.Location = new System.Drawing.Point(3, 260);
            this.lblErrorDatosPersonales.Name = "lblErrorDatosPersonales";
            this.lblErrorDatosPersonales.Size = new System.Drawing.Size(44, 15);
            this.lblErrorDatosPersonales.TabIndex = 10;
            this.lblErrorDatosPersonales.Text = "label13";
            this.lblErrorDatosPersonales.Visible = false;
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNacionalidad.Location = new System.Drawing.Point(100, 211);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(91, 23);
            this.textBoxNacionalidad.TabIndex = 12;
            this.textBoxNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nacionalidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(209, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 338);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasaporte";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.02128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.97872F));
            this.tableLayoutPanel5.Controls.Add(this.lblErrorDatosPasaporte, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBoxIndentificador, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.fechaVencimiento, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.fechaValida, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.8328F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64952F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(195, 316);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lblErrorDatosPasaporte
            // 
            this.lblErrorDatosPasaporte.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.lblErrorDatosPasaporte, 2);
            this.lblErrorDatosPasaporte.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosPasaporte.Location = new System.Drawing.Point(3, 256);
            this.lblErrorDatosPasaporte.Name = "lblErrorDatosPasaporte";
            this.lblErrorDatosPasaporte.Size = new System.Drawing.Size(38, 15);
            this.lblErrorDatosPasaporte.TabIndex = 9;
            this.lblErrorDatosPasaporte.Text = "label7";
            this.lblErrorDatosPasaporte.Visible = false;
            // 
            // textBoxIndentificador
            // 
            this.textBoxIndentificador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIndentificador.Location = new System.Drawing.Point(75, 3);
            this.textBoxIndentificador.Name = "textBoxIndentificador";
            this.textBoxIndentificador.Size = new System.Drawing.Size(117, 23);
            this.textBoxIndentificador.TabIndex = 3;
            this.textBoxIndentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Indentificador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hasta";
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaVencimiento.Location = new System.Drawing.Point(75, 159);
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Size = new System.Drawing.Size(117, 23);
            this.fechaVencimiento.TabIndex = 8;
            // 
            // fechaValida
            // 
            this.fechaValida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaValida.Location = new System.Drawing.Point(75, 81);
            this.fechaValida.Name = "fechaValida";
            this.fechaValida.Size = new System.Drawing.Size(117, 23);
            this.fechaValida.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(416, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 338);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipaje";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblErrorDatosEquipaje, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxBolsoMano, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxValija1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblValija2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBoxValija2, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.51125F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.97106F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(196, 316);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblErrorDatosEquipaje
            // 
            this.lblErrorDatosEquipaje.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblErrorDatosEquipaje, 2);
            this.lblErrorDatosEquipaje.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatosEquipaje.Location = new System.Drawing.Point(3, 255);
            this.lblErrorDatosEquipaje.Name = "lblErrorDatosEquipaje";
            this.lblErrorDatosEquipaje.Size = new System.Drawing.Size(44, 15);
            this.lblErrorDatosEquipaje.TabIndex = 16;
            this.lblErrorDatosEquipaje.Text = "label14";
            this.lblErrorDatosEquipaje.Visible = false;
            // 
            // checkBoxBolsoMano
            // 
            this.checkBoxBolsoMano.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.checkBoxBolsoMano, 2);
            this.checkBoxBolsoMano.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBolsoMano.Name = "checkBoxBolsoMano";
            this.checkBoxBolsoMano.Size = new System.Drawing.Size(105, 19);
            this.checkBoxBolsoMano.TabIndex = 13;
            this.checkBoxBolsoMano.Text = "Bolso de mano";
            this.checkBoxBolsoMano.UseVisualStyleBackColor = true;
            // 
            // textBoxValija1
            // 
            this.textBoxValija1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValija1.Location = new System.Drawing.Point(101, 81);
            this.textBoxValija1.Name = "textBoxValija1";
            this.textBoxValija1.Size = new System.Drawing.Size(92, 23);
            this.textBoxValija1.TabIndex = 3;
            this.textBoxValija1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // lblValija2
            // 
            this.lblValija2.AutoSize = true;
            this.lblValija2.Location = new System.Drawing.Point(3, 156);
            this.lblValija2.Name = "lblValija2";
            this.lblValija2.Size = new System.Drawing.Size(81, 30);
            this.lblValija2.TabIndex = 14;
            this.lblValija2.Text = "Peso valija #2 (25KG)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Peso valija #1 (25KG)";
            // 
            // textBoxValija2
            // 
            this.textBoxValija2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValija2.Location = new System.Drawing.Point(101, 159);
            this.textBoxValija2.Name = "textBoxValija2";
            this.textBoxValija2.Size = new System.Drawing.Size(92, 23);
            this.textBoxValija2.TabIndex = 15;
            this.textBoxValija2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Turista";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Premiun";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 194);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costo del pasaje";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxCostoPasaje, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.09467F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.90533F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 172);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // textBoxCostoPasaje
            // 
            this.textBoxCostoPasaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCostoPasaje.Enabled = false;
            this.textBoxCostoPasaje.Location = new System.Drawing.Point(100, 65);
            this.textBoxCostoPasaje.Name = "textBoxCostoPasaje";
            this.textBoxCostoPasaje.Size = new System.Drawing.Size(91, 23);
            this.textBoxCostoPasaje.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Costo del pasaje";
            // 
            // groupBox5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox5, 2);
            this.groupBox5.Controls.Add(this.tableLayoutPanel2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(209, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(409, 194);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion del viaje";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxCamarotesPremiunDisponibles, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCamarotesTuristaDisponibles, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.68212F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.31788F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(403, 172);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // textBoxCamarotesPremiunDisponibles
            // 
            this.textBoxCamarotesPremiunDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCamarotesPremiunDisponibles.Enabled = false;
            this.textBoxCamarotesPremiunDisponibles.Location = new System.Drawing.Point(204, 85);
            this.textBoxCamarotesPremiunDisponibles.Name = "textBoxCamarotesPremiunDisponibles";
            this.textBoxCamarotesPremiunDisponibles.Size = new System.Drawing.Size(196, 23);
            this.textBoxCamarotesPremiunDisponibles.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Camarotes disponibles turista";
            // 
            // textBoxCamarotesTuristaDisponibles
            // 
            this.textBoxCamarotesTuristaDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCamarotesTuristaDisponibles.Enabled = false;
            this.textBoxCamarotesTuristaDisponibles.Location = new System.Drawing.Point(204, 3);
            this.textBoxCamarotesTuristaDisponibles.Name = "textBoxCamarotesTuristaDisponibles";
            this.textBoxCamarotesTuristaDisponibles.Size = new System.Drawing.Size(196, 23);
            this.textBoxCamarotesTuristaDisponibles.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Camarotes disponibles premiun";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.33558F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.443507F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 602);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(543, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(902, 641);
            this.MinimumSize = new System.Drawing.Size(637, 583);
            this.Name = "frmRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarCliente";
            this.Load += new System.EventHandler(this.frmRegistrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}