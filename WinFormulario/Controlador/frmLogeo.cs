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
        private bool botonSalir; 
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
        /// <summary>
        /// Boton para acceder al formulario de panel
        /// y verificar si se pudo registrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            String ingresoUsuario = this.textUsuario.Text;
            String ingresoPassword = this.textPassword.Text;

            bool logeado = false;
            Cuenta usuario = BaseDatos.iniciarSesion(new Cuenta(ingresoUsuario, ingresoPassword), this.baseDatos);

            if (usuario is not null)
            {
                logeado = true;
                baseDatos.UsuarioRegistrado = usuario;
            }

            if (logeado)
            {
                this.Hide();
                frmPanel frmPanel = new frmPanel(baseDatos);
                frmPanel.ShowDialog();

                if (frmPanel.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                    this.textPassword.Clear();
                    this.textUsuario.Clear();
                }
                else if (frmPanel.DialogResult == DialogResult.Abort)
                {
                    this.botonSalir = true;

                    Application.Exit();
                }
            }
            else
            {
                this.lblMensajeError.Visible = true;
            }
        }
        /// <summary>
        /// Evento para prevenir el cierre y preguntar si quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogeo_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.botonSalir == true)
            {
                e.Cancel = false;
                return;
            }

            DialogResult dr = MessageBox.Show("¿Desea salir?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
