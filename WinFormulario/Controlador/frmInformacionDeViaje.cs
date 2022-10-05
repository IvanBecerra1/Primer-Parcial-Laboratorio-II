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
    public partial class frmInformacionDeViaje : frmOpciones
    {
        private BaseDatos baseDatos;
        private Viajes viajeObtenido;
        private Pasajeros pasajeroObtenido;

        public frmInformacionDeViaje()
        {
            InitializeComponent();
        }
        public frmInformacionDeViaje(BaseDatos datos) : this()
        {
            this.baseDatos = datos;
        }
        private void frmInformacionDeViaje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmSeleccionarViaje seleccionar = new frmSeleccionarViaje();

            seleccionar.ListaDeViajes = baseDatos.ListaDeViajes;
            seleccionar.ShowDialog();

            if (seleccionar.DialogResult == DialogResult.OK)
            {
                this.viajeObtenido =  seleccionar.ViajeSeleccionado;
                cargarTabla();
            }
        }

        public void cargarTabla()
        {
            this.dataGridPasajeros.DataSource = null;
            this.dataGridPasajeros.Rows.Clear();

            foreach (Pasajeros pasajeros in this.viajeObtenido.ListaPasajeros)
            {
                if (pasajeros is null)
                {
                    break;
                }
                int indice = this.dataGridPasajeros.Rows.Add(); // crea un nuevo indice
                this.dataGridPasajeros.Rows[indice].Cells[0].Value = pasajeros.Nombre; // nombre
                this.dataGridPasajeros.Rows[indice].Cells[1].Value = pasajeros.Apellido; // apellido
                this.dataGridPasajeros.Rows[indice].Cells[2].Value = pasajeros.Dni; // documento
                this.dataGridPasajeros.Rows[indice].Cells[3].Value = pasajeros.TipoClase.ToString(); // clase
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null)
            {
                return;
            }
            frmConsultarPasaporte consultarPasaporte = new frmConsultarPasaporte();

            consultarPasaporte.PasajeroSeleccionado = pasajeroObtenido;
            consultarPasaporte.ShowDialog();

            if (consultarPasaporte.DialogResult == DialogResult.OK)
            {

            }
        }

        private void dataGridPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1)
            {
                string idEncontrado = (string) this.dataGridPasajeros.Rows[index].Cells[2].Value;
                this.pasajeroObtenido = BaseDatos.buscarPasajeroPorDocumento(idEncontrado, this.viajeObtenido.ListaPasajeros);
                cargarInformacionPasajero();
            }
        }

        public void cargarInformacionPasajero()
        {
            this.textBoxNombre.Text = this.pasajeroObtenido.Nombre;
            this.textBoxApellido.Text = this.pasajeroObtenido.Apellido;
            this.textBoxEdad.Text = this.pasajeroObtenido.Edad;
            this.textBoxNacionalidad.Text = this.pasajeroObtenido.Nacionalidad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null)
            {
                return;
            }
            formEquipaje consultarEquipaje = new formEquipaje();

            consultarEquipaje.PasajeroSeleccionado = pasajeroObtenido;
            consultarEquipaje.ShowDialog();

            if (consultarEquipaje.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
