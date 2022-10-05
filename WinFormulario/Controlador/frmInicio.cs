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
    public partial class frmInicio : frmOpciones
    {
        private BaseDatos baseDatos;
        public frmInicio()
        {
            InitializeComponent();
        }

        public frmInicio(BaseDatos datos) : this()
        {
            this.baseDatos = datos;
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.lblBienvenida.Text = $"Bienvenido {this.baseDatos.UsuarioRegistrado.Nombre} al sistema";
            this.lblFecha.Text = $"La fecha actual es: {DateTime.Today}";
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
