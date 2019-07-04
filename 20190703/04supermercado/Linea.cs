namespace _04supermercado
{
    public class Linea
    {
        //Definicion de variables de la clase lineas
        private Producto datosProducto;
        private int precioUnidad;
        private int unidades;
        private int precioTotal;

         //Crear el constructor del producto
         //Constructor por defecto
         public Linea():this(new Producto(),0)
         {
         }
         //Constructor al que le pasamos datos
        public Linea (Producto datosProducto, int unidades)
        {
              this.datosProducto = datosProducto;              
              this.unidades = unidades;
              this.precioUnidad=datosProducto.getPrecioActual();
              this.precioTotal=(unidades*precioUnidad);
        }

        //Creamos los setter y los getter
        public Producto getDatosProducto() 
        {
		    return this.datosProducto;
	    }
	    public void setDatosProducto(Producto datosProducto) 
        {
		    this.datosProducto = datosProducto;
	    }
        public int getPrecioUnidad() 
        {
		    return this.precioUnidad;
	    }
	    public void setPrecioUnidad(int precioUnidad) 
        {
		    this.precioUnidad = precioUnidad;
	    }
        public int getUnidades() 
        {
		    return this.unidades;
	    }
	    public void setUnidades(int unidades) 
        {
		    this.unidades = unidades;
	    }
        public int getPrecioTotal() 
        {
		    return this.precioTotal;
	    }
	    public void setPrecioTotal(int precioTotal) 
        {
		    this.precioTotal = precioTotal;
	    }  
    }
}