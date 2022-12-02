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
using static System.Net.Mime.MediaTypeNames;

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

        #region propiedades
        public List<Viajes> ListaDeViajes { get => listaDeViajes; set => listaDeViajes = value; }
        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }

        #endregion

        /// <summary>
        /// Se carga los datos: barco, destino
        /// se utilizo las coleccion HashSet para evitar los datos duplicados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSeleccionarViaje_Load(object sender, EventArgs e)
        {

            HashSet<String> listaNoAdmieDuplicadosDestinos = new HashSet<String>();
            HashSet<String> listaNoAdmieDuplicadosBarcos = new HashSet<String>();
            foreach (Viajes aux in this.listaDeViajes)
            {
                listaNoAdmieDuplicadosBarcos.Add(aux.TipoCrucero.Nombre);
                listaNoAdmieDuplicadosDestinos.Add(aux.Destino.Nombre);
            }

            List<String> lista = new List<String>(listaNoAdmieDuplicadosDestinos);
            List<String> listaBarcos = new List<String>(listaNoAdmieDuplicadosBarcos);
            this.comboBoxDestinos.DataSource = lista;
            this.comboBoxBarcos.DataSource = listaBarcos;
        }
        /// <summary>
        /// Boton para buscar por tipo de barco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            int index = this.comboBoxBarcos.SelectedIndex;

            if (index == -1)
                return;

            this.viajesEncontrados = BaseDatos.buscarPorNombreBarco((string)this.comboBoxBarcos.Items[index], ListaDeViajes);
            this.viajesEncontrados = BaseDatos.Filtrar(this.checkBoxPicina.Checked, this.checkBoxCasino.Checked, this.checkBoxGimnasio.Checked, this.viajesEncontrados);
            cargarDatos(true);
        }
        /// <summary>
        /// Boton para buscar por fecha a los viajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.viajesEncontrados = BaseDatos.buscarPorFecha(this.dateTimePicker1.Value, this.listaDeViajes);
            this.viajesEncontrados = BaseDatos.Filtrar(this.checkBoxPicina.Checked, this.checkBoxCasino.Checked, this.checkBoxGimnasio.Checked, this.viajesEncontrados);
            cargarDatos(true);
        }

        /// <summary>
        /// Carga la informacion de los viajes en el data grid
        /// </summary>
        /// <param name="limpiarLista"></param>
        private void cargarDatos(bool limpiarLista)
        {

            this.dataGridViajes.DataSource = null;
            this.dataGridViajes.Rows.Clear();

            if (this.viajesEncontrados.Any() == false)
            {
                return;
            }

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
                this.dataGridViajes.Rows[indice].Cells[0].Value = (string) viaje.Destino;
                this.dataGridViajes.Rows[indice].Cells[1].Value = viaje.TipoCrucero.Nombre; // crucero
                this.dataGridViajes.Rows[indice].Cells[2].Value = viaje.FechaDeViaje.ToString("dd-MM-yyyy"); ; // fecha de viaje
                this.dataGridViajes.Rows[indice].Cells[3].Value = viaje.EstadoDelViaje.ToString(); // Estado
                this.dataGridViajes.Rows[indice].Cells[4].Value = viaje.CantidadRestantePremiun + viaje.CantidadRestanteTurista; // Cantidad pasajeros
                this.dataGridViajes.Rows[indice].Cells[5].Value = viaje.Id;


            }
            if (limpiarLista == true)
                this.viajesEncontrados.Clear();
        }
        /// <summary>
        /// Boton para buscar por destinos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxDestinos.SelectedIndex;

            if (index == -1)
                return;

            this.viajesEncontrados = BaseDatos.buscarPorDestinos((string)this.comboBoxDestinos.Items[index], ListaDeViajes);
            cargarDatos(true);
        }
      
        /// <summary>
        /// Evento para capturar el Id del viaje y devolverlo al formulario al cual fue invocado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
           
            if (index > -1)
            {
                int idEncontrado = ((int)this.dataGridViajes.Rows[index].Cells[5].Value);
                this.viajeSeleccionado = BaseDatos.buscarViajePorId(idEncontrado, this.listaDeViajes);
            }
        }

        /// <summary>
        /// Boton para aceptar, se mostrara un mensaje label, si no se selecciono
        /// ningun mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Boton de ayuda /informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("* La opcion busqueda le permitira filtrar/buscar por diferentes parametros");
            text.AppendLine("* La opcion preferencia le permitira filtrar esos viajes");
            text.AppendLine("* Para seleccionar un viaje, clickee en la tabla de viajes, si no aparece un viaje\nes porque no se ha encontrado alguno.");
            MessageBox.Show(text.ToString(), "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
