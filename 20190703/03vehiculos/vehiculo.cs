namespace _03vehiculos
{
    public class vehiculo
    {
        //Propiedades
        private byte numRuedas;
        private ushort capacidad;
        private string color; //en hexadecimal #RRGGBB        
        private byte numPuertas;
        public static string[] lCombustible = { "Gasolina", "Diesel", "Hibrido", "Eléctrico" };
        private bool esAutomatico;
        private string numBastidor;

        private int velocidadMaxima;

        //Metodos
        private void generarBastidor()
        {
            numBastidor = "123545KJ8542";
        }
        public bool compararBastidor(string bast)
        {
            System.Console.WriteLine("Ok");
            return true;

        }
        public byte getNumRuedas()
        {
            return this.numRuedas;
        }
        public void setNumRuedas(byte numRuedas)
        {
            this.numRuedas = numRuedas;
        }
        public static int volante = 1;
        bool encendido = false;
        public void arrancar()
        {
            encendido = true;
            if (encendido == true)
            {
                System.Console.WriteLine("Brrr");
            }
            else
            {
                System.Console.WriteLine("Apagado");
            }

        }
        public ushort getCapacidad()
        {
            return this.capacidad;
        }
        public void setCapacidad(ushort capacidad)
        {
            this.capacidad = capacidad;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public byte getNumPuertas()
        {
            System.Console.WriteLine(numPuertas);
            return this.numPuertas;
        }
        public void setNumPuertas(byte numPuertas)
        {
            this.numPuertas = numPuertas;
        }
        public bool getEsAutomatico()
        {
            return this.esAutomatico;
        }
        public void isEsAutomatico(bool esAutomatico)
        {
            this.esAutomatico = esAutomatico;
        }
        public int getVelocidadMaxima()
        {
            return this.velocidadMaxima;
        }
        public void setVelocidadMaxima(int velocidadMaxima)
        {
            this.velocidadMaxima = velocidadMaxima;
        }
        //Constructores
        public vehiculo() : this(" azul ", 4)
        {
            System.Console.WriteLine("Vehículo creado" + color + numRuedas);
        }
        public vehiculo(string color, byte numRuedas)
        {
            this.setColor(color);
            this.setNumRuedas(numRuedas);
            System.Console.WriteLine("Vehículo creado " + color + numRuedas);
        }

    }
}