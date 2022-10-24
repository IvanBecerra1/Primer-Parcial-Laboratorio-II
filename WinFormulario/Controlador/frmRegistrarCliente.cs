using Libreria.entidades;
using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormulario.Controlador
{
    public partial class frmRegistrarCliente : Form
    {
        private int cantidadPasajeTurista;
        private int cantidadPasajePremiun;

        private Viajes viajeSeleccionado;
        private Pasajeros pasajeroCreado;

        private int auxCamaroteTuristaRestante;
        private int auxCamarotePremiunRestante;


        public frmRegistrarCliente()
        {
            this.pasajeroCreado = new Pasajeros();

            InitializeComponent();

        }

        #region Propiedades
        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }
        public Pasajeros PasajeroCreado { get => pasajeroCreado; set => pasajeroCreado = value; }
        public int CantidadPasajeTurista { get => cantidadPasajeTurista; set => cantidadPasajeTurista = value; }
        public int CantidadPasajePremiun { get => cantidadPasajePremiun; set => cantidadPasajePremiun = value; }
        public int AuxCamaroteTuristaRestante { get => auxCamaroteTuristaRestante; set => auxCamaroteTuristaRestante = value; }
        public int AuxCamarotePremiunRestante { get => auxCamarotePremiunRestante; set => auxCamarotePremiunRestante = value; }

        #endregion

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
        /// Cargamos y reseteamos los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.textBoxCamarotesTuristaDisponibles.Text = this.auxCamaroteTuristaRestante.ToString();
            this.textBoxCamarotesPremiunDisponibles.Text = this.auxCamarotePremiunRestante.ToString();

            this.textBoxApellido.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxNacionalidad.Text = "";
            this.textBoxIndentificador.Text = "";
            this.textBoxEdad.Clear();
            this.textBoxDocumento.Text = "";
            this.textBoxValija1.Text = "0";
            this.textBoxValija2.Text = "0";

            this.radioButton1.Checked = true;
            this.textBoxCostoPasaje.Text = viajeSeleccionado.CostoViajeTurista.ToString();
            this.textBoxValija2.Visible = false;
        }

        /// <summary>
        /// Radio button de Turista}
        /// Ocultamos las opciones de equipaje premiun y actualizamos el precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            this.textBoxCostoPasaje.Text = viajeSeleccionado.CostoViajeTurista.ToString();

            this.lblValija2.Visible = false;
            this.textBoxValija2.Visible = false;
            this.textBoxValija2.Clear();
        }

        /// <summary>
        /// Radio button de Premiun
        /// Ocultamos las opciones de equipaje turista y actualizamos el precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxCostoPasaje.Text = viajeSeleccionado.CostoViajePremiun.ToString();

            this.lblValija2.Visible = true;
            this.textBoxValija2.Visible = true;
            this.textBoxValija2.Text = "0";
        }

        /// <summary>
        /// Boton de registro de Cliente
        /// Se agrego todas las condiciones que se requiere para
        /// crear un cliente y evitar errores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true && this.auxCamaroteTuristaRestante == 0)
            {
                MessageBox.Show("Espacio lleno en los camarotes turista", "Error", MessageBoxButtons.OK);
                return;
            }

            if (this.radioButton2.Checked == true && this.auxCamarotePremiunRestante == 0)
            {
                MessageBox.Show("Espacio lleno en los camarotes premiun", "Error", MessageBoxButtons.OK);
                return;
            }

            string indentificador = this.textBoxIndentificador.Text;
            DateTime fechaVencimiento = (DateTime)this.fechaVencimiento.Value;
            DateTime fechaAlta = (DateTime)this.fechaValida.Value;

            if (fechaAlta == fechaVencimiento || fechaAlta > fechaVencimiento)
            {
                this.lblErrorDatosPasaporte.Visible = true;
                this.lblErrorDatosPasaporte.Text = "Error de fechas";
                return;
            }
            else if (DateTime.Today > fechaVencimiento)
            {
                this.lblErrorDatosPasaporte.Visible = true;
                this.lblErrorDatosPasaporte.Text = "Pasaporte vencido";
                return;
            }

            Pasaporte pasaportePasajero = new Pasaporte(indentificador, fechaVencimiento, fechaAlta);

            bool valijaDeMano = this.checkBoxBolsoMano.Checked;
            string valor = this.textBoxValija1.Text.ToString();
            string valor2 = this.textBoxValija2.Text.ToString();

            int pesoValija1 = int.Parse(valor);
            int pesoValija2 = (this.lblValija2.Visible == true) ? int.Parse(valor2) : 0;

            if (pesoValija1 > 25 || pesoValija2 > 25 || pesoValija1 < 0 || pesoValija2 < 0)
            {
                this.lblErrorDatosEquipaje.Visible = true;
                this.lblErrorDatosEquipaje.Text = "Error, peso fuera de rango (0-25)";
                return;
            }
            Equipaje equipajePasajero = new Equipaje(valijaDeMano, pesoValija1, pesoValija2);

            ETipoClase tipo = (this.radioButton1.Checked ? ETipoClase.TURISTA : ETipoClase.PREMIUN);

            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            string documento = this.textBoxDocumento.Text;
            string edad = this.textBoxEdad.Text;
            string nacionalidad = this.textBoxNacionalidad.Text;

            if (nombre.Length < 3 || apellido.Length < 3 || documento.Length < 4 || nacionalidad.Length < 3)
            {
                this.lblErrorDatosPersonales.Visible = true;
                this.lblErrorDatosPersonales.Text = "Error ingrese datos validos";
                return;
            }

            Pasajeros encontrado = BaseDatos.buscarPasajeroPorDocumento(documento, this.viajeSeleccionado.ListaPasajeros);

            if (encontrado is not null)
            {
                this.lblErrorDatosPersonales.Visible = true;
                this.lblErrorDatosPersonales.Text = "Error, ya existe ese documento";
                return;
            }

            Pasajeros pasajero = new Pasajeros(tipo, equipajePasajero,
                                            nombre,
                                            apellido,
                                            documento,
                                            edad,
                                            nacionalidad,
                                            pasaportePasajero);


            if (this.viajeSeleccionado.EstadoDelViaje == EEstadoViaje.LLENO)
            {
                MessageBox.Show("Espacio lleno en los camarotes", "Error", MessageBoxButtons.OK);
            }
            else
            {

                if (this.radioButton1.Checked == true)
                {
                    this.cantidadPasajeTurista++;
                    this.auxCamaroteTuristaRestante--;
                }
                else
                {
                    this.cantidadPasajePremiun++;
                    this.auxCamarotePremiunRestante--;
                }
                this.pasajeroCreado = pasajero;
            }
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Evento para no permitir letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Evento para no permitir numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// Boton de ayuda/informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("* Seleccione el tipo de pasajero (turista/premiun)");
            text.AppendLine("* Rellene todos los campos personales");
            text.AppendLine("* El campo pasaporte recuerde seleccionar una fecha valida de alta y vencimiento");
            text.AppendLine("* El campo valijas, no puede ingresar un peso maximo a 25 KG");
            text.AppendLine("* Si no hay camarotes disponibles, no podra registrar al pasajero.");
            MessageBox.Show(text.ToString(), "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
