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

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            this.textBoxRegionales.Text = Viajes.GananciasRegional.ToString();
            this.textBoxSudamericanos.Text = Viajes.GananciasSudamericanos.ToString();
            
            foreach (Embarcos aux in baseDatos.ListaDeBarcos)
            {
                this.listBoxHorasCruceros.Items.Add(aux.ToString());
            }

            foreach (Pasajeros aux in baseDatos.ListaDePasajeros)
            {
                if (aux.CantidadViajesHechos < 0)
                {
                    continue;
                }
                this.listBoxHorasCruceros.Items.Add(aux.ToString());
            }
        }
    }
}
