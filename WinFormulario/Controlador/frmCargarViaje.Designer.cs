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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("agave NFM", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargar un nuevo viaje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeViaje
            // 
            this.dateTimeViaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeViaje.Location = new System.Drawing.Point(3, 42);
            this.dateTimeViaje.Name = "dateTimeViaje";
            this.dateTimeViaje.Size = new System.Drawing.Size(603, 23);
            this.dateTimeViaje.TabIndex = 7;
            // 
            // comboBoxListaCruceros
            // 
            this.comboBoxListaCruceros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxListaCruceros.FormattingEnabled = true;
            this.comboBoxListaCruceros.Location = new System.Drawing.Point(3, 43);
            this.comboBoxListaCruceros.Name = "comboBoxListaCruceros";
            this.comboBoxListaCruceros.Size = new System.Drawing.Size(603, 23);
            this.comboBoxListaCruceros.TabIndex = 9;
            this.comboBoxListaCruceros.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaCruceros_SelectedIndexChanged);
            // 
            // comboBoxListaDeLugares
            // 
            this.comboBoxListaDeLugares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxListaDeLugares.FormattingEnabled = true;
            this.comboBoxListaDeLugares.Location = new System.Drawing.Point(3, 38);
            this.comboBoxListaDeLugares.Name = "comboBoxListaDeLugares";
            this.comboBoxListaDeLugares.Size = new System.Drawing.Size(603, 23);
            this.comboBoxListaDeLugares.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(190, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccionar crucero disponibles";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(211, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccionar lugar de viaje";
            // 
            // rButtonExtraRegionales
            // 
            this.rButtonExtraRegionales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rButtonExtraRegionales.AutoSize = true;
            this.rButtonExtraRegionales.Location = new System.Drawing.Point(98, 7);
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
            this.rButtonSudamericanos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rButtonSudamericanos.AutoSize = true;
            this.rButtonSudamericanos.Location = new System.Drawing.Point(403, 7);
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
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(310, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(106, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(95, 15);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Mensaje de error";
            // 
            // listBoxFechas
            // 
            this.listBoxFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFechas.FormattingEnabled = true;
            this.listBoxFechas.ItemHeight = 15;
            this.listBoxFechas.Location = new System.Drawing.Point(3, 28);
            this.listBoxFechas.Name = "listBoxFechas";
            this.listBoxFechas.Size = new System.Drawing.Size(603, 79);
            this.listBoxFechas.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fechas programadas del crucero";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.811623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.43888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.613226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.70073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.615231F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 598);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimeViaje, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(609, 79);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxListaCruceros, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(609, 97);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.listBoxFechas, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(609, 110);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.rButtonSudamericanos, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.rButtonExtraRegionales, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(609, 33);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxListaDeLugares, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 380);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.96491F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.03509F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(609, 100);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.44843F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.55157F));
            this.tableLayoutPanel7.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblError, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 486);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37313F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.62687F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(609, 60);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.38588F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.61412F));
            this.tableLayoutPanel8.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(609, 28);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(531, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCargarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(631, 637);
            this.MinimumSize = new System.Drawing.Size(434, 553);
            this.Name = "frmCargarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar viaje";
            this.Load += new System.EventHandler(this.frmCargarViaje_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button3;
    }
}