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
    public partial class frmEstadisticas : frmOpciones
    {
        private BaseDatos baseDatos;
        public frmEstadisticas()
        {
            InitializeComponent();
        }
        public frmEstadisticas(BaseDatos datos) : this()
        {
            this.baseDatos = datos;
        }
        /// <summary>
        /// Cargamos las estadisticas
        /// se llama a los metodos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            List<Destino> listaDestino = new List<Destino>();
            List<Pasajeros> listaPasajerosTop15 = new List<Pasajeros>();
            this.textBoxRegionales.Text = BaseDatos.consultarTotalFacturacionViajes(this.baseDatos, true).ToString();
            this.textBoxSudamericanos.Text = BaseDatos.consultarTotalFacturacionViajes(this.baseDatos, false).ToString(); ;

            foreach (Embarcos aux in baseDatos.ListaDeBarcos)
            {
                this.listBoxHorasCruceros.Items.Add($"- {aux.Nombre} - Horas totales: {aux.HorasDeViaje}");
            }
          
            listaPasajerosTop15 = this.baseDatos.ListaDePasajeros;
            listaPasajerosTop15.Sort(Pasajeros.ordenarPorCantidadDeViajes);

            foreach (Pasajeros aux in baseDatos.ListaDePasajeros)
            {
                this.listBoxPasajerosFrecuentes.Items.Add($"- {aux.Nombre} - Cantidad de viajes: {aux.CantidadViajesHechos}");
            }

            listaDestino = BaseDatos.consultarFacturacionDestino(baseDatos.ListaDeViajes);
            foreach (Destino auxDestino in listaDestino)
            {
                this.listBoxEstaditicaDestinos.Items.Add($"- {(string) auxDestino} - Total facturado: {auxDestino.TotalFacturacion}");
            }

            listaDestino = BaseDatos.consultarDestinoMasElegido(baseDatos.ListaDeViajes);
            foreach (Destino auxDestino in listaDestino)
            {
                this.listBoxDestinoDemandado.Items.Add($"- {(string) auxDestino} - Veces concurrido: {auxDestino.CantidadConcurrido}");
            }            
        }
    }
}
