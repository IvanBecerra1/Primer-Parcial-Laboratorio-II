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
        private Viajes viajeSeleccionado;
        private Pasajeros pasajeroCreado;

        public frmRegistrarCliente()
        {
            this.pasajeroCreado = new Pasajeros();
            InitializeComponent();
        }

        public Viajes ViajeSeleccionado { get => viajeSeleccionado; set => viajeSeleccionado = value; }
        public Pasajeros PasajeroCreado { get => pasajeroCreado; set => pasajeroCreado = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.textBoxCamarotesTuristaDisponibles.Text = viajeSeleccionado.CantidadRestanteTurista.ToString();
            this.textBoxCamarotesPremiunDisponibles.Text = viajeSeleccionado.CantidadRestantePremiun.ToString();

            this.textBoxValija1.Text = "0";
            this.textBoxValija2.Text = "0";
            this.textBoxValija2.Visible = false;
            this.textBoxValija2.Text = "0";

            this.radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxCostoPasaje.Text = viajeSeleccionado.CostoViajeTurista.ToString();

            this.lblValija2.Visible = false;
            this.textBoxValija2.Visible = false;
            this.textBoxValija2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxCostoPasaje.Text = viajeSeleccionado.CostoViajePremiun.ToString();

            this.lblValija2.Visible = true;
            this.textBoxValija2.Visible = true;
            this.textBoxValija2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            Pasajeros encontrado = BaseDatos.buscarPasajeroPorDocumento(documento, viajeSeleccionado.ListaPasajeros);

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


            if (this.viajeSeleccionado.CantidadRestanteTurista == 0 && this.viajeSeleccionado.CantidadRestantePremiun == 0)
            {
                MessageBox.Show("Espacio lleno en los camarotes", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.pasajeroCreado = pasajero;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


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
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
