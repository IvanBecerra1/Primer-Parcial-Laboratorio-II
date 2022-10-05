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

    public partial class formEquipaje : Form
    {
        private Pasajeros pasajeroSeleccionado;

        public formEquipaje()
        {
            InitializeComponent();
        }

        public Pasajeros PasajeroSeleccionado { get => pasajeroSeleccionado; set => pasajeroSeleccionado = value; }

        private void formEquipaje_Load(object sender, EventArgs e)
        {
            this.textBoxBolsoDeMano.Text = this.pasajeroSeleccionado.Equipaje.BolsoDeMano == false ? "No tiene" : "Si tiene";

            double pesoValija1 = this.pasajeroSeleccionado.Equipaje.PesoValija1;
            double pesoValija2 = this.pasajeroSeleccionado.Equipaje.PesoValija2;

            this.textBoxValija1.Text = pesoValija1 == 0 ? "No tiene" : pesoValija1.ToString(); 
            this.textBoxValija2.Text = pesoValija2 == 0 ? "No tiene" : pesoValija2.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
