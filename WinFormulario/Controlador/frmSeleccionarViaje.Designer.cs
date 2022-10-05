namespace WinFormulario.Controlador
{
    partial class frmSeleccionarViaje
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
            this.dataGridViajes = new System.Windows.Forms.DataGridView();
            this.rowDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestinos = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdOrdenarAsc = new System.Windows.Forms.RadioButton();
            this.rbOrdenarDes = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensajeInformativo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViajes
            // 
            this.dataGridViajes.AllowUserToAddRows = false;
            this.dataGridViajes.AllowUserToDeleteRows = false;
            this.dataGridViajes.AllowUserToResizeColumns = false;
            this.dataGridViajes.AllowUserToResizeRows = false;
            this.dataGridViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDestino,
            this.rowCrucero,
            this.rowFecha,
            this.rowEstado,
            this.rowPasajeros,
            this.rowId});
            this.dataGridViajes.Location = new System.Drawing.Point(27, 35);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.RowTemplate.Height = 25;
            this.dataGridViajes.Size = new System.Drawing.Size(583, 143);
            this.dataGridViajes.TabIndex = 6;
            this.dataGridViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViajes_CellClick);
            // 
            // rowDestino
            // 
            this.rowDestino.HeaderText = "Destino";
            this.rowDestino.Name = "rowDestino";
            this.rowDestino.ReadOnly = true;
            // 
            // rowCrucero
            // 
            this.rowCrucero.HeaderText = "Crucero";
            this.rowCrucero.Name = "rowCrucero";
            this.rowCrucero.ReadOnly = true;
            // 
            // rowFecha
            // 
            this.rowFecha.HeaderText = "Fecha de Viaje";
            this.rowFecha.Name = "rowFecha";
            this.rowFecha.ReadOnly = true;
            // 
            // rowEstado
            // 
            this.rowEstado.HeaderText = "Estado";
            this.rowEstado.Name = "rowEstado";
            this.rowEstado.ReadOnly = true;
            // 
            // rowPasajeros
            // 
            this.rowPasajeros.HeaderText = "P";
            this.rowPasajeros.Name = "rowPasajeros";
            // 
            // rowId
            // 
            this.rowId.HeaderText = "Id";
            this.rowId.Name = "rowId";
            this.rowId.ReadOnly = true;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(20, 40);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(140, 23);
            this.textBoxBuscador.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxDestinos);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBoxBuscador);
            this.groupBox1.Location = new System.Drawing.Point(27, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Por destinos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre de barco";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(165, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha actual hasta >>";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 23);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBoxDestinos
            // 
            this.comboBoxDestinos.FormattingEnabled = true;
            this.comboBoxDestinos.Location = new System.Drawing.Point(20, 138);
            this.comboBoxDestinos.Name = "comboBoxDestinos";
            this.comboBoxDestinos.Size = new System.Drawing.Size(140, 23);
            this.comboBoxDestinos.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdOrdenarAsc);
            this.groupBox2.Controls.Add(this.rbOrdenarDes);
            this.groupBox2.Location = new System.Drawing.Point(352, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 159);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenamiento";
            // 
            // rdOrdenarAsc
            // 
            this.rdOrdenarAsc.AutoSize = true;
            this.rdOrdenarAsc.Location = new System.Drawing.Point(12, 119);
            this.rdOrdenarAsc.Name = "rdOrdenarAsc";
            this.rdOrdenarAsc.Size = new System.Drawing.Size(67, 19);
            this.rdOrdenarAsc.TabIndex = 1;
            this.rdOrdenarAsc.TabStop = true;
            this.rdOrdenarAsc.Text = "Crucero";
            this.rdOrdenarAsc.UseVisualStyleBackColor = true;
            this.rdOrdenarAsc.CheckedChanged += new System.EventHandler(this.rdOrdenarAsc_CheckedChanged);
            // 
            // rbOrdenarDes
            // 
            this.rbOrdenarDes.AutoSize = true;
            this.rbOrdenarDes.Location = new System.Drawing.Point(12, 94);
            this.rbOrdenarDes.Name = "rbOrdenarDes";
            this.rbOrdenarDes.Size = new System.Drawing.Size(85, 19);
            this.rbOrdenarDes.TabIndex = 0;
            this.rbOrdenarDes.TabStop = true;
            this.rbOrdenarDes.Text = "Por destino";
            this.rbOrdenarDes.UseVisualStyleBackColor = true;
            this.rbOrdenarDes.CheckedChanged += new System.EventHandler(this.rbOrdenarDes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Busqueda de viajes";
            // 
            // lblMensajeInformativo
            // 
            this.lblMensajeInformativo.AutoSize = true;
            this.lblMensajeInformativo.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeInformativo.Location = new System.Drawing.Point(26, 371);
            this.lblMensajeInformativo.Name = "lblMensajeInformativo";
            this.lblMensajeInformativo.Size = new System.Drawing.Size(155, 15);
            this.lblMensajeInformativo.TabIndex = 23;
            this.lblMensajeInformativo.Text = "No has seleccionado el viaje";
            this.lblMensajeInformativo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(476, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 159);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preferencias";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Crucero";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Casino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMensajeInformativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViajes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmSeleccionarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionarViaje";
            this.Load += new System.EventHandler(this.frmSeleccionarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdOrdenarAsc;
        private System.Windows.Forms.RadioButton rbOrdenarDes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowPasajeros;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxDestinos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensajeInformativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}