namespace ordenador
{
    public class Procesador
    {
        private int velocidad;
        private string modelo;

        //Constructor por defecto
        public Procesador()
        {
        }
        //Constructor que recibe valores
        public Procesador(int velocidad, string modelo)
        {
           this.setVelocidad(velocidad);
           this.setModelo(modelo);            
        }

        //Declaración de getters y setters
        public int getVelocidad()
        {
            return this.velocidad;
        }
        public void setVelocidad(int velocidad)
        {
            this.velocidad = velocidad;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public override string ToString()
        {            
            return string.Format("Las caracteristicas del procesador: Velocidad: {0} y Modelo: {1}", this.velocidad, this.modelo);
        }   


    
    }
}