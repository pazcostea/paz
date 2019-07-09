using System;
using System.IO;
using System.Text;

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

            //Añadir a archivo
            StreamWriter file = new StreamWriter(@"c:\tests\hello.txt", true);
            file.WriteLine("Helloooooooo");
            file.Close();

            //Leer el contenido del archivo
            //Opcion 1
            string text = File.ReadAllText(@"c:\tests\hello.txt");
            Console.WriteLine(text);
            //Opcion 2
            string[] text1 = File.ReadAllLines(@"c:\tests\Hola2.txt");
            for (int i = 0; i < text1.Length; i++)
            {
                Console.Write(i + ". ");
                Console.WriteLine(text1[i]);
            }

            //Leer de un archivo
            //Abrimos un fichero y voy a poder ir leyendo byte a byte para grandes archivos de datos

            StreamReader leerFichero = new StreamReader(@"c:\tests\hello.txt");
            while (leerFichero.Peek() >= 0)
            {
                Console.Write((char)leerFichero.Read());
            }
            leerFichero.Close();


        }
    }
}