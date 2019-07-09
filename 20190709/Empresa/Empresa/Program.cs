﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


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
    [Serializable]
    class Empresas
    {
        public string nombreEmpresa { get; set; }
        public string anyodefundacion { get; set; }

        public static void Save(Empresas empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:/Prueba/", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }
        public static Empresas Load(string ruta)
        {
            Empresas empresas;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
            empresas = (Empresas)formatter.Deserialize(stream);
            stream.Close(); return empresas;
        }
    }

    class Empleados
    {
        public string nombreEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string fechanacimiento { get; set; }               
        public string fechaContrato { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string nuevaEmpresa = "";
            string nuevoAnyoFundacion = "";
            string nNombre = "";
            string nfechaNac = "";
            string nApellidos = "";
            string nFechacontrato = "";
            Empresas nuevaLineaEmp;

            Dictionary<string, Empresas> dicEmpresas = new Dictionary<string, Empresas>();
            Dictionary<string, Empleados> dicEmpleados = new Dictionary<string, Empleados>();
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
                            Console.WriteLine("Introduzca el año de fundación: ");
                            nuevoAnyoFundacion = Console.ReadLine();
                            dicEmpresas.Add(nuevaEmpresa, new Empresas() { nombreEmpresa = nuevaEmpresa, anyodefundacion = nuevoAnyoFundacion });

                            //var nuevaLinea = nuevaEmpresa + " ; " + nuevoAnyoFundacion + "" + "\n";
                            //File.AppendAllText("C:/Prueba/Empresas.txt", nuevaLinea);
                            //nuevaLineaEmp = new Empresas();
                            //Empresas.Save(nuevaLineaEmp);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Introduzca el nombre del empleado: ");
                            nNombre = Console.ReadLine();
                            Console.WriteLine("Introduzca los apellidos del empleado: ");
                            nApellidos = Console.ReadLine();
                            Console.WriteLine("Introduzca la fecha de nacimiento: ");
                            nfechaNac = Console.ReadLine();
                            Console.WriteLine("Introduzca la fecha de contrato: ");
                            nFechacontrato = Console.ReadLine();
                            dicEmpleados.Add(nNombre, new Empleados() { nombreEmpleado = nNombre, Apellidos = nApellidos, fechanacimiento = nfechaNac, fechaContrato = nFechacontrato });                         
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("*************Listado de empresas*****************");
                            Console.WriteLine("*************************************************");
                            foreach (var listEmpresas in dicEmpresas)
                            {                                
                                Console.WriteLine("Nombre de la empresa: " + listEmpresas.Value.nombreEmpresa);
                                Console.WriteLine("Año de fundación de la empresa: " + listEmpresas.Value.anyodefundacion);
                                Console.WriteLine();
                            }
                            Console.WriteLine();
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
                            Console.Clear();
                            Console.WriteLine("**************************************************");
                            Console.WriteLine("*************Listado de empleados*****************");
                            Console.WriteLine("**************************************************");
                            foreach (var listEmpleados in dicEmpleados)
                            {
                                Console.WriteLine("Nombre del empleado: " + listEmpleados.Value.nombreEmpleado);
                                Console.WriteLine("Apellidos: " + listEmpleados.Value.Apellidos);
                                Console.WriteLine("Fecha de nacimiento: " + listEmpleados.Value.fechanacimiento);
                                Console.WriteLine("Fecha de contrato: " + listEmpleados.Value.fechaContrato);
                                Console.WriteLine();
                            }
                            Console.WriteLine();
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
