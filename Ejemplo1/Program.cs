/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 24/09/2019
 * Hora: 6H30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejemplo1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Demo POO");
			String op="";
			
			Estudiantes per= new Estudiantes();
			Console.WriteLine("Ingresar el documentos: ");
			per.documento = int.Parse(Console.ReadLine());
			Console.Write("ingrear los nombres ");
			per.nombres = Console.ReadLine();
			Console.Write("ingrese los apellidos ");
			per.apellidos = Console.ReadLine();
			Console.WriteLine("ingresar la contraseña");
			per.password=(Console.ReadLine());
			
			Console.Write("ingresar carrera ");
			per.carrera=Console.ReadLine();
			Console.Write("ingresar semestre ");
			per.semestre=int.Parse(Console.ReadLine());
			Console.Write("ingresar promedio ");
			per.promedio=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Hemos creado el objeto");
			Console.WriteLine("El documento es: "+per.documento);
			Console.WriteLine("El nombre es: "+per.nombres);
			Console.WriteLine("El apellido es: "+per.apellidos);
			Console.WriteLine("La carrera es: "+per.carrera);
			Console.WriteLine("El semestre es: "+per.semestre);
			Console.WriteLine("El promedio es: "+per.promedio);
			Console.WriteLine("¿Desea ver la contraseña? (S/N)");
			op=Console.ReadLine();
			if (op=="S" || op=="s"){
				Console.WriteLine("La contraseña ingresada es: "+per.password);
			} else if (op=="N" || op=="n"){
				Console.WriteLine("Su opcion fue: "+op);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}