# Embarcaciones Patito
## Sobre mi
------------
> Soy Ivan estudiante de la Tecnicatura Universitaria en Programacion en la facultad UTN Regional Avellaneda. En mi experiencia sobre el desarrollo de esta aplicacion, fue un total desafio, primero se puso en juego la creatividad de un diseño, algo que para mi es sumamente complejo, despues las implementaciones de codigo fue lo mas amigable, aun asi no dejo de lado todos los errores que fueron surgiendo. En conclusion se aprendio mucho y se sufrio algo.

## Resumen
------------
Se trata el desarrollo de una aplicacion de ventas de pasajes para una empresa de embarcaciones.
Las opciones que presenta la aplicacion son
- Sistema de Logeo
- [![opcion-Logeo.png](https://i.postimg.cc/9fNbHbpv/opcion-Logeo.png)](https://postimg.cc/KKBBnnCN)
- Sistema de ventas de pasaje
- [![opcion-Cargar-Pasajero.png](https://i.postimg.cc/c4QFtQxn/opcion-Cargar-Pasajero.png)](https://postimg.cc/rKw1vRtV)
- Sistema de creacion de un viaje
- [![opcion-Lista-De-Viajes.png](https://i.postimg.cc/BnpNM41Z/opcion-Lista-De-Viajes.png)](https://postimg.cc/cvKQJqmP)
- Sistema de informacion de cada viaje y pasajero
- [![opcion-Informacion-Pasajero.png](https://i.postimg.cc/GppKfVkF/opcion-Informacion-Pasajero.png)](https://postimg.cc/K1dtk9pj)
- Sistema de estadisticas
- [![opcion-Estadistica.png](https://i.postimg.cc/pLRqfpr1/opcion-Estadistica.png)](https://postimg.cc/gntVdcvv)

------------
## Diagrama de clases UML
[![imagen-Diagrama.png](https://i.postimg.cc/y8gLgt68/imagen-Diagrama.png)](https://postimg.cc/Yv76TXm5)

## Justificacion Tecnica
#### Introduccion

> En esta sesion se utilizo todo tipo de datos necesarios para  el desarrollo del programa, se utilizo setencias de seleccion, setencias de iteracion, condicionales, variables enteros, string double y demas


#### Clases y metodos estaticos
> Utilice metodos estaticos principalmente en la clase BaseDatos.cs la razon porque las utilice fue que esos metodos no estaban involucradas a trabajar con la clase que las contiene.
	Clase estatica: si bien no la utilice, podria haberlo implementado tranquilamente como  una clase que contenga los metodos de clase que tiene BaseDatos.cs

#### Programacion Orientada a objetos
> Se utilizo clases y objetos en todo el desarrollo
	 Abstraccion: implemente la abstraccion en la clase Viajes.cs porque al desarrollar el programa se distingue entre dos tipos de viajes, y ademas su costo en pasaje es diferente, entonces lleve a cabo un metodo abstracto para que atraves de una herencia, implemente dicho metodo y se desarrolle su logica propia para cada clase "Opinion personal: generar una clase abstracta, fue un tanto forzosa para mi implementarlo, por el hecho de que debia cumplir la consigna, creo que no hubiese sido necesario, incluso a principio habia desarrollado toda la entidad sin necesidad de la clase abstracta."
	 Herencia: He utilizado la herencia tanto en Viajes Extra regional, sudamericano, y Pasajeros, el hecho que las haya utilizado fue porque se compartia parte de su estructura y funcionalidades que se iban a utilizar.
	 Polimorfismo: Utilice el polimorfismo para acoplar en el atributo Destino.cs que tien cada entidad Barco digo acoplar, porque tenemos dos tipos de viajes, con destinos diferentes, entonces para que ese destino sea implementado al barco, lleve acabo el polimorfismo para aplicar funcionalidades diferentes.

### Sobrecara: 
> Utilice sobrecarga en los constructores en varias ocaciones, una es en Viajes.CS  la razon de implementacion fue que en algunos casos no era necesario utilizar todos los parametros. Tambien utilice la sobrecarga de operadores y de conversion, los implemente ya que me fue necesario para verificar las "consultas en la base de datos".
### Windows form: 
> La aplicacion esta desarrollada en windows form, utilice varios formularios para desarrollar un mejor perfomance en la interfaz grafica, inclui una herencia de formulario para los distintos paneles que se abririan. Lo puede encontrar como frmOpiones.cs

### Colecciones:
> Utilice colecciones genericas principalmente, por que no he visto la necesidad usar una coleccion no generica. Utilice la coleccion List<T>, y HastSet<T>, esta ultima me ayudo evitar datos duplicados, a principio lo habia generado con un SortList y Dictonary, pero utilizarso no me fue lo mas optimo.

### Encapsulamiento: 
> Utilice el encapsulamiento en los atributos para proteger sus datos, tambien utilice indexadores  en la clase BaseDatos.cs para hacer consultas. Utilice varios enumeradores para acotar los posibles valores y demas.

------------

### Como propuesta de valor agregado 
> * Agregue la funcionalidad de mostrar a los pasajeros solo turista, premiun o todos.
> * Agregue una clase BaseDatos, que se compartira en los distintos formularios para hacer mas dinamico el programa.
> * Implemente un formulario de busqueda de viajes, donde tiene opciones para buscar por crucero, fecha, o destino.
