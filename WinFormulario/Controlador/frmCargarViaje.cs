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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormulario
{
    public partial class frmCargarViaje : Form
    {

        private BaseDatos baseDatos;
        private Embarcos embarcosRegistrado;
        private List<EExtraRegional> listaViajeExtraRegional;
        private List<ESudamericanos> listaViajeSudamericanos;

        public BaseDatos BaseDatos { get => this.baseDatos; set => this.baseDatos = value; }

        public frmCargarViaje(BaseDatos datos) 
        {
            this.baseDatos = datos;
            this.embarcosRegistrado = new Embarcos();

            this.listaViajeExtraRegional = new List<EExtraRegional>();
            this.listaViajeSudamericanos = new List<ESudamericanos>();
            InitializeComponent();
        }
        /// <summary>
        /// Boton donde se crea un viaje
        /// teniendo todas sus validaciones y condiciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime fecha = this.dateTimeViaje.Value;
            int indexCrucero = this.comboBoxListaCruceros.SelectedIndex;
            int indexLugares = this.comboBoxListaDeLugares.SelectedIndex;
    
            if (validaciones(indexCrucero, indexLugares, fecha) == true)
            {
                return;
            }

         
            if (this.rButtonExtraRegionales.Checked == true)
            {

                EExtraRegional aux = (EExtraRegional)this.comboBoxListaDeLugares.Items[indexLugares];

                ViajesExtraRegional viajeExtraRegional_1 = new ViajesExtraRegional(aux,
                                                         EEstadoViaje.DISPONIBLE, fecha,
                                                         this.embarcosRegistrado);

                this.baseDatos.ListaDeViajes.Add(viajeExtraRegional_1);
            }
            else if (this.rButtonSudamericanos.Checked == true)
            {
                ESudamericanos aux = (ESudamericanos) this.comboBoxListaDeLugares.Items[indexLugares];
                ViajeSudamericanos viajeSudamericano = new ViajeSudamericanos(aux,
                                                         EEstadoViaje.DISPONIBLE, fecha,
                                                         this.embarcosRegistrado);
          

                this.baseDatos.ListaDeViajes.Add(viajeSudamericano);
            }

            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Cargamos los datos necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCargarViaje_Load(object sender, EventArgs e)
        {

            this.lblError.Visible = false;

            this.listaViajeExtraRegional.Add(EExtraRegional.CUBA);
            this.listaViajeExtraRegional.Add(EExtraRegional.LA_HABANA);
            this.listaViajeExtraRegional.Add(EExtraRegional.ITALIA);
            this.listaViajeExtraRegional.Add(EExtraRegional.VENECIA);
            this.listaViajeExtraRegional.Add(EExtraRegional.MEXICO);
            this.listaViajeExtraRegional.Add(EExtraRegional.ACAPULCO);
            this.listaViajeExtraRegional.Add(EExtraRegional.EE_UU);
            this.listaViajeExtraRegional.Add(EExtraRegional.MAIAMI);
            this.listaViajeExtraRegional.Add(EExtraRegional.NEW_YORK);
            this.listaViajeExtraRegional.Add(EExtraRegional.TAILANDIA);
            this.listaViajeExtraRegional.Add(EExtraRegional.BANGKOK);
            this.listaViajeExtraRegional.Add(EExtraRegional.GRECIA);
            this.listaViajeExtraRegional.Add(EExtraRegional.ANTENAS);
            this.listaViajeExtraRegional.Add(EExtraRegional.TAIWAN);
            this.listaViajeExtraRegional.Add(EExtraRegional.TAIPE);

            this.listaViajeSudamericanos.Add(ESudamericanos.ARGENTINA);
            this.listaViajeSudamericanos.Add(ESudamericanos.USHUAIA);
            this.listaViajeSudamericanos.Add(ESudamericanos.PUERTO_MADRYN);
            this.listaViajeSudamericanos.Add(ESudamericanos.BRASIL);
            this.listaViajeSudamericanos.Add(ESudamericanos.REFICE);
            this.listaViajeSudamericanos.Add(ESudamericanos.RIO_DE_JANEIRO);
            this.listaViajeSudamericanos.Add(ESudamericanos.URUGAUY);
            this.listaViajeSudamericanos.Add(ESudamericanos.MONTE_VIDEO);
            this.listaViajeSudamericanos.Add(ESudamericanos.CHILE);
            this.listaViajeSudamericanos.Add(ESudamericanos.SANTIAGO);
            this.listaViajeSudamericanos.Add(ESudamericanos.ISLA_DE_PASCUA);
            this.listaViajeSudamericanos.Add(ESudamericanos.COLOMBIA);
            this.listaViajeSudamericanos.Add(ESudamericanos.CARTAGENA);
            this.listaViajeSudamericanos.Add(ESudamericanos.PERU);
            this.listaViajeSudamericanos.Add(ESudamericanos.LIMA);
            this.listaViajeSudamericanos.Add(ESudamericanos.ECUADOR);
            this.listaViajeSudamericanos.Add(ESudamericanos.ISLA_GALAPAGOS);

            foreach (Embarcos aux in baseDatos.ListaDeBarcos)
            {
                this.comboBoxListaCruceros.Items.Add(aux);
            }
            
        }

        /// <summary>
        /// Cambia el comboBox de lugares/destinos a lista de extra regionales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonExtraRegionales_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rButtonExtraRegionales.Checked == true)
            {
                this.comboBoxListaDeLugares.DataSource = listaViajeExtraRegional;
            }
        }

        /// <summary>
        /// Cambia el combobox de lugares/destinos a lista de sudamericanos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rButtonSudamericanos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rButtonSudamericanos.Checked == true)
            {
                this.comboBoxListaDeLugares.DataSource = listaViajeSudamericanos;
            }
        }
        /// <summary>
        /// Validaciones necesarias para crear un viaje
        /// </summary>
        /// <param name="indexCrucero"></param>
        /// <param name="indexLugares"></param>
        /// <param name="fechaSeleccionado"></param>
        /// <returns></returns>
        private bool validaciones(int indexCrucero, int indexLugares, DateTime fechaSeleccionado)
        {
            if (indexCrucero == -1 || indexLugares == -1)
            {
                manejoDeMensajes("Seleccione un barco/Destino para avanzar");
                return true;
            }
            
            if (fechaSeleccionado < DateTime.Today)
            {
                manejoDeMensajes("Seleccione una fecha valida");
                return true;
            }
            foreach (ViajesProgramados aux in this.embarcosRegistrado.ListaViajesProgramados)
            {
                if ((fechaSeleccionado >= aux.FechaSalida) && (fechaSeleccionado <= aux.FechaLlegada))
                {

                    MessageBox.Show("Seleccione una fecha que no superponga un destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    manejoDeMensajes("Error, verifique bien las fechas");
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Imprime el mensaje dependiendo cuando se lo invoque
        /// </summary>
        /// <param name="texto"></param>
        private void manejoDeMensajes(string texto)
        {
            this.lblError.Visible = true;
            this.lblError.Text = texto;
        }
        /// <summary>
        /// Boton de cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Este evento del combo box nos sirve para obtener el index del crucero
        /// asi cargar los viajes programados que tenga el barco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxListaCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBoxFechas.Items.Clear();

            int indexCrucero = this.comboBoxListaCruceros.SelectedIndex;
            this.embarcosRegistrado = (Embarcos)this.comboBoxListaCruceros.Items[indexCrucero];

            foreach (ViajesProgramados aux in this.embarcosRegistrado.ListaViajesProgramados)
            {
                this.listBoxFechas.Items.Add(aux.ToString());
            }
        }

        /// <summary>
        /// Boton de ayuda/explicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("* Primero seleccione un crucero");
            text.AppendLine("* Para registrar una fecha procure que no este superpuesta con otra fecha");
            text.AppendLine("* Podra seleccionar los distintos tipos de viaje extra regional o sudamericano");
            MessageBox.Show(text.ToString(), "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
