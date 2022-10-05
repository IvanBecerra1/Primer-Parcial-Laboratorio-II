using Libreria.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public class BaseDatos
    {
        private List<Cuenta> listaUsuarios;
        private List<Viajes> listaDeViajes;
        private List<Embarcos> listaDeBarcos;
        private List<Pasajeros> listaDePasajeros;
        private Cuenta usuarioRegistrado;

        public List<Cuenta> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public List<Viajes> ListaDeViajes { get => listaDeViajes; set => listaDeViajes = value; }

        public List<Embarcos> ListaDeBarcos { get => listaDeBarcos; set => listaDeBarcos = value; }
        public List<Pasajeros> ListaDePasajeros { get => listaDePasajeros; set => listaDePasajeros = value; }

        public Cuenta UsuarioRegistrado { get => usuarioRegistrado; set => usuarioRegistrado = value; }

        public BaseDatos()
        {
            this.listaDeBarcos = new List<Embarcos>();
            this.listaDePasajeros = new List<Pasajeros>();
            this.listaDeViajes = new List<Viajes>();
            this.listaUsuarios = new List<Cuenta>();

            cargarBarcos();
            cargarViajes();
            cargarPasajeros();
            cargarCuentas();
        }

        public void cargarBarcos()
        {
            Console.WriteLine("--------------BARCOS CARGADOS:---------------");
            Embarcos entidadEmbarcos_1 = new Embarcos("Crucero Del oeste", 4, 3, 540.0, true);
            Embarcos entidadEmbarcos_2 = new Embarcos("Titanic", 100, 3, 990.0, false);
            Embarcos entidadEmbarcos_3 = new Embarcos("Patos INC", 20, 2, 540.0, true);
            Embarcos entidadEmbarcos_4 = new Embarcos("El Ultimo Viaje", 50, 10, 990.0, false);
            Embarcos entidadEmbarcos_5 = new Embarcos("Crucero Love", 15, 2, 540.0, true);
            Embarcos entidadEmbarcos_6 = new Embarcos("Crucero Ivan", 50, 10, 990.0, false);
            Embarcos entidadEmbarcos_7 = new Embarcos("Barcos Ind ARG", 10, 10, 990.0, false);

            this.listaDeBarcos.Add(entidadEmbarcos_1);
            this.listaDeBarcos.Add(entidadEmbarcos_2);
            this.listaDeBarcos.Add(entidadEmbarcos_3);
            this.listaDeBarcos.Add(entidadEmbarcos_4);
            this.listaDeBarcos.Add(entidadEmbarcos_5);
            this.listaDeBarcos.Add(entidadEmbarcos_6);
            this.listaDeBarcos.Add(entidadEmbarcos_7);
        }

        public void cargarViajes()
        {
            DateTime fechaDeViaje = new DateTime(2022, 12, 1);

            ViajesExtraRegional viajeExtraRegional_1 = new ViajesExtraRegional(EExtraRegional.EE_UU,
                                                     EEstadoViaje.DISPONIBLE, fechaDeViaje, listaDeBarcos[0]);
            listaDeBarcos[0].Disponible = true;

            fechaDeViaje = new DateTime(2022, 5, 2);
            ViajesExtraRegional viajeExtraRegional_2 = new ViajesExtraRegional(EExtraRegional.BANGKOK,
                                                     EEstadoViaje.LLENO, fechaDeViaje, listaDeBarcos[1]);
            listaDeBarcos[1].Disponible = true;
            fechaDeViaje = new DateTime(2022, 5, 1);
            ViajesExtraRegional viajeExtraRegional_3 = new ViajesExtraRegional(EExtraRegional.CUBA,
                                                     EEstadoViaje.EN_VIAJE, fechaDeViaje, listaDeBarcos[2]);
            listaDeBarcos[2].Disponible = true;

            fechaDeViaje = new DateTime(2022, 7, 14);
            ViajeSudamericanos viajeSudamericano_1 = new ViajeSudamericanos(ESudamericanos.BRASIL,
                                                     EEstadoViaje.EN_VIAJE, fechaDeViaje, listaDeBarcos[3]);
            listaDeBarcos[3].Disponible = true;

            Random num = new Random();
            for (int i = 0; i < 30; i++)
            {
                DateTime fechaVencimiento = new DateTime(num.Next(2021, 2050), num.Next(1, 11), num.Next(1, 25));
                DateTime fechaAlta = new DateTime(num.Next(2015, 2020), num.Next(1, 11), num.Next(1, 25));

                Pasaporte pasaporte = new Pasaporte($"Pais_pasaporte_{i}", $"Nacimiento_pasaporte_{i}", num.Next(1, 10), fechaVencimiento, fechaAlta);

                ETipoClase tipo = (num.Next(0, 3) != 0 ? ETipoClase.TURISTA : ETipoClase.PREMIUN);

                Pasajeros entidadPasajero_1 = new Pasajeros(tipo, new Equipaje(true, 2, 15),
                                                $"Nombre_p{i}",
                                                $"Apellido_p{i}",
                                                $"1111{i}",
                                                $"{i}",
                                                $"Pais_p{i}",
                                                pasaporte);

                listaDePasajeros.Add(entidadPasajero_1);
            }
            for (int i = 0; i < listaDePasajeros.Count; i++)
            {
                Random random = new Random();

                int numero = random.Next(0, 2);

                switch (numero)
                {
                    case 0:
                        viajeExtraRegional_1 += listaDePasajeros[i];
                        break; 
                    case 1:
                        viajeExtraRegional_2 += listaDePasajeros[i];
                        break;
                    case 2:
                        viajeSudamericano_1 += listaDePasajeros[i];
                        break;
                }
            }
            this.listaDeViajes.Add(viajeExtraRegional_1);
            this.listaDeViajes.Add(viajeExtraRegional_2);
            this.listaDeViajes.Add(viajeExtraRegional_3);
            this.listaDeViajes.Add(viajeSudamericano_1);
        }
        public void cargarPasajeros()
        {

        }

        public void asignarViajero()
        {
           
        }
        public void cargarCuentas()
        {
            Cuenta usuarioA = new Cuenta("ivan", DateTime.Now, "ivan", "admin");
            Cuenta usuarioB = new Cuenta("Neiner", DateTime.Now, "neiner", "admin");
            Cuenta usuarioC = new Cuenta("Felipe", DateTime.Now, "felipe", "admin");
            Cuenta usuarioD = new Cuenta("Facundo", DateTime.Now, "facundo", "admin");

            this.listaUsuarios.Add(usuarioA);
            this.listaUsuarios.Add(usuarioB);
            this.listaUsuarios.Add(usuarioC);
            this.listaUsuarios.Add(usuarioD);
        }
        public static Cuenta iniciarSesion(Cuenta cuenta, List<Cuenta> listaUsuarios)
        {
            return listaUsuarios.Find(aux => aux == cuenta);
        }

        public static List<Viajes> buscarPorFecha(DateTime hasta, List<Viajes> listaViajes)
        {
            List<Viajes> viajesEncontrados = new List<Viajes>();

            foreach (Viajes aux in listaViajes)
            {
                if (aux.EstadoDelViaje == EEstadoViaje.NO_DISPONIBLE)
                {
                    continue;
                }

                if (hasta > aux.FechaDeViaje)
                {
                    viajesEncontrados.Add(aux);
                }
            }
            return viajesEncontrados;

        }
        // Metodos logica.

        public static List<Viajes> buscarPorNombreBarco(string nombre, List<Viajes> listaViajes)
        {
            List<Viajes> listaEncontrada = new List<Viajes>();
            listaEncontrada.Add(listaViajes.Find(aux => aux.TipoCrucero == nombre));

            return listaEncontrada;
        }

        public static List<Viajes> buscarPorDestinos(string nombre, List<Viajes> listaViajes)
        {
            List<Viajes> viajesEncontrados = new List<Viajes>();
            viajesEncontrados = listaViajes.FindAll(aux => aux.Destino == nombre);
            return viajesEncontrados;
        }
        public static Pasajeros buscarPasajeroPorDocumento(string documento, List<Pasajeros> listaPasajeros)
        {
            return listaPasajeros.Find(aux => aux == documento);
        }

        public static Viajes buscarViajePorId(int id, List<Viajes> listaViajes)
        {
            return listaViajes.Find(aux => aux.Id == id);
        }

        public static int ordenarPorDestino(Viajes viajeA, Viajes viajeB)
        {
            return (viajeA.Destino.CompareTo(viajeB.Destino)); 
        }
        public static int ordenarPorCrucero(Viajes viajeA, Viajes viajeB)
        {
            return (viajeA.TipoCrucero.Nombre.CompareTo(viajeB.TipoCrucero.Nombre));
        }
    }
}
