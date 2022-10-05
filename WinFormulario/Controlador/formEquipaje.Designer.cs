namespace WinFormulario.Controlador
{
    partial class formEquipaje
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
            this.textBoxBolsoDeMano = new System.Windows.Forms.TextBox();
            this.textBoxValija1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValija2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bolso de mano";
            // 
            // textBoxBolsoDeMano
            // 
            this.textBoxBolsoDeMano.Enabled = false;
            this.textBoxBolsoDeMano.Location = new System.Drawing.Point(102, 168);
            this.textBoxBolsoDeMano.Name = "textBoxBolsoDeMano";
            this.textBoxBolsoDeMano.Size = new System.Drawing.Size(100, 23);
            this.textBoxBolsoDeMano.TabIndex = 2;
            // 
            // textBoxValija1
            // 
            this.textBoxValija1.Enabled = false;
            this.textBoxValija1.Location = new System.Drawing.Point(102, 232);
            this.textBoxValija1.Name = "textBoxValija1";
            this.textBoxValija1.Size = new System.Drawing.Size(100, 23);
            this.textBoxValija1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso valija #1";
            // 
            // textBoxValija2
            // 
            this.textBoxValija2.Enabled = false;
            this.textBoxValija2.Location = new System.Drawing.Point(102, 306);
            this.textBoxValija2.Name = "textBoxValija2";
            this.textBoxValija2.Size = new System.Drawing.Size(100, 23);
            this.textBoxValija2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso valija #2";
            // 
            // formEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 468);
            this.Controls.Add(this.textBoxValija2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValija1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBolsoDeMano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "formEquipaje";
            this.Text = "formEquipaje";
            this.Load += new System.EventHandler(this.formEquipaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBolsoDeMano;
        private System.Windows.Forms.TextBox textBoxValija1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValija2;
        private System.Windows.Forms.Label label3;
    }
}