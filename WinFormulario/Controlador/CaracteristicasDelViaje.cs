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
    public partial class CaracteristicasDelViaje : Form
    {
        private Viajes viajeSeleccionado;
        public CaracteristicasDelViaje()
        {
            InitializeComponent();
        }

        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }

        private void CaracteristicasDelViaje_Load(object sender, EventArgs e)
        {
            this.textBoxEstado.Text = viajeSeleccionado.EstadoDelViaje.ToString();
            this.textBoxCiudadPartida.Text = viajeSeleccionado.CiudadDePartida;
            this.textBoxFecha.Text = viajeSeleccionado.FechaDeViaje.ToString("dd-MM-yyyy");
            this.textBoxFechaLLegada.Text = viajeSeleccionado.FechaDeLlegada.ToString("dd-MM-yyyy");
            this.textBoxCamarotesPremiun.Text = viajeSeleccionado.CantCamarotesDisponiblesPremiun.ToString();
            this.textBoxCamarotesTurista.Text = viajeSeleccionado.CantCamarotesDisponiblesTurista.ToString();
            this.textBoxCapacidadBodega.Text = viajeSeleccionado.TipoCrucero.CapacidadBodega.ToString();
            this.textBoxCostoPreminu.Text = viajeSeleccionado.CostoViajePremiun.ToString();
            this.textBoxCostoTurista.Text = viajeSeleccionado.CostoViajeTurista.ToString();
            this.textBoxDuracion.Text = viajeSeleccionado.DuracionDelViaje.ToString();
            this.textBoxDestino.Text = viajeSeleccionado.Destino;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
