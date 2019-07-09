using System;
using System.IO;

namespace PruebaArchivos
{
    class Program
    {

        //public static directoriosyficheros ()
        //{

        //}

        static void Main(string[] args)
        {
            //Comprobamos si hay un directorio
            if (Directory.Exists("c:/tests/"))
            {
                Console.WriteLine("EL directorio existe");
            }
            else
            {
                Console.WriteLine("No existe");
            }
            //Comprobamos y si no existe lo crea
            if (!Directory.Exists("c:/tests/"))
            {
                Directory.CreateDirectory("c:/tests/");
            }
            //Listar directorios del directorio
            var directories = Directory.GetDirectories("c:/");
            foreach (string d in directories)
            {
                Console.WriteLine(d);
            }
            //Listar archivos de un directorio
            Console.WriteLine("Mostramos los archivos");
            var files = Directory.GetFiles("c:/");
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

            //Realizar un programa que liste los directorios y los archivos que hay dentro de cada directorio
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("********** Mostramos los Directorios con sus archivos ************");
            Console.WriteLine("******************************************************************");
            var directories1 = Directory.GetDirectories("c:/");
            foreach (string d in directories1)
            {
                Console.WriteLine("***** Directorio  *******");
                Console.WriteLine(d);
                Console.WriteLine("");
                Console.WriteLine("******* Ficheros *******");
                try
                {
                    var files1 = Directory.GetFiles(d);

                    foreach (string f in files1)
                    {
                        Console.WriteLine(f);
                    }
                    Console.WriteLine("");
                }
                catch (DirectoryNotFoundException g) { }
                catch (UnauthorizedAccessException g) { }
                catch (IOException g) { }
            }

            //Realizar un programa que liste los directorios y los archivos que hay dentro de cada directorio con recursividad

            //Escribir una cadena de texto
            File.WriteAllText("c:/tests/hello.txt", "Hola mundo 1");
            File.AppendAllText("c:/tests/hello.txt", "Hola mundo 2");
            File.AppendAllText("c:/tests/hello.txt", "Hola mundo 3");
        }
    }
}