using Libreria.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Enumeradores;

namespace WinFormulario.Controlador
{
    public partial class frmSeleccionarViaje : Form
    {
        private Viajes viajeSeleccionado;
        private List<Viajes> viajesEncontrados;
        private List<Viajes> listaDeViajes;

        public frmSeleccionarViaje()
        {
            this.listaDeViajes = new List<Viajes>();
            this.viajesEncontrados = new List<Viajes>();
            InitializeComponent();
        }

        private void frmSeleccionarViaje_Load(object sender, EventArgs e)
        {

            HashSet<String> listaNoAdmieDuplicados = new HashSet<String>();
            foreach (Viajes aux in this.listaDeViajes)
            {
                listaNoAdmieDuplicados.Add(aux.Destino);
            }

            List<String> lista = new List<String>(listaNoAdmieDuplicados);
            this.comboBoxDestinos.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombreBarco = this.textBoxBuscador.Text;
            this.viajesEncontrados = BaseDatos.buscarPorNombreBarco(nombreBarco, ListaDeViajes);
            cargarDatos(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.viajesEncontrados = BaseDatos.buscarPorFecha(this.dateTimePicker1.Value, this.listaDeViajes);
            cargarDatos(true);
        }

        private void cargarDatos(bool limpiarLista)
        {
            this.dataGridViajes.DataSource = null;
            this.dataGridViajes.Rows.Clear();

            foreach (Viajes viaje in this.viajesEncontrados)
            {
                if (viaje is null )
                {
                    break;
                }

                if (viaje.EstadoDelViaje == EEstadoViaje.NO_DISPONIBLE)
                {
                    continue;
                }
                int indice = this.dataGridViajes.Rows.Add(); // crea un nuevo indice
                this.dataGridViajes.Rows[indice].Cells[0].Value = viaje.Destino;
                this.dataGridViajes.Rows[indice].Cells[1].Value = viaje.TipoCrucero.Nombre; // crucero
                this.dataGridViajes.Rows[indice].Cells[2].Value = viaje.FechaDeViaje; // fecha de viaje
                this.dataGridViajes.Rows[indice].Cells[3].Value = viaje.EstadoDelViaje.ToString(); // Estado
                this.dataGridViajes.Rows[indice].Cells[4].Value = viaje.CantidadRestantePremiun + viaje.CantidadRestanteTurista; // Cantidad pasajeros
                this.dataGridViajes.Rows[indice].Cells[5].Value = viaje.Id;


            }
            if (limpiarLista == true)
                this.viajesEncontrados.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxDestinos.SelectedIndex;
            if (index == -1)
                return;

            this.viajesEncontrados = BaseDatos.buscarPorDestinos((string)this.comboBoxDestinos.Items[index], ListaDeViajes);
            cargarDatos(true);
        }
        public List<Viajes> ListaDeViajes { get => listaDeViajes; set => listaDeViajes = value; }
        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }

        private void rbOrdenarDes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbOrdenarDes.Checked == true)
            {
                ListaDeViajes.Sort(BaseDatos.ordenarPorDestino);
                cargarDatos(false);
            }
        }
        private void rdOrdenarAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdOrdenarAsc.Checked == true)
            {
                ListaDeViajes.Sort(BaseDatos.ordenarPorCrucero);
                cargarDatos(false);
            }
        }
        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           
            if (index > -1)
            {
                int idEncontrado = ((int)this.dataGridViajes.Rows[index].Cells[5].Value);
                this.viajeSeleccionado = BaseDatos.buscarViajePorId(idEncontrado, this.listaDeViajes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.viajeSeleccionado is not null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.lblMensajeInformativo.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
