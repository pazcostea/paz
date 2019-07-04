using System;
namespace _04supermercado
{
    public class Ticket
    {
        //Definicion de variables de la clase ticket
        private string fecha;
        private string nomSuper;
        private int totalCompra;
        private Linea [] linea;

        //Crear el constructor del ticket
        //Constructor por defecto
        public Ticket():this("00/00/00","Nombre"){
        }
        //Constructor pasando datos
        public Ticket (string fecha, string nomSuper)
        {
             this.setFecha(fecha);
             this.setNomSuper(nomSuper);
             linea=new Linea[10];
             for(int i=0;i<this.linea.Length;i++){
                this.linea[i]=new Linea();
            }           
            
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
        public Linea[] getLinea() 
        {
		    return this.linea;
	    }
        public void setLinea(Linea[] linea) 
        {
		    this.linea = linea;
	    }
        public int primeraLineaVacia(){
            for(int i=0;i<this.linea.Length;i++){
                if(this.linea[i].getUnidades()==0){
                    return i;
                }
            }
            return 100;
        }
        public void nuevaLinea(Linea linea){
            int a=this.primeraLineaVacia();
            this.linea[a]=linea;
            totalCompra+=linea.getPrecioTotal();
        }

    }
}