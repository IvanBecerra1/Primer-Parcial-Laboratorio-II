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
    public partial class frmBoleto : Form
    {

        private double precioPasajeTurista;
        private double precioPasajePremiun;

        private int cantidadPasajeTurista;
        private int cantidadPasajePremiun;

        public frmBoleto()
        {
            InitializeComponent();
        }

        public int CantidadPasajeTurista { get => cantidadPasajeTurista; set => cantidadPasajeTurista = value; }
        public int CantidadPasajePremiun { get => cantidadPasajePremiun; set => cantidadPasajePremiun = value; }
        public double PrecioPasajeTurista { get => precioPasajeTurista; set => precioPasajeTurista = value; }
        public double PrecioPasajePremiun { get => precioPasajePremiun; set => precioPasajePremiun = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }

        private void frmBoleto_Load(object sender, EventArgs e)
        {
            this.lblPrecioPremiun.Text = $"$ {this.precioPasajePremiun}";
            this.lblPrecioTurista.Text = $"$ {this.precioPasajeTurista}";

            this.lblCantidadTurista.Text = $"{this.cantidadPasajeTurista} Personas (turista)";
            this.lblCantidadPremiun.Text = $"{this.cantidadPasajePremiun} Personas (premiun)";

            double costoTurista = this.precioPasajeTurista * this.cantidadPasajeTurista;
            double costoPremiun = this.precioPasajePremiun * this.cantidadPasajePremiun;

            this.lblCostoTurista.Text = $"$ {costoTurista}";
            this.lblCostoPremiun.Text = $"$ {costoPremiun}";

            const double IVA = 0.21;
            const double TASAS = 0.5;
            const double IMPUESTO_PAIS = 0.30;

            double costoImpuestos = ((costoTurista + costoPremiun) * IVA)+ ((costoTurista + costoPremiun) * TASAS) + ((costoTurista + costoPremiun) * IMPUESTO_PAIS);

            double costoFinal = costoTurista + costoPremiun + costoImpuestos;
            this.lblCostoImpuestos.Text = $"$ {costoImpuestos}";
            this.lblCostoFinal.Text = $"$ {costoFinal}";
        }

    }
}
