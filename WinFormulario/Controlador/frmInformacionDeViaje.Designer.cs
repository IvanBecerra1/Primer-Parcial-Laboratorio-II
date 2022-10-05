namespace WinFormulario.Controlador
{
    partial class frmInformacionDeViaje
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridPasajeros = new System.Windows.Forms.DataGridView();
            this.rowNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPasajeros = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBoxPasajeros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar un viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(18, 280);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(99, 19);
            this.radioButton6.TabIndex = 28;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Mostrar todos";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 255);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(191, 19);
            this.radioButton5.TabIndex = 27;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Mostrar solo pasajeros premiun";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 19);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mostrar solo turistas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de pasajeros";
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.AllowDrop = true;
            this.dataGridPasajeros.AllowUserToAddRows = false;
            this.dataGridPasajeros.AllowUserToDeleteRows = false;
            this.dataGridPasajeros.AllowUserToResizeColumns = false;
            this.dataGridPasajeros.AllowUserToResizeRows = false;
            this.dataGridPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNombre,
            this.rowApellido,
            this.rowDocumento,
            this.rowClase});
            this.dataGridPasajeros.Location = new System.Drawing.Point(18, 68);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.RowTemplate.Height = 25;
            this.dataGridPasajeros.Size = new System.Drawing.Size(543, 150);
            this.dataGridPasajeros.TabIndex = 20;
            this.dataGridPasajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPasajeros_CellClick);
            // 
            // rowNombre
            // 
            this.rowNombre.HeaderText = "Nombre";
            this.rowNombre.Name = "rowNombre";
            this.rowNombre.ReadOnly = true;
            // 
            // rowApellido
            // 
            this.rowApellido.HeaderText = "Apellido";
            this.rowApellido.Name = "rowApellido";
            this.rowApellido.ReadOnly = true;
            // 
            // rowDocumento
            // 
            this.rowDocumento.HeaderText = "Documento";
            this.rowDocumento.Name = "rowDocumento";
            this.rowDocumento.ReadOnly = true;
            // 
            // rowClase
            // 
            this.rowClase.HeaderText = "Clase";
            this.rowClase.Name = "rowClase";
            this.rowClase.ReadOnly = true;
            // 
            // groupBoxPasajeros
            // 
            this.groupBoxPasajeros.Controls.Add(this.dataGridPasajeros);
            this.groupBoxPasajeros.Controls.Add(this.radioButton6);
            this.groupBoxPasajeros.Controls.Add(this.label3);
            this.groupBoxPasajeros.Controls.Add(this.radioButton5);
            this.groupBoxPasajeros.Controls.Add(this.radioButton1);
            this.groupBoxPasajeros.Location = new System.Drawing.Point(12, 92);
            this.groupBoxPasajeros.Name = "groupBoxPasajeros";
            this.groupBoxPasajeros.Size = new System.Drawing.Size(581, 402);
            this.groupBoxPasajeros.TabIndex = 29;
            this.groupBoxPasajeros.TabStop = false;
            this.groupBoxPasajeros.Text = "Pasajeros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxNacionalidad);
            this.groupBox1.Controls.Add(this.textBoxEdad);
            this.groupBox1.Location = new System.Drawing.Point(599, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 402);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Consultar pasaporte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Consultar Equipaje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Informacion del pasajero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nacionalidad";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.Location = new System.Drawing.Point(18, 139);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(199, 23);
            this.textBoxApellido.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(20, 81);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(199, 23);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Enabled = false;
            this.textBoxNacionalidad.Location = new System.Drawing.Point(18, 248);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(199, 23);
            this.textBoxNacionalidad.TabIndex = 1;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Enabled = false;
            this.textBoxEdad.Location = new System.Drawing.Point(18, 197);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(199, 23);
            this.textBoxEdad.TabIndex = 0;
            // 
            // frmInformacionDeViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPasajeros);
            this.Controls.Add(this.button1);
            this.Name = "frmInformacionDeViaje";
            this.Text = "frmInformacionDeViaje";
            this.Load += new System.EventHandler(this.frmInformacionDeViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBoxPasajeros.ResumeLayout(false);
            this.groupBoxPasajeros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBoxPasajeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowClase;
    }
}