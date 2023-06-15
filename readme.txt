8) ¿Que es el IL?
		IL (del ingles Intermediate Language), o Lenguaje Intermedio (LI). Es el lenguaje de nivel medio que se genera cuando 
compilamos codigo fuente en lenguajes dentro del framework de .NET. En nuestro caso generamos IL al compilar codigo de C#. 
Decimos 'nivel medio' ya que el codigo fuente compilado, no se traduce directamente a codigo maquina (que seria 'bajo nivel').
El IL es compatible con cualquier maquina virtual de CLR compatible con .NET. 

9)	Explique con sus palabras VES, CTS y CLS.
	- VES: 	Virtual Execution System o Entorno de Ejecucion Virtual. Es parte la arquitectura que permite la ejecucion de codigo
			en un lenguaje compatible con el framework .NET. En nuestro caso C#. El entorno de ejecucion virtual se encarga de 
			la ejecucion de programas, administrar la memoria, control de excepciones, resolucion de tipos y gestiones de seguridad. 
			Cuando compilamos un programa en C#, generamos el codigo IL mencionado en la pregunta anterior, que es independiente de la 
			plataforma. El VES toma ese codigo IL y lo traduce al llamado "codigo maquina", que es especifico de la plataforma en la 
			que se va a ejecutar.
	- CTS:	Common Type System, o Sistema de Tipos Comun es otro componente de la arquitectura del framework .NET en el que se define 
			como se representan, declaran y usan los diferentes tipos en lenguajes compatibles con .NET. Es decir, establece estándares,
			reglas, como ser: Definicion de tipos (enteros y de referencia), permitir Herencia y Polimorfismo entre los tipos definidos, 
			permitir la conversion entre diferentes tipos, permitir interoperabilidad entre lenguajes .NET, que podran ser manipulados y
			utilizados en el entorno .NET
	- CLS:	Common Language Specification o Especificacion de Lenguaje Comun. Es un conjunto de reglas definidos dentro del entorno .NET
			Reglas que definen que como debe interactuar el codigo de diferentes lenguajes de .NET para que no haya problemas:
			>	Tipos y Miembros: 
					Define como deben declararse y utilizarse metodos, propiedades, campos, etc. 
			>	Convenciones de nomenclatura: 
					Establece identificadores utilizados en el codigo. Uso de mayusculas y minuscula, prefijos y sufijos, y convenciones 
					para garantizar que los identificadores sean consistentes entre lenguajes del framework.
			>	Manejo de Excepciones: 
					Define como lanzar y capturar excepciones en el codigo. Incluye regla para los manejos de excepciones.
			>	Tipos de Datos y Conversiones: 
					Reglas sobre tipos de datos y conversiones entre ellos. Para que los lenguajes compatibles con .NET usen un conjunto 
					comun de tipos de datos. 
	
10)	Explique con sus palabras que es un Assembly, el early y late Binding.
	- Assembly:	Assembly o Ensamblado contiene codigo compilado (en forma de clases, interfaces, estructuras, etc), metadatos y recursos relacionados
				en forma de archivos (por ejemplo un ejecutable .exe), o bibliotecas que contienen uno o mas modulos de codigo (.dll), o un codigo fuente 
				compilado (.cs) que se compilan en tiempo de ejecucion. Todos estos recursos son utilizados por el sistema, y asi
				administrar la carga y la ejecucion del codigo ensamblado. 
	- Early Binding: 	O Enlazamiento Temprano, se refiere a que los enlaces se resuelven en tiempos de compilacion. El compilador puede determinar tipo,
						ubicacion de metodos y propiedades que se utilizan. Se generan instrucciones especificas para llamar a estos metodos y acceder a 
						las propiedades. Por lo que se considera mas seguro y eficiente en cuanto a rendimiento.
						
	- Late Binding: :	O Enlazamiento Tardio, en este caso los enlaces se resuelven en tiempo de ejecucion. No se resuelven metodos, o referencia a propiedades
						de un objeto hasta el momento que se esta ejecutando el programa. La ubicacion del metodo o propiedad se determina durante la ejecucion.
						Se considera mas flexible, pero puede tener un impacto en el rendimiento. 
						
11)	¿Qué es GIT? ¿Es centralizado o distribuido? Ejemplifique al menos 3 comandos de git y explique su funcionamiento.						
		GIT es un sistema de control de versiones utilizado para el desarrollo de software. Se utiliza para rastrear cambios en archivos, colaborar con otros 
desarrolladores y permitir hacer seguimientos a versiones de un proyecto.
		Es Distribuido, cada desarrollador tiene una copia del repositorio en su equipo. Asi los desarrolladores pueden trabajar de forma independiente y realizar 
los cambios en su repositorio sin necesidad de conexion constante con un servidor central. Los cambios se sincronizan o se fusionan a traves de operaciones de push y pull. 

3 Comandos basicos de GIT:
		- git init:	Inicializa un nuevo repositorio en GIT en un directorio. El repositorio incluye directorios ocultos, y los archivos necesarios para el control de versiones.
					Una vez ejecutado el comando, el directorio en cuestion se convierte en un repositorio GIT listo para usar. 
					
		- git add:	Se utiliza para agregar cambios o archivos al "staging area" (preparacion), paso que se realiza antes de impactar los cambios en un archivo (Commit). 
		
		- git commit:	Guarda los cambios realizados en el repositorio. Los cambios registrados son los que estan en "Preparacion" o staging area. Pueden declarase mensajes 
						descriptivos para agregar informacion al commit a traves del comando git commit -m <Mensaje descriptivo>