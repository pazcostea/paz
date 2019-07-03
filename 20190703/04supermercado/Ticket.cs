using System;
namespace _04supermercado
{
    public class Ticket
    {
        //Definicion de variables de la clase ticket
        private string fecha;
        private string nomSuper;
        private int totalCompra;
        private lineas lineasTicket;

        //Crear el constructor del ticket
        public Ticket (string fecha, string nomSuper, int totalCompra, lineas lineasTicket)
        {
             this.setFecha(fecha);
             this.setNomSuper(nomSuper);
             this.totalCompra(totalCompra);
             this.setLineasTicket(lineasTicket);
        }
         //Creamos los setter y los getter
        public string getFecha()
        {
		    return this.fecha;
	    }
	    public void setFecha(string fecha) 
        {
		    this.fecha = fecha;
	    }
        public string getNomSuper() 
        {
		    return this.nomSuper;
	    }
	    public void setNomSuper(string nomSuper) 
        {
		    this.nomSuper = nomSuper;
	    }
        public int getTotalCompra() 
        {
		    return this.totalCompra;
	    }
        public void setTotalCompra(int totalCompra) 
        {
		    this.totalCompra = totalCompra;
	    }
        public lineas getLineasTicket() 
        {
		    return this.lineasTicket;
	    }
        public void setLineasTicket(lineas lineasTicket) 
        {
		    this.lineasTicket = lineasTicket;
	    }

    }
}