using Libreria.entidades;
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
    public partial class frmConsultarPasaporte : Form
    {
        private Pasajeros pasajeroSeleccionado;

        public frmConsultarPasaporte()
        {
            InitializeComponent();
        }

        public Pasajeros PasajeroSeleccionado { get => pasajeroSeleccionado; set => pasajeroSeleccionado = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmConsultarPasaporte_Load(object sender, EventArgs e)
        {
            this.textBoxIndentificador.Text = pasajeroSeleccionado.Pasaporte.Indentificador;
            this.textBoxCantidadViajes.Text = pasajeroSeleccionado.CantidadViajesHechos.ToString();
            this.textBoxFechaAlta.Text = pasajeroSeleccionado.Pasaporte.FechaDeAlta.ToString("dd-MM-yyyy");
            this.textBoxFechaVencimiento.Text = pasajeroSeleccionado.Pasaporte.FechaVencimiento.ToString("dd-MM-yyyy");
        }
    }
}
