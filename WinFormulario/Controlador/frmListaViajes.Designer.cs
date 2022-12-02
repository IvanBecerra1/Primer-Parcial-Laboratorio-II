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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar viaje ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de viajes";
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
            this.dataGridViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViajes.Location = new System.Drawing.Point(3, 135);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.RowTemplate.Height = 25;
            this.dataGridViajes.Size = new System.Drawing.Size(588, 274);
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
            this.button6.Location = new System.Drawing.Point(347, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 34);
            this.button6.TabIndex = 12;
            this.button6.Text = "Actualizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Informacion del viaje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Informacion del barco";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViajes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.03623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.876812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.71542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 552);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.61225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.32653F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(588, 134);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(588, 77);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(510, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 71);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ayuda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmListaViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListaViajes";
            this.Text = "frmListaViajes";
            this.Load += new System.EventHandler(this.frmListaViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowEstado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button4;
    }
}