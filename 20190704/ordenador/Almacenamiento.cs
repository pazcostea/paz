namespace ordenador
{
    public class Almacenamiento
    {
        private double capacidad;
        private double vLectura;
        private double vEscritura;
        
    
        //Constructor por defecto
        public Almacenamiento()
        {
        }

        //Constructor que recibe valores
        public Almacenamiento(double capacidad, double vLectura, double vEscritura)
        {
            this.setCapacidad(capacidad);
            this.setVLectura(vLectura);
            this.setVEscritura(vEscritura);
        }
        //Creamos los setter y getters
        public double getCapacidad()
        {
            return this.capacidad;
        }

        public void setCapacidad(double capacidad)
        {
            this.capacidad = capacidad;
        }
        public double getVLectura()
        {
            return this.vLectura;
        }

        public void setVLectura(double vLectura)
        {
            this.vLectura = vLectura;
        }
        public double getVEscritura()
        {
            return this.vEscritura;
        }

        public void setVEscritura(double vEscritura)
        {
            this.vEscritura = vEscritura;
        }
        public override string ToString()
        {            
            return string.Format("Las caracteristicas del almacenamiento: Capacidad: {0}, Valocidad de lectura: {1}, velocidad de escritura: {2}", this.capacidad, this.vLectura, this.vEscritura);
        }  

    }
 }