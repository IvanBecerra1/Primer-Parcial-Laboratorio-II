﻿namespace WinFormulario.Controlador
{
    partial class frmConsultarPasaporte
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
            this.textBoxCantidadViajes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndentificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFechaAlta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaVencimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCantidadViajes
            // 
            this.textBoxCantidadViajes.Enabled = false;
            this.textBoxCantidadViajes.Location = new System.Drawing.Point(68, 146);
            this.textBoxCantidadViajes.Name = "textBoxCantidadViajes";
            this.textBoxCantidadViajes.Size = new System.Drawing.Size(155, 23);
            this.textBoxCantidadViajes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "cantidad de viajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indentificador";
            // 
            // textBoxIndentificador
            // 
            this.textBoxIndentificador.Enabled = false;
            this.textBoxIndentificador.Location = new System.Drawing.Point(69, 84);
            this.textBoxIndentificador.Name = "textBoxIndentificador";
            this.textBoxIndentificador.Size = new System.Drawing.Size(155, 23);
            this.textBoxIndentificador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "fecha de alta";
            // 
            // textBoxFechaAlta
            // 
            this.textBoxFechaAlta.Enabled = false;
            this.textBoxFechaAlta.Location = new System.Drawing.Point(68, 211);
            this.textBoxFechaAlta.Name = "textBoxFechaAlta";
            this.textBoxFechaAlta.Size = new System.Drawing.Size(155, 23);
            this.textBoxFechaAlta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "fecha de vencimiento";
            // 
            // textBoxFechaVencimiento
            // 
            this.textBoxFechaVencimiento.Enabled = false;
            this.textBoxFechaVencimiento.Location = new System.Drawing.Point(68, 263);
            this.textBoxFechaVencimiento.Name = "textBoxFechaVencimiento";
            this.textBoxFechaVencimiento.Size = new System.Drawing.Size(155, 23);
            this.textBoxFechaVencimiento.TabIndex = 7;
            // 
            // frmConsultarPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFechaAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIndentificador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCantidadViajes);
            this.Controls.Add(this.button1);
            this.Name = "frmConsultarPasaporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarPasaporte";
            this.Load += new System.EventHandler(this.frmConsultarPasaporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCantidadViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndentificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFechaAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaVencimiento;
    }
}