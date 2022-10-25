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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormulario
{
    public partial class frmPasajeGrupoFamiliar : Form
    {
        private int cantidadRestanteCamarotesTurista;
        private int cantidadRestanteCamarotesPreminun;

        private List<Pasajeros> listaPasajeros;

        private bool botonSalir;



        public frmPasajeGrupoFamiliar()
        {
            this.listaPasajeros = new List<Pasajeros>();

            InitializeComponent();
        }

        #region propiedades
        public int CantidadRestanteCamarotesTurista { get => cantidadRestanteCamarotesTurista; set => cantidadRestanteCamarotesTurista = value; }
        public int CantidadRestanteCamarotesPreminun { get => cantidadRestanteCamarotesPreminun; set => cantidadRestanteCamarotesPreminun = value; }
        public List<Pasajeros> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public bool BotonSalir { get => botonSalir; set => botonSalir = value; }

        #endregion

        /// <summary>
        /// Cargamos la lista de pasajero obtenidos y mostramos los camarotes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPasajeGrupoFamiliar_Load(object sender, EventArgs e)
        {
            this.textBoxCamarotesPremiun.Text = cantidadRestanteCamarotesPreminun.ToString();
            this.textBoxCamarotesTurista.Text = cantidadRestanteCamarotesTurista.ToString();
            this.comboBoxLista.Items.Clear();

            foreach (Pasajeros auxPasajero in this.listaPasajeros)
            {   
                string datos = (auxPasajero.Nombre + " - " + auxPasajero.Apellido + " - " + auxPasajero.TipoClase.ToString() + " - DNI: " + auxPasajero.Dni + " - PASAPORTE: " + auxPasajero.Pasaporte.Indentificador);
                this.comboBoxLista.Items.Add(datos);
            }
        }
        /// <summary>
        /// Boton si quiere añadir otro pasajero mas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.cantidadRestanteCamarotesPreminun == 0 && this.cantidadRestanteCamarotesTurista == 0)
            {
                MessageBox.Show("Ya no hay mas espacio para agregar pasajeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.botonSalir = true;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Boton si ya no quiere añadir pasajeros, pasara al formulario de boleto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.botonSalir = true;
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Evento para cerrar el formulario y que no muestre el form de boleto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPasajeGrupoFamiliar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.botonSalir == true)
            {
                return;
            }
            this.DialogResult = DialogResult.Abort;
            e.Cancel = false;
        }
    }
}
