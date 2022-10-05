using Libreria.entidades;
using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormulario.Controlador
{
    public partial class frmInformacionBarco : Form
    {
        private Embarcos embarco;

        public frmInformacionBarco()
        {
            this.embarco = new Embarcos();
            InitializeComponent();
        }

        public Embarcos Embarco { get => embarco; set => embarco = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmInformacionBarco_Load(object sender, EventArgs e)
        {
            this.textBoxMatricula.Text = embarco.Matricula;
            this.textBoxNombre.Text = embarco.Nombre;
            this.textBoxCamarotes.Text = embarco.CantidadCamarotes.ToString();
            this.textBoxCasino.Text = embarco.Casino == false ? "Ninguno" : "Si";

            foreach (ViajesProgramados aux in embarco.ListaViajesProgramados)
            {
                this.listBoxProximosViajes.Items.Add(aux.ToString());
            }

            foreach (Esalones aux in embarco.ListaSalones)
            {
                this.listBoxSalones.Items.Add(aux.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
