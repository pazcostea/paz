using System;
using System.Collections.Generic;
using System.IO;

/*Queremos construir una aplicación que permita almacenar la información relevante sobre empresas y sus empleados:

La clase empresa tendrá como mínimo dos atributos: nombre de tipo String y anyodefundacion de tipo string.
La clase empleado tendrá como mínimo cuatro atributos: nombre de tipo String, apellidos de tipo String, fechanacimiento de tipo 
String y fechaContrato de tipo String El programa mostrará un menu que tendrá las siguientes opciones:
Crear nueva empresa.
Añadir empleado a empresa existente.
Listado de empresas.
Informacion de una empresa en particular.
Crear empleado.
Listado de empleados.
Información de un empleado en particular.
Salir.Se deberá implementar todo la funcionalidad en las clases para que la aplicación sea funciona.*/

namespace Empresa
{
    class Empresas
    {
        public string nombreEmpresa { get; set; }
        public string anyodefundacion { get; set; }
    }

    class Empleados
    {
        public string fechanacimiento { get; set; }
        public string Apellidos { get; set; }
        public string nombreEmpleado { get; set; }
        public string fechaContrato { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string nuevaEmpresa = "";
            string nuevoAnyoFundacion = "";

            Dictionary<string, Empresas> dicEmpresas = new Dictionary<string, Empresas>();
            do
            {
                Console.WriteLine("Indique la acción que quiere realizar: ");
                Console.WriteLine("[1] Crear nueva empresa");
                Console.WriteLine("[2] Añadir empleado a empresa existente");
                Console.WriteLine("[3] Listado de empresas");
                Console.WriteLine("[4] Informacion de una empresa en particular");
                Console.WriteLine("[5] Crear empleado");
                Console.WriteLine("[6] Listado de empleados");
                Console.WriteLine("[7] Información de un empleado en particular");
                Console.WriteLine("[8] Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {                            
                            Console.WriteLine("Introduzca el nombre de la empresa: ");
                            nuevaEmpresa = Console.ReadLine();
                            if (nuevaEmpresa != " ")
                            {
                                Console.WriteLine("Introduzca el año de fundación: ");
                                nuevoAnyoFundacion = Console.ReadLine();
                                dicEmpresas.Add(nuevaEmpresa, new Empresas() { nombreEmpresa = nuevaEmpresa, anyodefundacion = nuevoAnyoFundacion });
                            }
                            var nuevaLinea = nuevaEmpresa + " ; " + nuevoAnyoFundacion + "" + "\n";
                            File.AppendAllText("C:/Users/formacion.GTT/Documents/Paz/paz/20190709/Empresa/Empresas.txt", nuevaLinea);                            
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }

                }
            }
            while (opcion != 8);
            Console.WriteLine("Adios");

        }
    }
}
