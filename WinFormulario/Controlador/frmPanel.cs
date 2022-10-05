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
        /*

        private Cuenta usuarioLogeado;

        public Cuenta UsuarioLogeado { set => usuarioLogeado = value; }
         */
        public frmPanel()
        {
            InitializeComponent();
        }
        public frmPanel(BaseDatos baseDeDatos) : this()
        {
            this.baseDeDatos = baseDeDatos;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           // panelDesactivados();
            //this.panelPrincipal.Visible = true;

            frmInicio formularioInicio = new frmInicio(this.baseDeDatos);
            abrirPanel(formularioInicio);
        }

         
        private void btnListaDeViajes_Click(object sender, EventArgs e)
        {
            frmListaViajes formulario = new frmListaViajes(this.baseDeDatos);
            abrirPanel(formulario);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCargarCliente formulario = new frmCargarCliente(this.baseDeDatos);
            abrirPanel(formulario);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //abrirPanel(new frmInformacionDeViaje());

            frmInformacionDeViaje formulario = new frmInformacionDeViaje(this.baseDeDatos);
            abrirPanel(formulario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInicio formulario = new frmInicio(this.baseDeDatos);
            abrirPanel(formulario);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmEstadisticas formulario = new frmEstadisticas(this.baseDeDatos);
            abrirPanel(formulario);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

    }
}
