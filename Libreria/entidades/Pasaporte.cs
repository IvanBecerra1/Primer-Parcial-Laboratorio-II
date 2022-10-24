using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class Pasaporte
    {
        private string indentificador;
        private string lugarNacimiento;
        private DateTime fechaVencimiento;
        private DateTime fechaDeAlta;

    
        #region constructores
        public Pasaporte()
        {
        }
        public Pasaporte(string indentificador, string lugarNacimiento, DateTime fechaVencimiento, DateTime fechaDeAlta)
        {
            this.indentificador = indentificador;
            this.lugarNacimiento = lugarNacimiento;
            this.fechaVencimiento = fechaVencimiento;
            this.fechaDeAlta = fechaDeAlta;
        }
        public Pasaporte(string indentificador, DateTime fechaVencimiento, DateTime fechaDeAlta)
        {
            this.indentificador = indentificador;
            this.fechaVencimiento = fechaVencimiento;
            this.fechaDeAlta = fechaDeAlta;
        }
        #endregion

        #region propiedad
        public DateTime FechaVencimiento { get => this.fechaVencimiento; set => this.fechaVencimiento = value; }
        public DateTime FechaDeAlta { get => this.fechaDeAlta; set => this.fechaDeAlta = value; }
        public string Indentificador { get => this.indentificador; set => this.indentificador = value; }

        #endregion

        #region sobrescritura
        public override string ToString()
        {
            return $"numeroPasaporte: {this.indentificador} - lugar Nacimiento: {this.lugarNacimiento}\n"
                + $"fecha de vencimiento: {this.fechaVencimiento} fecha de alta {this.fechaDeAlta}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pasaporte)
            {
                return (this == (Pasaporte)obj);
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region sobrecarga de operadores
        public static bool operator ==(Pasaporte pasaporteA, Pasaporte pasaporteB)
        {
            return (pasaporteA.indentificador == pasaporteB.indentificador);
        }
        public static bool operator !=(Pasaporte pasaporteA, Pasaporte pasaporteB)
        {
            return (pasaporteA == pasaporteB);
        }
        #endregion

    }
}
