namespace _01geometria
{
    //Creamos una clase que hereda todas las propiedades y métodos de la clase Forma
    public class Rectangulo : Forma
    {
        //Declaración de las propiedades de la clase
        private double rBase;
        private double rAltura;

        //Declaración del constructor. Le pasamos los valores de las propiedades de la clase rectangulo (base y altura)
        //Luego llamamos a la clase de donde heredamos (forma) con base que tiene perimetro y area y le pasamos el calculo
        //que tiene que hacer
        public Rectangulo(double rBase, double rAltura) : base(2 * rBase + 2 * rAltura, rBase * rAltura)
        {
            this.setRBase(rBase);
            this.setRAltura(rAltura);
            System.Console.WriteLine("Rectángulo creado");
        }
        public double getRBase()
        {
            return this.rBase;
        }
        public void setRBase(double rBase)
        {
            this.rBase = rBase;
        }
        public double getRAltura()
        {
            return this.rAltura;
        }

        public void setRAltura(double rAltura)
        {
            this.rAltura = rAltura;
        }
         //Sobreescribir metodo de la clase object con override
        public override string ToString()
        {
            //Con la primera parte base.ToString() hemos llamado al método ToString de la clase superior
            return base.ToString() + string.Format(" Soy un rectángulo de base {0}, altura {1}, area {2} y perimetro {3}", 
            this.rBase, this.rAltura, base.getPerimetro(), base.getArea());
        }
    }
}