using System;
/*
Crea un programa que represente la siguiente realidad, implementando las clases, métodos y propiedades 
que sean necesarios.
Un ticket de la compra tiene: fecha, nombre del supermercado, total compra y lineas del ticket (máximo 10)
Cada linea del ticket contiene, producto, precio por unidad, unidades y precio.
Del producto conocemos nombre, peso y precio
Implementa en el método principal de la aplicación 5 productos, 1 ticket con 5 lineas con diferentes 
cantidades y mostrar el ticket por pantalla
Que se pueda añadir la linea del ticket
 */
namespace _04supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
          //Creamos los objetos de la clase Producto y le asignamos los valores de los atributos (nombre, peso y precio actual)
            Producto pan = new Producto ("pan", 10, 5);
            Producto agua = new Producto ("agua", 2, 3);
            Producto harina = new Producto ("harina", 6, 3);
            Producto leche = new Producto ("leche", 5, 5);
            Producto aceite = new Producto ("aceite", 9, 1);
            
            /*Creamos objetos de la clase Linea y le asignamos los valores de los atributos de la clase (producto y unidades*/            
            Linea linea1=new Linea(pan, 3);
            Linea linea2=new Linea(agua, 5);
            Linea linea3=new Linea(harina, 8);
            Linea linea4=new Linea(leche, 3);
            Linea linea5=new Linea(aceite, 1);
            Linea[] todasLineas={linea1,linea2,linea3,linea4,linea5,linea5,linea5,linea5,linea5,linea5};
            
             /*Creamos el objeto de la clase Ticket, esta clase tiene como atributos la fecha del ticket, el nombre del supermercado*/
            Ticket miTicket=new Ticket("03/07/2019", "supermercadoClase");
            miTicket.nuevaLinea(linea1);
            miTicket.nuevaLinea(linea2);
            miTicket.nuevaLinea(linea3);
            miTicket.nuevaLinea(linea4);
            miTicket.nuevaLinea(linea5);
            
            //Dibujamos la factura
            Console.WriteLine("Fecha: " + miTicket.getFecha());
            Console.WriteLine("Nombre: " + miTicket.getNomSuper());
            Console.WriteLine("Producto   Unidades   Cantidad      Precio");           
            //Mostramos cada una de las lineas de la factura
            foreach(Linea l in miTicket.getLinea()){ 
                if(l.getUnidades()>0){             
                    Console.WriteLine(Convert.ToString(l.getDatosProducto().getNombre().PadRight(12,' ') + " " + Convert.ToString(l.getUnidades()).PadRight(14,' ') + Convert.ToString(l.getPrecioUnidad()).PadRight(12,' ') + Convert.ToString(value: l.getPrecioTotal()).PadRight(4,' ') ));
                }
            }
            Console.WriteLine("Total compra:                          " + miTicket.getTotalCompra());


        }
    }
}
