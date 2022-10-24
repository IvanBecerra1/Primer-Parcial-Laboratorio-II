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
using Libreria.Enumeradores;

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

        /// <summary>
        /// Abre el formulario para buscar un viaje
        /// Al seleccionarlo se guarda en el atributo 
        /// this.viajeObtenido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Abre el formulario de la informacion del barco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Abre el formulario del Viaje seleccinado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Registra un cliente individual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (verificacion())
                return;

            frmRegistrarCliente registrarCliente = new frmRegistrarCliente();
            frmBoleto costoFinal = new frmBoleto();

            registrarCliente.ViajeSeleccionado = viajeObtenido;
            registrarCliente.AuxCamarotePremiunRestante = viajeObtenido.CantidadRestantePremiun;
            registrarCliente.AuxCamaroteTuristaRestante = viajeObtenido.CantidadRestanteTurista;
            costoFinal.PrecioPasajePremiun = viajeObtenido.CostoViajePremiun;
            costoFinal.PrecioPasajeTurista = viajeObtenido.CostoViajeTurista;
            
            registrarCliente.ShowDialog();

            if (registrarCliente.DialogResult == DialogResult.OK)
            {
                costoFinal.CantidadPasajePremiun = registrarCliente.CantidadPasajePremiun;
                costoFinal.CantidadPasajeTurista = registrarCliente.CantidadPasajeTurista;
                costoFinal.ShowDialog();

                if (costoFinal.DialogResult == DialogResult.OK)
                {
                    viajeObtenido += registrarCliente.PasajeroCreado;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// Registra un cliente de forma grupal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (verificacion())
                return;

            frmRegistrarCliente registrarCliente = new frmRegistrarCliente();
            frmPasajeGrupoFamiliar frmPasajeGrupo = new frmPasajeGrupoFamiliar();
            frmBoleto costoFinal = new frmBoleto();

            registrarCliente.ViajeSeleccionado = viajeObtenido;
            costoFinal.PrecioPasajePremiun = viajeObtenido.CostoViajePremiun;
            costoFinal.PrecioPasajeTurista = viajeObtenido.CostoViajeTurista;

            registrarCliente.AuxCamarotePremiunRestante = viajeObtenido.CantidadRestantePremiun;
            registrarCliente.AuxCamaroteTuristaRestante = viajeObtenido.CantidadRestanteTurista;

            do
            {
                registrarCliente.ShowDialog();

                if (!(registrarCliente.DialogResult == DialogResult.OK))
                {
                    break;
                }

                if (frmPasajeGrupo.ListaPasajeros.Contains(registrarCliente.PasajeroCreado))
                {
                    DialogResult box = MessageBox.Show("Ese pasajero ya esta en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (registrarCliente.PasajeroCreado.TipoClase is ETipoClase.TURISTA)
                        registrarCliente.AuxCamaroteTuristaRestante++;
                    else
                        registrarCliente.AuxCamarotePremiunRestante++;

                    continue;
                }

                frmPasajeGrupo.ListaPasajeros.Add(registrarCliente.PasajeroCreado);
                costoFinal.CantidadPasajePremiun = registrarCliente.CantidadPasajePremiun;
                costoFinal.CantidadPasajeTurista = registrarCliente.CantidadPasajeTurista;

                frmPasajeGrupo.CantidadRestanteCamarotesPreminun = registrarCliente.AuxCamarotePremiunRestante;
                frmPasajeGrupo.CantidadRestanteCamarotesTurista = registrarCliente.AuxCamaroteTuristaRestante;

                frmPasajeGrupo.ShowDialog();
                frmPasajeGrupo.BotonSalir = false;

                if (frmPasajeGrupo.DialogResult == DialogResult.Abort)
                {
                    break;
                }

                if (frmPasajeGrupo.DialogResult == DialogResult.OK)
                {
                    continue;
                }

                costoFinal.ShowDialog();

                if (costoFinal.DialogResult == DialogResult.Cancel)
                    break;

                if (costoFinal.DialogResult == DialogResult.OK)
                {

                    foreach (Pasajeros auxPasajeros in frmPasajeGrupo.ListaPasajeros)
                    {
                        viajeObtenido += auxPasajeros;
                    }

                    this.DialogResult = DialogResult.OK;
                    break;
                }

            } while (true);
        }

        /// <summary>
        /// Verificaciones del viaje
        /// </summary>
        /// <returns></returns>
        public bool verificacion()
        {
            if (viajeObtenido is null
            || viajeObtenido.EstadoDelViaje == EEstadoViaje.LLENO
            || viajeObtenido.EstadoDelViaje == EEstadoViaje.NO_DISPONIBLE
            || viajeObtenido.EstadoDelViaje == EEstadoViaje.EN_VIAJE)
            {
                MessageBox.Show($"Verifique bien al seleccionar un viaje\nCodigo: #{(viajeObtenido is null ? "No se selecciono un viaje" : viajeObtenido.EstadoDelViaje.ToString())}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;

        }
        /// <summary>
        /// Texto de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine("* Primero busca un viaje, consiguiente seleccione/busque un viaje y de al boton aceptar.");
            text.AppendLine("* Podra visualizar distintas informacion del viaje y barco una vez seleccionado el viaje");
            text.AppendLine("* Podra cargar un pasajero / grupo familiar, si el viaje aun esta disponible.");
            MessageBox.Show(text.ToString(), "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

    }
}
