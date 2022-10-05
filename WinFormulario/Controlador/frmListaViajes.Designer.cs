namespace WinFormulario.Controlador
{
    partial class frmListaViajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViajes = new System.Windows.Forms.DataGridView();
            this.rowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar viaje ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de viajes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViajes
            // 
            this.dataGridViajes.AllowUserToAddRows = false;
            this.dataGridViajes.AllowUserToDeleteRows = false;
            this.dataGridViajes.AllowUserToResizeColumns = false;
            this.dataGridViajes.AllowUserToResizeRows = false;
            this.dataGridViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowId,
            this.rowDestino,
            this.rowCrucero,
            this.rowFecha,
            this.rowEstado});
            this.dataGridViajes.Location = new System.Drawing.Point(17, 54);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.RowTemplate.Height = 25;
            this.dataGridViajes.Size = new System.Drawing.Size(545, 143);
            this.dataGridViajes.TabIndex = 5;
            this.dataGridViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViajes_CellClick);
            // 
            // rowId
            // 
            this.rowId.HeaderText = "Id";
            this.rowId.Name = "rowId";
            this.rowId.ReadOnly = true;
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 34);
            this.button6.TabIndex = 12;
            this.button6.Text = "Actualizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViajes);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 305);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viajes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Informacion del viaje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Informacion del barco";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmListaViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmListaViajes";
            this.Text = "frmListaViajes";
            this.Load += new System.EventHandler(this.frmListaViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEstado;
        private System.Windows.Forms.Button button2;
    }
}