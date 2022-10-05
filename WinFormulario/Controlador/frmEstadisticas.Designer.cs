namespace WinFormulario.Controlador
{
    partial class frmEstadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegionales = new System.Windows.Forms.TextBox();
            this.textBoxSudamericanos = new System.Windows.Forms.TextBox();
            this.listBoxHorasCruceros = new System.Windows.Forms.ListBox();
            this.listBoxPasajerosFrecuentes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ganancias viajes Extra regionales: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ganancia viajes Sudamericanos: ";
            // 
            // textBoxRegionales
            // 
            this.textBoxRegionales.Location = new System.Drawing.Point(241, 57);
            this.textBoxRegionales.Name = "textBoxRegionales";
            this.textBoxRegionales.Size = new System.Drawing.Size(162, 23);
            this.textBoxRegionales.TabIndex = 2;
            // 
            // textBoxSudamericanos
            // 
            this.textBoxSudamericanos.Location = new System.Drawing.Point(241, 90);
            this.textBoxSudamericanos.Name = "textBoxSudamericanos";
            this.textBoxSudamericanos.Size = new System.Drawing.Size(162, 23);
            this.textBoxSudamericanos.TabIndex = 3;
            // 
            // listBoxHorasCruceros
            // 
            this.listBoxHorasCruceros.FormattingEnabled = true;
            this.listBoxHorasCruceros.ItemHeight = 15;
            this.listBoxHorasCruceros.Location = new System.Drawing.Point(419, 29);
            this.listBoxHorasCruceros.Name = "listBoxHorasCruceros";
            this.listBoxHorasCruceros.Size = new System.Drawing.Size(369, 199);
            this.listBoxHorasCruceros.TabIndex = 4;
            // 
            // listBoxPasajerosFrecuentes
            // 
            this.listBoxPasajerosFrecuentes.FormattingEnabled = true;
            this.listBoxPasajerosFrecuentes.ItemHeight = 15;
            this.listBoxPasajerosFrecuentes.Location = new System.Drawing.Point(419, 275);
            this.listBoxPasajerosFrecuentes.Name = "listBoxPasajerosFrecuentes";
            this.listBoxPasajerosFrecuentes.Size = new System.Drawing.Size(369, 154);
            this.listBoxPasajerosFrecuentes.TabIndex = 5;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPasajerosFrecuentes);
            this.Controls.Add(this.listBoxHorasCruceros);
            this.Controls.Add(this.textBoxSudamericanos);
            this.Controls.Add(this.textBoxRegionales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegionales;
        private System.Windows.Forms.TextBox textBoxSudamericanos;
        private System.Windows.Forms.ListBox listBoxHorasCruceros;
        private System.Windows.Forms.ListBox listBoxPasajerosFrecuentes;
    }
}