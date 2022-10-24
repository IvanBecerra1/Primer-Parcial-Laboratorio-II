using Libreria.entidades;
using System;
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
    public partial class frmPanel : Form
    {
        private BaseDatos baseDeDatos;
        private bool botonSalir;

        public frmPanel()
        {
            baseDeDatos = new BaseDatos();
            InitializeComponent();
        }
        public frmPanel(BaseDatos baseDeDatos) : this()
        {
            this.baseDeDatos = baseDeDatos;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            this.labelTextBienvenida.Text = $"Bienvenido {this.baseDeDatos.UsuarioRegistrado.Nombre} - La fecha es: {DateTime.Today.ToString("dd-MM-yyyy")}";

            frmInicio formularioInicio = new frmInicio(this.baseDeDatos);
            abrirPanel(formularioInicio);
        }

         /// <summary>
         /// Abre el formulario de Lista de viajes
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnListaDeViajes_Click(object sender, EventArgs e)
        {
            frmListaViajes formulario = new frmListaViajes(this.baseDeDatos);
            abrirPanel(formulario);
        }
        /// <summary>
        /// Abre el formulario de Cargar Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCargarCliente formulario = new frmCargarCliente(this.baseDeDatos);
            abrirPanel(formulario);
        }
        /// <summary>
        /// Abre el formulario de informacion de viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmInformacionDeViaje formulario = new frmInformacionDeViaje(this.baseDeDatos);
            abrirPanel(formulario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInicio formulario = new frmInicio(this.baseDeDatos);
            abrirPanel(formulario);
        }
        /// <summary>
        /// Abre el formulario de Estadistcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            frmEstadisticas formulario = new frmEstadisticas(this.baseDeDatos);
            abrirPanel(formulario);
        }
        /// <summary>
        /// Boton de deslogeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult text = MessageBox.Show("Seguro que quieres deslogearte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (text == DialogResult.Yes)
            {
                this.botonSalir = true;
                this.DialogResult = DialogResult.Cancel;
            }
            else
                return;
        }

        /// <summary>
        /// Metodo/Funcion que nos permitira abrir los distintos formularios
        /// lo que hace es pasar los controles del formulario que se le indique al formulario
        /// contenedor
        /// </summary>
        /// <param name="formulario"></param>
        private void abrirPanel(Object formulario)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }

            Form form = formulario as Form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(form);
            this.panelPrincipal.Tag = form;
            form.Show();
        }

        /// <summary>
        /// Evento para preguntar si quiere cerrar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.botonSalir == true)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Seguro que quieres cerrar la aplicacion?",
                "Puedes deslogearte aprentando el boton de deslogeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                e.Cancel = false;
            }
        }
    }
}
