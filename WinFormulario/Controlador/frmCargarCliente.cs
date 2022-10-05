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
    public partial class frmCargarCliente : frmOpciones
    {
        private BaseDatos baseDatos;
        private Viajes viajeObtenido;

        public frmCargarCliente()
        {
            InitializeComponent();
        }
        public frmCargarCliente(BaseDatos datos) : this()
        {
            this.baseDatos = datos;
        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeleccionarViaje seleccionar = new frmSeleccionarViaje();

            seleccionar.ListaDeViajes = baseDatos.ListaDeViajes;
            seleccionar.ShowDialog();

            if (seleccionar.DialogResult == DialogResult.OK)
            {
                this.viajeObtenido = seleccionar.ViajeSeleccionado;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null)
            {
                return;
            }

            frmInformacionBarco infoBarco = new frmInformacionBarco();
            infoBarco.Embarco = viajeObtenido.TipoCrucero;
            infoBarco.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null)
            {
                return;
            }
            CaracteristicasDelViaje infoViaje = new CaracteristicasDelViaje();

            infoViaje.ViajeSeleccionado = viajeObtenido;
            infoViaje.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (viajeObtenido is null)
            {
                MessageBox.Show("Seleccione un viaje primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmRegistrarCliente registrarCliente = new frmRegistrarCliente();

            registrarCliente.ViajeSeleccionado = viajeObtenido;
            registrarCliente.ShowDialog();

            if (registrarCliente.DialogResult == DialogResult.OK)
            {
                viajeObtenido += registrarCliente.PasajeroCreado;

            }
        }
    }
}
