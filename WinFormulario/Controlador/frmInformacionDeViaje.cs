using Libreria.entidades;
using Libreria.Enumeradores;
using Microsoft.VisualBasic;
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

        /// <summary>
        /// Carga la informacion a los textbox de los pasajeros
        /// </summary>
        public void cargarInformacionPasajero()
        {
            this.textBoxNombre.Text = this.pasajeroObtenido;
            this.textBoxApellido.Text = this.pasajeroObtenido.Apellido;
            this.textBoxEdad.Text = ((int)this.pasajeroObtenido).ToString();
            this.textBoxNacionalidad.Text = this.pasajeroObtenido.Nacionalidad;
            this.textBoxCamarote.Text = this.pasajeroObtenido.CamaroteAsignado.ToString();
            this.textBoxNViajes.Text = this.pasajeroObtenido.CantidadViajesHechos.ToString();
            
        }
      
        /// <summary>
        /// Carga los datos de la tabla de que se muestra
        /// </summary>
        /// <param name="listaPasajeros"></param>
        public void cargarTabla(List<Pasajeros> listaPasajeros)
        {
            this.dataGridPasajeros.DataSource = null;
            this.dataGridPasajeros.Rows.Clear();

            foreach (Pasajeros pasajeros in listaPasajeros)
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
                this.dataGridPasajeros.Rows[indice].Cells[4].Value = pasajeros.Pasaporte.Indentificador; // clase
            }
        }

        public bool verificacion(string entrada, Viajes viajeVerificar)
        {
            if (entrada is null || viajeVerificar is null)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Boton para seleccionar el viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSeleccionarViaje seleccionar = new frmSeleccionarViaje();

            seleccionar.ListaDeViajes = baseDatos.ListaDeViajes;
            seleccionar.ShowDialog();

            if (seleccionar.DialogResult == DialogResult.OK)
            {
                this.viajeObtenido = seleccionar.ViajeSeleccionado;
                cargarTabla(this.viajeObtenido.ListaPasajeros);
                this.radioButton6.Checked = true;
            }
        }

        /// <summary>
        /// Boton para buscar pasajero por documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
           string entrada = this.textBoxNDocumento.Text;
           if (verificacion(entrada, this.viajeObtenido))
           {
               return;
           }
           List<Pasajeros> listaFiltrada = new List<Pasajeros>();
           listaFiltrada.Add(BaseDatos.buscarPasajeroPorDocumento(entrada, this.viajeObtenido.ListaPasajeros));
           cargarTabla(listaFiltrada);
           LimpiarTextBox();

        }
        /// <summary>
        /// Boton para buscar pasajero por Pasaporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            string entrada = this.textBoxNPasaporte.Text;
            if (verificacion(entrada, this.viajeObtenido))
            {
                return;
            }
            List<Pasajeros> listaFiltrada = new List<Pasajeros>();
            listaFiltrada.Add(BaseDatos.buscarPasajeroPorPasaporte(entrada, this.viajeObtenido.ListaPasajeros));
            cargarTabla(listaFiltrada);
            LimpiarTextBox();
        }
        /// <summary>
        /// Boton para buscar por nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            string entrada = this.textBoxBuscarPorNombre.Text;
            if (verificacion(entrada, this.viajeObtenido))
            {
                return;
            }
            List<Pasajeros> listaFiltrada = new List<Pasajeros>();
            listaFiltrada = BaseDatos.buscarPasajeroPorNombre(entrada, this.viajeObtenido.ListaPasajeros);
            cargarTabla(listaFiltrada);
            LimpiarTextBox();
        }
        /// <summary>
        /// Boton para buscar por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click_1(object sender, EventArgs e)
        {
            string entrada = this.textBoxBuscarPorApellido.Text;
            if (verificacion(entrada, this.viajeObtenido))
            {
                return;
            }


            List<Pasajeros> listaFiltrada = new List<Pasajeros>();
            listaFiltrada = BaseDatos.buscarPasajeroPorApellido(entrada, this.viajeObtenido.ListaPasajeros);
            cargarTabla(listaFiltrada);
            LimpiarTextBox();
        }



        /// <summary>
        /// Filtro solo Turista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            
         if (verificacion("btn", this.viajeObtenido))
         {
             return;
         }
         List<Pasajeros> listaFiltrada = new List<Pasajeros>();
         listaFiltrada = BaseDatos.filtrarPasajeroPorTipo(this.viajeObtenido.ListaPasajeros, ETipoClase.TURISTA);
         cargarTabla(listaFiltrada);
        }

        /// <summary>
        /// Filtro solo Premiun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if (verificacion("btn", this.viajeObtenido))
           {
               return;
           }
           List<Pasajeros> listaFiltrada = new List<Pasajeros>();
           listaFiltrada = BaseDatos.filtrarPasajeroPorTipo(this.viajeObtenido.ListaPasajeros, ETipoClase.PREMIUN);
           cargarTabla(listaFiltrada);
        }
        
        /// <summary>
        /// Filtro todos los pasajeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (verificacion("btn", this.viajeObtenido))
            {
                return;
            }
            cargarTabla(this.viajeObtenido.ListaPasajeros);
        }
        /// <summary>
        /// Evento para capturar la informacion del pasajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridPasajeros_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1)
            {
                string idEncontrado = (string) this.dataGridPasajeros.Rows[index].Cells[2].Value;
                this.pasajeroObtenido = BaseDatos.buscarPasajeroPorDocumento(idEncontrado, this.viajeObtenido.ListaPasajeros);
                cargarInformacionPasajero();
            }
        }

        private void textBoxNDocumento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
          if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
          {
              e.Handled = true;
          }
          else
          {
              e.Handled = false;
          }
        }

        private void textBoxBuscarPorNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Boton para consultar el equipaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
          if (viajeObtenido is null || pasajeroObtenido is null)
          {
              return;
          }
          formEquipaje consultarEquipaje = new formEquipaje();

          consultarEquipaje.PasajeroSeleccionado = pasajeroObtenido;
          consultarEquipaje.ShowDialog();
        }

        /// <summary>
        /// Boton para consultar pasaporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null || pasajeroObtenido is null)
            {
                return;
            }
            frmConsultarPasaporte consultarPasaporte = new frmConsultarPasaporte();

            consultarPasaporte.PasajeroSeleccionado = pasajeroObtenido;
            consultarPasaporte.ShowDialog();
        }
        
        public void LimpiarTextBox()
        {
            this.textBoxBuscarPorApellido.Clear();
            this.textBoxBuscarPorNombre.Clear();
            this.textBoxNPasaporte.Clear();
            this.textBoxNDocumento.Clear();
        }
        /// <summary>
        /// Mensaje de ayuda/informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* Primero selecciona un viaje con el boton 'Seleccionar viaje'\n* Selecciona en la lista de pasajero, para poder visualizar su informacion\n* Utilice una vez seleccionado el viaje los distintos filtros/Busquedas.\n\nSi no hay pasajeros, es porque el viaje se encuentra vacio.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
