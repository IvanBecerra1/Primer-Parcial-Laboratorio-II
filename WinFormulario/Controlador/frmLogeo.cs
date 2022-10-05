using Libreria.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormulario.Controlador;

namespace WinFormulario
{
    public partial class frmLogeo : Form
    {
        private BaseDatos baseDatos;
        public frmLogeo()
        {
            this.baseDatos = new BaseDatos();
            InitializeComponent();
        }

        private void frmLogeo_Load(object sender, EventArgs e)
        {
            this.lblMensajeError.Visible = false;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            String ingresoUsuario = this.textUsuario.Text;
            String ingresoPassword = this.textPassword.Text;

            bool logeado = false;
            Cuenta usuario = BaseDatos.iniciarSesion(new Cuenta(ingresoUsuario, ingresoPassword), this.baseDatos.ListaUsuarios);

            if (usuario is not null)
            {
                logeado = true;
                baseDatos.UsuarioRegistrado = usuario;
            }

            if (logeado)
            {
                frmPanel frmPanel = new frmPanel(baseDatos);
                frmPanel.Show();
                this.Hide();
            }
            else
            {
                this.lblMensajeError.Visible = true;
            }
        }
        public void actualizarBarcos()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMensajeError_Click(object sender, EventArgs e)
        {

        }
    }
}
