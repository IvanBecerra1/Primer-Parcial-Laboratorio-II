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
        /// <summary>
        /// Carga la informacion del barco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInformacionBarco_Load(object sender, EventArgs e)
        {
            this.textBoxMatricula.Text = embarco.Matricula;
            this.textBoxNombre.Text = embarco.Nombre;


            int cantCamarotesDisponiblesPremiun = (int)Math.Round((embarco.CantidadCamarotes * 0.35) * 4);
            int cantCamarotesDisponiblesTurista = (embarco.CantidadCamarotes * 4) - cantCamarotesDisponiblesPremiun;
            int camarotesTotales = cantCamarotesDisponiblesPremiun + cantCamarotesDisponiblesTurista;
            this.textBoxCamarotes.Text = camarotesTotales.ToString();
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
    }
}
