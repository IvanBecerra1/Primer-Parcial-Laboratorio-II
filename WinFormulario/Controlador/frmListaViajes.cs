using Libreria.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormulario.Controlador
{
    public partial class frmListaViajes : frmOpciones
    {
        private BaseDatos baseDatos;
        private Viajes viajeSeleccionado;

        public BaseDatos BaseDatos { get => baseDatos; set => baseDatos = value; }
        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }

        public frmListaViajes()
        {
            InitializeComponent();
        }

        public frmListaViajes(BaseDatos datos) : this()
        {
            this.baseDatos = datos;
        }
        private void frmListaViajes_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargarViaje formulario = new frmCargarViaje(baseDatos);

         //   formulario.BaseDatos = baseDatos;
            formulario.ShowDialog();

            if (formulario.DialogResult == DialogResult.OK)
            {
                // aca devuelvo y se actualiza todo la base de datos.
                this.baseDatos.ListaDeViajes = formulario.BaseDatos.ListaDeViajes;
            }
        }

        private void cargarListado()
        {

            this.dataGridViajes.DataSource = null;
            this.dataGridViajes.Rows.Clear();

            foreach (Viajes aux in baseDatos.ListaDeViajes)
            {

                int indice = this.dataGridViajes.Rows.Add();
                this.dataGridViajes.Rows[indice].Cells[0].Value = aux.Id;
                this.dataGridViajes.Rows[indice].Cells[1].Value = aux.Destino;
                this.dataGridViajes.Rows[indice].Cells[2].Value = aux.TipoCrucero.Nombre; // crucero
                this.dataGridViajes.Rows[indice].Cells[3].Value = aux.FechaDeViaje; // fecha de viaje
                this.dataGridViajes.Rows[indice].Cells[4].Value = aux.EstadoDelViaje.ToString(); // Estado
            }
        }

        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1)
            {
                int idEncontrado = (int) this.dataGridViajes.Rows[index].Cells[0].Value;
                this.viajeSeleccionado = BaseDatos.buscarViajePorId(idEncontrado, baseDatos.ListaDeViajes);
                //cargarInformacion();
            }
        }
        /*
         
        public void cargarInformacion()
        {
            if (viajeSeleccionado is null)
            {
                return;
            }
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

         */
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (viajeSeleccionado is null)
            {
                return;
            }

            frmInformacionBarco infoBarco = new frmInformacionBarco();
            infoBarco.Embarco = viajeSeleccionado.TipoCrucero;
            infoBarco.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (viajeSeleccionado is null)
            {
                return;
            }

            CaracteristicasDelViaje infoViaje = new CaracteristicasDelViaje();

            infoViaje.ViajeSeleccionado = viajeSeleccionado;
            infoViaje.ShowDialog();
        }
    }
}
