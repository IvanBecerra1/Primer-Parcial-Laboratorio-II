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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBarcos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDestinos = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensajeInformativo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCasino = new System.Windows.Forms.CheckBox();
            this.checkBoxPicina = new System.Windows.Forms.CheckBox();
            this.checkBoxGimnasio = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(10, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(389, 449);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 51);
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
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViajes, 2);
            this.dataGridViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViajes.Location = new System.Drawing.Point(3, 30);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.RowTemplate.Height = 25;
            this.dataGridViajes.Size = new System.Drawing.Size(753, 161);
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
            this.rowPasajeros.HeaderText = "Lugares disponible";
            this.rowPasajeros.Name = "rowPasajeros";
            // 
            // rowId
            // 
            this.rowId.HeaderText = "Id";
            this.rowId.Name = "rowId";
            this.rowId.ReadOnly = true;
            this.rowId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 219);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.16666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83334F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 197);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxBarcos, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(284, 56);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBoxBarcos
            // 
            this.comboBoxBarcos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBarcos.FormattingEnabled = true;
            this.comboBoxBarcos.Location = new System.Drawing.Point(3, 31);
            this.comboBoxBarcos.Name = "comboBoxBarcos";
            this.comboBoxBarcos.Size = new System.Drawing.Size(278, 23);
            this.comboBoxBarcos.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre de barco";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 62);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 23);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha actual hasta >>";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(303, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxDestinos, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(284, 61);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Por destinos";
            // 
            // comboBoxDestinos
            // 
            this.comboBoxDestinos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDestinos.FormattingEnabled = true;
            this.comboBoxDestinos.Location = new System.Drawing.Point(3, 33);
            this.comboBoxDestinos.Name = "comboBoxDestinos";
            this.comboBoxDestinos.Size = new System.Drawing.Size(278, 23);
            this.comboBoxDestinos.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(303, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(303, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Busqueda de viajes";
            // 
            // lblMensajeInformativo
            // 
            this.lblMensajeInformativo.AutoSize = true;
            this.lblMensajeInformativo.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeInformativo.Location = new System.Drawing.Point(3, 419);
            this.lblMensajeInformativo.Name = "lblMensajeInformativo";
            this.lblMensajeInformativo.Size = new System.Drawing.Size(155, 15);
            this.lblMensajeInformativo.TabIndex = 23;
            this.lblMensajeInformativo.Text = "No has seleccionado el viaje";
            this.lblMensajeInformativo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(382, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 219);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preferencias";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.checkBoxCasino, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxPicina, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxGimnasio, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.11111F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.55556F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(368, 197);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // checkBoxCasino
            // 
            this.checkBoxCasino.AutoSize = true;
            this.checkBoxCasino.Location = new System.Drawing.Point(3, 44);
            this.checkBoxCasino.Name = "checkBoxCasino";
            this.checkBoxCasino.Size = new System.Drawing.Size(62, 19);
            this.checkBoxCasino.TabIndex = 4;
            this.checkBoxCasino.Text = "Casino";
            this.checkBoxCasino.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicina
            // 
            this.checkBoxPicina.AutoSize = true;
            this.checkBoxPicina.Location = new System.Drawing.Point(3, 3);
            this.checkBoxPicina.Name = "checkBoxPicina";
            this.checkBoxPicina.Size = new System.Drawing.Size(58, 19);
            this.checkBoxPicina.TabIndex = 3;
            this.checkBoxPicina.Text = "Picina";
            this.checkBoxPicina.UseVisualStyleBackColor = true;
            // 
            // checkBoxGimnasio
            // 
            this.checkBoxGimnasio.AutoSize = true;
            this.checkBoxGimnasio.Location = new System.Drawing.Point(3, 80);
            this.checkBoxGimnasio.Name = "checkBoxGimnasio";
            this.checkBoxGimnasio.Size = new System.Drawing.Size(76, 19);
            this.checkBoxGimnasio.TabIndex = 5;
            this.checkBoxGimnasio.Text = "Gimnasio";
            this.checkBoxGimnasio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViajes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMensajeInformativo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.237424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.02817F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.10565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.668304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 510);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Location = new System.Drawing.Point(681, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 21);
            this.button6.TabIndex = 24;
            this.button6.Text = "Ayuda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmSeleccionarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(775, 549);
            this.MinimumSize = new System.Drawing.Size(553, 528);
            this.Name = "frmSeleccionarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de viaje";
            this.Load += new System.EventHandler(this.frmSeleccionarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxDestinos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensajeInformativo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.ComboBox comboBoxBarcos;
        private System.Windows.Forms.CheckBox checkBoxGimnasio;
        private System.Windows.Forms.CheckBox checkBoxCasino;
        private System.Windows.Forms.CheckBox checkBoxPicina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button6;
    }
}