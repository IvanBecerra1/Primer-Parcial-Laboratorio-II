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
        private string password;
        private string usuario;

        #region constructores
        public Cuenta(string usuario, string password) 
        {
            this.usuario = usuario;
            this.Password = password;
        }
        public Cuenta(string nombre,string usuario, string password) : this(nombre, password)
        {
            this.nombre = usuario;
        }
        #endregion

        #region propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        #endregion

        #region sobrescritura
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
        #endregion

        #region sobrecarga
        public static bool operator ==(Cuenta usuarioA, Cuenta usuarioB)
        {
            return (usuarioA.usuario == usuarioB.usuario) && (usuarioA.password == usuarioB.password);
        }
        public static bool operator !=(Cuenta usuarioA, Cuenta usuarioB)
        {
            return (usuarioA == usuarioB);
        }

        #endregion
    }
}
