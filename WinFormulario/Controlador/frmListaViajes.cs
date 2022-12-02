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
        /// <summary>
        /// Boton para actualizar el data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            cargarListado();
        }

        /// <summary>
        /// Boton para cargar/crear un viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmCargarViaje formulario = new frmCargarViaje(baseDatos);

            formulario.ShowDialog();

            if (formulario.DialogResult == DialogResult.OK)
            {
                this.baseDatos.ListaDeViajes = formulario.BaseDatos.ListaDeViajes;
            }
        }
        /// <summary>
        /// Informacion del DataGrid
        /// </summary>
        private void cargarListado()
        {

            this.dataGridViajes.DataSource = null;
            this.dataGridViajes.Rows.Clear();

            foreach (Viajes aux in baseDatos.ListaDeViajes)
            {

                int indice = this.dataGridViajes.Rows.Add();
                this.dataGridViajes.Rows[indice].Cells[0].Value = aux.Id;
                this.dataGridViajes.Rows[indice].Cells[1].Value = (string) aux.Destino;
                this.dataGridViajes.Rows[indice].Cells[2].Value = aux.TipoCrucero.Nombre; // crucero
                this.dataGridViajes.Rows[indice].Cells[3].Value = aux.FechaDeViaje.ToString("dd-MM-yyyy"); ; // fecha de viaje
                this.dataGridViajes.Rows[indice].Cells[4].Value = aux.EstadoDelViaje.ToString(); // Estado
            }
        }
        /// <summary>
        /// Evento donde obtenemos el Id del viaje 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1)
            {
                int idEncontrado = (int) this.dataGridViajes.Rows[index].Cells[0].Value;
                this.viajeSeleccionado = BaseDatos.buscarViajePorId(idEncontrado, this.baseDatos);
            }
        }
     
        /// <summary>
        /// Boton para ver la informacion del barco
        /// Si no se selecciono ningun barco del datagrid 
        /// no sigue y retornamos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para ver la informacion del Viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton de ayuda/informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("* Podra registrar un viaje, con la opcion Cargar viaje");
            text.AppendLine("* Podra ver una lista de viaje, toque el boton actualizar si su viaje cargado no se encuentre");
            text.AppendLine("* Si quiere ver informacion en concreta, seleccione un viaje en la tabla.");
            MessageBox.Show(text.ToString(), "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
