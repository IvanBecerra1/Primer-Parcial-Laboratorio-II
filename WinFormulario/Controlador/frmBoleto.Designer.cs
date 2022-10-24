namespace WinFormulario.Controlador
{
    partial class frmBoleto
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
            this.lblPrecioTurista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCostoImpuestos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadTurista = new System.Windows.Forms.Label();
            this.lblCostoTurista = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrecioPremiun = new System.Windows.Forms.Label();
            this.lblCostoPremiun = new System.Windows.Forms.Label();
            this.lblCantidadPremiun = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCostoFinal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(30, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(217, 465);
            this.button2.Margin = new System.Windows.Forms.Padding(30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar operacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio por persona (T)";
            // 
            // lblPrecioTurista
            // 
            this.lblPrecioTurista.AutoSize = true;
            this.lblPrecioTurista.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTurista.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrecioTurista.Location = new System.Drawing.Point(3, 96);
            this.lblPrecioTurista.Name = "lblPrecioTurista";
            this.lblPrecioTurista.Size = new System.Drawing.Size(87, 28);
            this.lblPrecioTurista.TabIndex = 3;
            this.lblPrecioTurista.Text = "$ 00.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio final";
            // 
            // lblCostoImpuestos
            // 
            this.lblCostoImpuestos.AutoSize = true;
            this.lblCostoImpuestos.ForeColor = System.Drawing.Color.Red;
            this.lblCostoImpuestos.Location = new System.Drawing.Point(184, 206);
            this.lblCostoImpuestos.Name = "lblCostoImpuestos";
            this.lblCostoImpuestos.Size = new System.Drawing.Size(74, 15);
            this.lblCostoImpuestos.TabIndex = 5;
            this.lblCostoImpuestos.Text = "$ Costo total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Impuestos, tasas y IVA";
            // 
            // lblCantidadTurista
            // 
            this.lblCantidadTurista.AutoSize = true;
            this.lblCantidadTurista.Location = new System.Drawing.Point(3, 155);
            this.lblCantidadTurista.Name = "lblCantidadTurista";
            this.lblCantidadTurista.Size = new System.Drawing.Size(110, 15);
            this.lblCantidadTurista.TabIndex = 7;
            this.lblCantidadTurista.Text = "N Persona (turistas)";
            // 
            // lblCostoTurista
            // 
            this.lblCostoTurista.AutoSize = true;
            this.lblCostoTurista.ForeColor = System.Drawing.Color.Red;
            this.lblCostoTurista.Location = new System.Drawing.Point(184, 155);
            this.lblCostoTurista.Name = "lblCostoTurista";
            this.lblCostoTurista.Size = new System.Drawing.Size(106, 15);
            this.lblCostoTurista.TabIndex = 8;
            this.lblCostoTurista.Text = "$ Costo total bruto";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 256);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio neto";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCostoImpuestos, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCantidadTurista, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCostoPremiun, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCantidadPremiun, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCostoTurista, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.9836F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.55046F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.46789F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06557F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 234);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPrecioPremiun, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblPrecioTurista, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(184, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77419F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.6129F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.19355F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(175, 149);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Precio por persona (P)";
            // 
            // lblPrecioPremiun
            // 
            this.lblPrecioPremiun.AutoSize = true;
            this.lblPrecioPremiun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioPremiun.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrecioPremiun.Location = new System.Drawing.Point(3, 25);
            this.lblPrecioPremiun.Name = "lblPrecioPremiun";
            this.lblPrecioPremiun.Size = new System.Drawing.Size(87, 28);
            this.lblPrecioPremiun.TabIndex = 12;
            this.lblPrecioPremiun.Text = "$ 00.000";
            // 
            // lblCostoPremiun
            // 
            this.lblCostoPremiun.AutoSize = true;
            this.lblCostoPremiun.ForeColor = System.Drawing.Color.Red;
            this.lblCostoPremiun.Location = new System.Drawing.Point(184, 179);
            this.lblCostoPremiun.Name = "lblCostoPremiun";
            this.lblCostoPremiun.Size = new System.Drawing.Size(106, 15);
            this.lblCostoPremiun.TabIndex = 10;
            this.lblCostoPremiun.Text = "$ Costo total bruto";
            // 
            // lblCantidadPremiun
            // 
            this.lblCantidadPremiun.AutoSize = true;
            this.lblCantidadPremiun.Location = new System.Drawing.Point(3, 179);
            this.lblCantidadPremiun.Name = "lblCantidadPremiun";
            this.lblCantidadPremiun.Size = new System.Drawing.Size(117, 15);
            this.lblCantidadPremiun.TabIndex = 9;
            this.lblCantidadPremiun.Text = "N Persona (premiun)";
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio final";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCostoFinal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.77359F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.22641F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 145);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Incluye impt PAIS y Percepcion";
            // 
            // lblCostoFinal
            // 
            this.lblCostoFinal.AutoSize = true;
            this.lblCostoFinal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCostoFinal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCostoFinal.Location = new System.Drawing.Point(184, 63);
            this.lblCostoFinal.Name = "lblCostoFinal";
            this.lblCostoFinal.Size = new System.Drawing.Size(87, 28);
            this.lblCostoFinal.TabIndex = 9;
            this.lblCostoFinal.Text = "$ 00.000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.09455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.73077F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 524);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // frmBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(709, 631);
            this.MinimumSize = new System.Drawing.Size(390, 563);
            this.Name = "frmBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleto";
            this.Load += new System.EventHandler(this.frmBoleto_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecioTurista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCostoImpuestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidadTurista;
        private System.Windows.Forms.Label lblCostoTurista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrecioPremiun;
        private System.Windows.Forms.Label lblCantidadPremiun;
        private System.Windows.Forms.Label lblCostoPremiun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCostoFinal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}