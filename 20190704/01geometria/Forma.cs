namespace _01geometria
{
    public abstract class Forma
    {
        //Definicion de variables de la clase Forma
        private double perimetro;
        private double area;

        //Constructor por defecto
        public Forma()
        {
        }

        //Constructor que recibe valores
        public Forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
             System.Console.WriteLine("Forma creada");
        }

        //Constructores getter y setter
        public double getPerimetro()
        {
            return this.perimetro;
        }
        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double getArea()
        {
            return this.area;
        }
        public void setArea(double area)
        {
            this.area = area;
        }

        //Sobreescribir metodo de la clase object con override
        public override string ToString()
        {
            return string.Format("Soy una forma de perímero {0} y area {1}", this.perimetro, this.area);
        }

        //Creamos un método dibujar abstracto, que tengamos que implementar en el resto de clases
        public abstract void dibujar();

    }
}