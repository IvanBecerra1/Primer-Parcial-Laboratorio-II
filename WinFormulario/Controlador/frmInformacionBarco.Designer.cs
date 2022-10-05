namespace WinFormulario.Controlador
{
    partial class frmInformacionBarco
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
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSalones = new System.Windows.Forms.ListBox();
            this.textBoxCamarotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCasino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxProximosViajes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Enabled = false;
            this.textBoxMatricula.Location = new System.Drawing.Point(12, 154);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(120, 23);
            this.textBoxMatricula.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(12, 101);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 23);
            this.textBoxNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salones incorporados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de barco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Informacion de barco";
            // 
            // listBoxSalones
            // 
            this.listBoxSalones.FormattingEnabled = true;
            this.listBoxSalones.ItemHeight = 15;
            this.listBoxSalones.Location = new System.Drawing.Point(12, 327);
            this.listBoxSalones.Name = "listBoxSalones";
            this.listBoxSalones.Size = new System.Drawing.Size(120, 94);
            this.listBoxSalones.TabIndex = 14;
            // 
            // textBoxCamarotes
            // 
            this.textBoxCamarotes.Enabled = false;
            this.textBoxCamarotes.Location = new System.Drawing.Point(12, 265);
            this.textBoxCamarotes.Name = "textBoxCamarotes";
            this.textBoxCamarotes.Size = new System.Drawing.Size(120, 23);
            this.textBoxCamarotes.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Camarotes total";
            // 
            // textBoxCasino
            // 
            this.textBoxCasino.Enabled = false;
            this.textBoxCasino.Location = new System.Drawing.Point(12, 209);
            this.textBoxCasino.Name = "textBoxCasino";
            this.textBoxCasino.Size = new System.Drawing.Size(120, 23);
            this.textBoxCasino.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Casino";
            // 
            // listBoxProximosViajes
            // 
            this.listBoxProximosViajes.FormattingEnabled = true;
            this.listBoxProximosViajes.ItemHeight = 15;
            this.listBoxProximosViajes.Location = new System.Drawing.Point(138, 102);
            this.listBoxProximosViajes.Name = "listBoxProximosViajes";
            this.listBoxProximosViajes.Size = new System.Drawing.Size(212, 319);
            this.listBoxProximosViajes.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Proximos viajes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmInformacionBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 505);
            this.Controls.Add(this.listBoxProximosViajes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCasino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCamarotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxSalones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmInformacionBarco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformacionBarco";
            this.Load += new System.EventHandler(this.frmInformacionBarco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSalones;
        private System.Windows.Forms.TextBox textBoxCamarotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCasino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxProximosViajes;
        private System.Windows.Forms.Label label8;
    }
}