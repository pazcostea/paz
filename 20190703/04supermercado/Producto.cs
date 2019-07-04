namespace _04supermercado
{
    public class Producto
    {
        //Definicion de variables de la clase producto
        private string nombre;
        private int peso;
        private int precioActual;

        //Crear el constructor del producto

        //Constructor por defecto
        public Producto(): this("",0,0)
        {
        }
        //Constructor al que le pasamos los datos
        public Producto (string nombre, int peso, int precioActual)
        {
            this.setNombre(nombre);
            this.setPeso(peso);
            this.setPrecioActual(precioActual);            
        }

        //Creamos los setter y los getter
        public string getNombre() 
        {
		    return this.nombre;
	    }
	    public void setNombre(string nombre) 
        {
		    this.nombre = nombre; 
	    }
        public int getPeso() 
        {
		    return this.peso;
        }
        public void setPeso(int peso) 
        {
		    this.peso = peso;
        }
        public int getPrecioActual() 
        {
		    return this.precioActual;
	    }
        public void setPrecioActual(int precioActual) 
        {
		    this.precioActual = precioActual;
	    } 
    }
}