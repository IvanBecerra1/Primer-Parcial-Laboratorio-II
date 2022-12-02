using Libreria.Enumeradores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.entidades
{
    public sealed class BaseDatos
    {
        private List<Cuenta> listaUsuarios;
        private List<Viajes> listaDeViajes;
        private List<Embarcos> listaDeBarcos;
        private List<Pasajeros> listaDePasajeros;
        private Cuenta usuarioRegistrado;

        public BaseDatos()
        {
            this.listaDeBarcos = new List<Embarcos>();
            this.listaDePasajeros = new List<Pasajeros>();
            this.listaDeViajes = new List<Viajes>();
            this.listaUsuarios = new List<Cuenta>();

            cargarBarcos();
            cargarViajes();
            cargarCuentas();
        }

        #region indezadores
        public Embarcos this[Embarcos index]
        {
            get { return this.listaDeBarcos.Find(aux => aux == index); }
        }
        public Cuenta this[Cuenta index]
        {
            get { return this.listaUsuarios.Find(aux => aux == index); }
        }
        public Viajes this[int index]
        {
            get { return this.listaDeViajes.Find(aux => aux.Id == index); }
        }
        public List<Viajes> this[bool index]
        {
            get { return this.listaDeViajes.FindAll(aux => aux.Destino.EsExtraRegional == index); }
        }

        #endregion

        #region propiedades
        public List<Cuenta> ListaUsuarios { get => this.listaUsuarios; set => this.listaUsuarios = value; }
        public List<Viajes> ListaDeViajes { get => this.listaDeViajes; set => this.listaDeViajes = value; }
        public List<Embarcos> ListaDeBarcos { get => this.listaDeBarcos; set => this.listaDeBarcos = value; }
        public List<Pasajeros> ListaDePasajeros { get => this.listaDePasajeros; set => this.listaDePasajeros = value; }
        public Cuenta UsuarioRegistrado { get => this.usuarioRegistrado; set => this.usuarioRegistrado = value; }
        #endregion

        #region metodos de instancia

        /// <summary>
        /// Cargar barcos
        /// </summary>
        public void cargarBarcos()
        {
            Console.WriteLine("--------------BARCOS CARGADOS:---------------");
            Embarcos entidadEmbarcos_1 = new Embarcos("Crucero (mas pequeño)", 1, 3, 540.0, true);
            Embarcos entidadEmbarcos_2 = new Embarcos("Titanic", 100, 3, 990.0, true);
            Embarcos entidadEmbarcos_3 = new Embarcos("Patos INC", 20, 2, 540.0, false);
            Embarcos entidadEmbarcos_4 = new Embarcos("El Ultimo Viaje", 50, 10, 990.0, false);
            Embarcos entidadEmbarcos_5 = new Embarcos("Crucero utn", 15, 2, 540.0, true);
            Embarcos entidadEmbarcos_6 = new Embarcos("Crucero Ivan", 50, 10, 990.0, false);
            Embarcos entidadEmbarcos_7 = new Embarcos("Barcos Ind ARG", 10, 10, 990.0, false);


            entidadEmbarcos_1.ListaSalones.Add(Esalones.Piscina);
            entidadEmbarcos_2.ListaSalones.Add(Esalones.Gimnsaio);

            entidadEmbarcos_3.ListaSalones.Add(Esalones.Gimnsaio);
            entidadEmbarcos_3.ListaSalones.Add(Esalones.Piscina);

            this.listaDeBarcos.Add(entidadEmbarcos_1);
            this.listaDeBarcos.Add(entidadEmbarcos_2);
            this.listaDeBarcos.Add(entidadEmbarcos_3);
            this.listaDeBarcos.Add(entidadEmbarcos_4);
            this.listaDeBarcos.Add(entidadEmbarcos_5);
            this.listaDeBarcos.Add(entidadEmbarcos_6);
            this.listaDeBarcos.Add(entidadEmbarcos_7);
        }

        /// <summary>
        /// Carga los viajes y inserta los pasajeros de forma aleatoria
        /// </summary>
        public void cargarViajes()
        {
            DateTime fechaDeViaje = new DateTime(2022, 12, 1);

            ViajesExtraRegional viajeExtraRegional_1 = new ViajesExtraRegional(EExtraRegional.EE_UU,
                                                     EEstadoViaje.DISPONIBLE, fechaDeViaje, listaDeBarcos[0]);

            fechaDeViaje = new DateTime(2022, 5, 2);
            ViajesExtraRegional viajeExtraRegional_2 = new ViajesExtraRegional(EExtraRegional.BANGKOK,
                                                     EEstadoViaje.DISPONIBLE, fechaDeViaje, listaDeBarcos[1]);
            fechaDeViaje = new DateTime(2022, 5, 1);
            ViajesExtraRegional viajeExtraRegional_3 = new ViajesExtraRegional(EExtraRegional.CUBA,
                                                     EEstadoViaje.DISPONIBLE, fechaDeViaje, listaDeBarcos[2]);

            fechaDeViaje = new DateTime(2022, 7, 14);
            ViajeSudamericanos viajeSudamericano_1 = new ViajeSudamericanos(ESudamericanos.BRASIL,
                                                     EEstadoViaje.DISPONIBLE, fechaDeViaje, listaDeBarcos[3]);
            Random num = new Random();

            string[] pais = {
                "argentina",
                "cuba",
                "peru",
                "chile"
            };


            string[] nombres_apellidos = {
                "Laura",
                "María",
                "Irene",
                "Lucía",
                "Marta",
                "Lidia",
                "Rocío",
                "Elisa",
                "Celia",
                "Sofía",
                "Julia",
                "Blasco",
                "Crespo",
                "Diamante",
                "Dominguito",
                "Donoso",
                "Emeterio",
                "Fadrique",
                "Fernán",
                "Galcerán",
                "García",
                "Garcilaso",
                "Grisóstomo",
                "Gutierre",
                "Indalecio",
                "Lesmes",
                "Librado",
                "Lirio",
                "Lobo",
                "Marín",
                "Medir",
                "Mercedario",
                "Munio",
                "Muño",
                "Reyes",
                "Vasco",
                "Velasco",
                "Adosinda",
                "Águila",
                "Aldonza",
                "Antigua",
                "Buen suceso",
                "Camino",
                "Cañosanto",
                "Capilla",
                "Colombia",
                "Coro",
                "Criptana",
                "Cuadros",
                "Cuesta",
                "Cueva",
                "Cuevas",
                "Cuevasanta",
                "Democracia",
                "Denia",
                "Desamparados",
                "Destierro",
                "Diamantina",
                "Divinidad",
                "Dulcenombre",
                "Encina",
                "Escarlata",
                "Espino",
                "Felicidad",
                "Fina",
                "Florida",
                "Fraternidad",
                "Fuencisla",
                "Fuensanta",
                "Gadea",
                "Gádor",
                "Gozos",
                "Graciosa",
                "Granada",
                "Indalecia",
                "Lágrimas",
                "Libertad",
                "Librada",
                "Liria",
                "Lirios",
                "Llanos",
                "Lluvia",
                "Lucinda",
                "Lulú",
                "Luscinda",
            };

            for (int i = 0; i < 30; i++)
            {
                DateTime fechaVencimiento = new DateTime(num.Next(2021, 2050), num.Next(1, 11), num.Next(1, 25));
                DateTime fechaAlta = new DateTime(num.Next(2015, 2020), num.Next(1, 11), num.Next(1, 25));

                Pasaporte pasaporte = new Pasaporte((num.Next(10000000, 90000000).ToString()),
                                                        pais[num.Next(0, pais.Length)],
                                                        fechaVencimiento,
                                                        fechaAlta);

                ETipoClase tipo = (num.Next(0, 3) != 0 ? ETipoClase.TURISTA : ETipoClase.PREMIUN);

                Pasajeros entidadPasajero_1 = new Pasajeros(tipo, new Equipaje(true, 12, 0),
                                                nombres_apellidos[num.Next(0, nombres_apellidos.Length)],
                                                nombres_apellidos[num.Next(0, nombres_apellidos.Length)],
                                                (num.Next(40000000, 90000000).ToString()),
                                                (num.Next(12, 90).ToString()),
                                                pais[num.Next(0, pais.Length)],
                                                pasaporte);

                entidadPasajero_1.CantidadViajesHechos = num.Next(1, 10);

                listaDePasajeros.Add(entidadPasajero_1);
            }
            for (int i = 0; i < listaDePasajeros.Count; i++)
            {
                Random random = new Random();

                int numero = random.Next(0, 4);

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
                    case 3:
                        viajeExtraRegional_3 += listaDePasajeros[i];
                        break;

                }
            }

            viajeExtraRegional_3.EstadoDelViaje = EEstadoViaje.EN_VIAJE;
            this.listaDeViajes.Add(viajeExtraRegional_1);
            this.listaDeViajes.Add(viajeExtraRegional_2);
            this.listaDeViajes.Add(viajeExtraRegional_3);
            this.listaDeViajes.Add(viajeSudamericano_1);
        }

        /// <summary>
        /// Cargamos las cuentas
        /// </summary>
        public void cargarCuentas()
        {
            Cuenta usuarioA = new Cuenta("ivan","ivan", "admin");
            Cuenta usuarioB = new Cuenta("Neiner","neiner", "admin");
            Cuenta usuarioC = new Cuenta("Felipe","felipe", "admin");
            Cuenta usuarioD = new Cuenta("Facundo", "facundo", "admin");

            this.listaUsuarios.Add(usuarioA);
            this.listaUsuarios.Add(usuarioB);
            this.listaUsuarios.Add(usuarioC);
            this.listaUsuarios.Add(usuarioD);
        }
        #endregion

        #region metodos de clase
        /// <summary>
        /// Verifica si alguna cuenta se encuentra en la lista de cuentas registradas
        /// con un indezador.
        /// </summary>
        /// <param name="cuenta">Devuelve una cuenta</param>
        /// <param name="listaUsuarios">Lista de cuentas cargadas</param>
        /// <returns>Devuelve la cuenta registrada.</returns>
        public static Cuenta iniciarSesion(Cuenta cuenta, BaseDatos baseDatos)
        {
            return baseDatos[cuenta];
        }
        /// <summary>
        /// Busca un viaje por fecha
        /// </summary>
        /// <param name="hasta"></param>
        /// <param name="listaViajes"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Busca un viaje por nombre de barco
        /// y los carga en la lista.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="listaViajes"></param>
        /// <returns></returns>
        public static List<Viajes> buscarPorNombreBarco(string nombre, List<Viajes> listaViajes)
        {
            List<Viajes> listaEncontrada = new List<Viajes>();
            listaEncontrada = listaViajes.FindAll(aux => aux.TipoCrucero == nombre);
            return listaEncontrada;
        }
        /// <summary>
        /// Busca un viaje por destino
        /// </summary>
        /// <param name="destino"></param>
        /// <param name="listaViajes"></param>
        /// <returns>Devuelve los viajes con dicho destino</returns>
        public static List<Viajes> buscarPorDestinos(string destino, List<Viajes> listaViajes)
        {
            List<Viajes> viajesEncontrados = new List<Viajes>();
            viajesEncontrados = listaViajes.FindAll(aux => aux.Destino.Nombre == destino);
            return viajesEncontrados;
        }
        /// <summary>
        /// Busca un pasajero por documento
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="listaPasajeros"></param>
        /// <returns>Devuelve el pasajero encontrado</returns>
        public static Pasajeros buscarPasajeroPorDocumento(string documento, List<Pasajeros> listaPasajeros)
        {
           return listaPasajeros.Find(aux => aux == documento);
        }
        /// <summary>
        /// Busca un pasajero por pasaporte
        /// </summary>
        /// <param name="pasaporte"></param>
        /// <param name="listaPasajeros"></param>
        /// <returns>Devuelve el pasajero encontrado</returns>
        public static Pasajeros buscarPasajeroPorPasaporte(string pasaporte, List<Pasajeros> listaPasajeros)
        {
            return listaPasajeros.Find(aux => aux.Pasaporte.Indentificador == pasaporte);
        }
        /// <summary>
        /// Busca un pasajero por nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="listaPasajeros"></param>
        /// <returns>Devuelve una lista de pasajeros que contengan el mismo nombre</returns>
        public static List<Pasajeros> buscarPasajeroPorNombre(string nombre, List<Pasajeros> listaPasajeros)
        {
            return listaPasajeros.FindAll(aux => aux.Nombre == nombre);
        }
        /// <summary>
        /// Busca pasajero por apellido
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="listaPasajeros"></param>
        /// <returns>Devuelve una lista de pasajeros que contengan el mismo apellido</returns>
        public static List<Pasajeros> buscarPasajeroPorApellido(string apellido, List<Pasajeros> listaPasajeros)
        {
            return listaPasajeros.FindAll(aux => aux.Apellido == apellido);
        }
        /// <summary>
        /// Busca un viaje por su ID, uno en una lista predeterminada y otro con 
        /// un indezador de forma mas general.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="listaViajes"></param>
        /// <returns>Devolvemos el viaje encontrado</returns>
        public static Viajes buscarViajePorId(int id, List<Viajes> listaViajes)
        {
            return listaViajes.Find(aux => aux.Id == id);
        }
        public static Viajes buscarViajePorId(int id, BaseDatos baseDatos)
        {
            return baseDatos[id];
        }
        /// <summary>
        /// Filtrar un viaje dependiendo la preferencia
        /// Si todos los parametros tienen un valor falso, se devolvera la lista por default
        /// Si hay un viaje que tenga una picina, se cargara a la lista de viaje
        /// </summary>
        /// <param name="picina"></param>
        /// <param name="casino"></param>
        /// <param name="gimnasio"></param>
        /// <param name="listaViajes"></param>
        /// <returns>Lista de viajes encontrados</returns>
        public static List<Viajes> Filtrar(bool picina, bool casino, bool gimnasio, List<Viajes> listaViajes)
        {
            if (picina == false && casino == false && gimnasio == false)
            {
                return listaViajes;
            }

            HashSet<Viajes> listaHash = new HashSet<Viajes>();

            foreach (Viajes auxViajes in listaViajes)
            {
                if (picina && auxViajes.TipoCrucero.ListaSalones.Contains(Esalones.Piscina))
                {
                    listaHash.Add(auxViajes);
                }

                if (gimnasio && auxViajes.TipoCrucero.ListaSalones.Contains(Esalones.Gimnsaio))
                {
                    listaHash.Add(auxViajes);
                }

                if (casino && auxViajes.TipoCrucero.Casino)
                {
                    listaHash.Add(auxViajes);
                }
            }

            List<Viajes> nuevaLista = new List<Viajes>(listaHash);
            return nuevaLista;
        }
        /// <summary>
        /// Filtrar pasajero por Turista o Premiun
        /// </summary>
        /// <param name="listaDePasajeros"></param>
        /// <param name="tipo"></param>
        /// <returns>Se devuelve la lista de pasajeros que se haya encontrado</returns>
        public static List<Pasajeros> filtrarPasajeroPorTipo(List<Pasajeros> listaDePasajeros, Enum tipo)
        {
            List<Pasajeros> listaFiltrada = new List<Pasajeros>();
            listaFiltrada = listaDePasajeros.FindAll(aux => aux.TipoClase == (ETipoClase) tipo);
            
            return listaFiltrada;
        }
        /// <summary>
        /// Cargara la facturacion de destino, reuniendo por los viajes que pertenezcan a la lista
        /// </summary>
        /// <param name="listaViajes"></param>
        /// <returns>Se devuelve la lista con los destinos</returns>
        public static List<Destino> consultarFacturacionDestino(List<Viajes> listaViajes)
        {
            List<Destino> listaDestinos = new List<Destino>();
            List<Destino> listaEstadistica = new List<Destino>();
            HashSet<String> dictonarioDestino = new HashSet<String>();


            foreach (Viajes auxViajes in listaViajes)
            {

                dictonarioDestino.Add(auxViajes.Destino.Nombre);
            }

            foreach (var auxDestino in dictonarioDestino)
            {
                Destino destino = new Destino();
                foreach (Viajes auxViajes in listaViajes)
                {
                    if (auxDestino == auxViajes.Destino.Nombre)
                    {
                        destino.Nombre = auxViajes.Destino.Nombre;
                        destino.CantidadConcurrido += auxViajes.Destino.CantidadConcurrido;
                        destino.TotalFacturacion += auxViajes.Destino.TotalFacturacion;
                    }
                }
                listaEstadistica.Add(destino);
            }
            return listaEstadistica;
        }

        /// <summary>
        /// Destino mas elegido, se utiliza por dentro el metodo anterior
        /// debido a que Destinos tiene un atributo propio
        /// pero para separar roles de los metodos se creo uno propio.
        /// </summary>
        /// <param name="listaViajes"></param>
        /// <returns>Lista de destinos</returns>
        public static List<Destino> consultarDestinoMasElegido(List<Viajes> listaViajes)
        {
            List<Destino> listaEstadistica = new List<Destino>();
            listaEstadistica = BaseDatos.consultarFacturacionDestino(listaViajes);
            listaEstadistica.Sort(Destino.OrdenarPorDestinoPedido);

            return listaEstadistica;
        }

        /// <summary>
        /// Reune el total de la facturacion entre todos los viajes existentes en la lista
        /// se dividira por un atributo en particular de la clase Destino
        /// </summary>
        /// <param name="listaViajes"></param>
        /// <param name="ExtraRegional"></param>
        /// <returns></returns>


        public static double consultarTotalFacturacionViajes(BaseDatos baseDatos, bool ExtraRegional)
        {

            double total = 0;

            foreach (Viajes auxViajes in baseDatos[ExtraRegional])
            {       
                total += auxViajes.Destino.TotalFacturacion;
            }
            return total;
        }

        #endregion

    }
}
