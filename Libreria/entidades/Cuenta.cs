using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class Cuenta
    {
        private string nombre;
        private DateTime fecha;

        private string password;
        private string usuario;

        public Cuenta(string usuario, string password)
        {
            this.usuario = usuario;
            this.Password = password;
        }
        public Cuenta(string nombre, DateTime fecha, string usuario, string password) : this(nombre, password)
        {
            this.fecha = fecha;
            this.nombre = usuario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Password { get => password; set => password = value; }
        public string Usuario { get => usuario; set => usuario = value; }


        public override bool Equals(object obj)
        {
            if (obj is Cuenta)
            {
                return (this == ((Cuenta)obj));
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Cuenta usuarioA, Cuenta usuarioB)
        {
            return (usuarioA.usuario == usuarioB.usuario) && (usuarioA.password == usuarioB.password);
        }
        public static bool operator !=(Cuenta usuarioA, Cuenta usuarioB)
        {
            return (usuarioA == usuarioB);
        }

    }
}
