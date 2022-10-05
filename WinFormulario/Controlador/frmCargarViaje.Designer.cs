namespace WinFormulario
{
    partial class frmCargarViaje
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
            this.dateTimeViaje = new System.Windows.Forms.DateTimePicker();
            this.comboBoxListaCruceros = new System.Windows.Forms.ComboBox();
            this.comboBoxListaDeLugares = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rButtonExtraRegionales = new System.Windows.Forms.RadioButton();
            this.rButtonSudamericanos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.listBoxFechas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargar un nuevo viaje";
            // 
            // dateTimeViaje
            // 
            this.dateTimeViaje.Location = new System.Drawing.Point(85, 97);
            this.dateTimeViaje.Name = "dateTimeViaje";
            this.dateTimeViaje.Size = new System.Drawing.Size(254, 23);
            this.dateTimeViaje.TabIndex = 7;
            // 
            // comboBoxListaCruceros
            // 
            this.comboBoxListaCruceros.FormattingEnabled = true;
            this.comboBoxListaCruceros.Location = new System.Drawing.Point(85, 162);
            this.comboBoxListaCruceros.Name = "comboBoxListaCruceros";
            this.comboBoxListaCruceros.Size = new System.Drawing.Size(254, 23);
            this.comboBoxListaCruceros.TabIndex = 9;
            this.comboBoxListaCruceros.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaCruceros_SelectedIndexChanged);
            // 
            // comboBoxListaDeLugares
            // 
            this.comboBoxListaDeLugares.FormattingEnabled = true;
            this.comboBoxListaDeLugares.Location = new System.Drawing.Point(85, 391);
            this.comboBoxListaDeLugares.Name = "comboBoxListaDeLugares";
            this.comboBoxListaDeLugares.Size = new System.Drawing.Size(254, 23);
            this.comboBoxListaDeLugares.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccionar crucero disponibles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(85, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccionar lugar de viaje";
            // 
            // rButtonExtraRegionales
            // 
            this.rButtonExtraRegionales.AutoSize = true;
            this.rButtonExtraRegionales.Location = new System.Drawing.Point(85, 324);
            this.rButtonExtraRegionales.Name = "rButtonExtraRegionales";
            this.rButtonExtraRegionales.Size = new System.Drawing.Size(108, 19);
            this.rButtonExtraRegionales.TabIndex = 16;
            this.rButtonExtraRegionales.TabStop = true;
            this.rButtonExtraRegionales.Text = "Extra regionales";
            this.rButtonExtraRegionales.UseVisualStyleBackColor = true;
            this.rButtonExtraRegionales.CheckedChanged += new System.EventHandler(this.rButtonExtraRegionales_CheckedChanged);
            // 
            // rButtonSudamericanos
            // 
            this.rButtonSudamericanos.AutoSize = true;
            this.rButtonSudamericanos.Location = new System.Drawing.Point(221, 324);
            this.rButtonSudamericanos.Name = "rButtonSudamericanos";
            this.rButtonSudamericanos.Size = new System.Drawing.Size(106, 19);
            this.rButtonSudamericanos.TabIndex = 17;
            this.rButtonSudamericanos.TabStop = true;
            this.rButtonSudamericanos.Text = "Sudamericanos";
            this.rButtonSudamericanos.UseVisualStyleBackColor = true;
            this.rButtonSudamericanos.CheckedChanged += new System.EventHandler(this.rButtonSudamericanos_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 450);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(95, 15);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Mensaje de error";
            // 
            // listBoxFechas
            // 
            this.listBoxFechas.FormattingEnabled = true;
            this.listBoxFechas.ItemHeight = 15;
            this.listBoxFechas.Location = new System.Drawing.Point(85, 214);
            this.listBoxFechas.Name = "listBoxFechas";
            this.listBoxFechas.Size = new System.Drawing.Size(252, 94);
            this.listBoxFechas.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fechas programadas del crucero";
            // 
            // frmCargarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxFechas);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rButtonSudamericanos);
            this.Controls.Add(this.rButtonExtraRegionales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListaDeLugares);
            this.Controls.Add(this.comboBoxListaCruceros);
            this.Controls.Add(this.dateTimeViaje);
            this.Controls.Add(this.label1);
            this.Name = "frmCargarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarViaje";
            this.Load += new System.EventHandler(this.frmCargarViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeViaje;
        private System.Windows.Forms.ComboBox comboBoxListaCruceros;
        private System.Windows.Forms.ComboBox comboBoxListaDeLugares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rButtonExtraRegionales;
        private System.Windows.Forms.RadioButton rButtonSudamericanos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox listBoxFechas;
        private System.Windows.Forms.Label label3;
    }
}