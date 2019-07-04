namespace _01geometria
{
    //Cuadrado es una clase que hereda de rectangulo, porque el cuadrado es una forma del rectangulo
    public class Cuadrado : Rectangulo
    {
        //Declaración de la propiedad de la clase
        private double cBase; //--> No es necesario declararla porque ya la tenemos en la clase de la que hereda (rectangulo)

        //Declaración de los métodos
        public Cuadrado(double lado) : base(lado, lado)
        {
            this.setCBase(lado);
            System.Console.WriteLine("Cuadrado creado");
        }

        public double getCBase()
        {
            return this.cBase;
        }

        public void setCBase(double cBase)
        {
            this.cBase = cBase;
        }
        
        public override string ToString()
        {            
            return string.Format(" Soy un cuadrado de base {0}, altura {1}, area {2} y perimetro {3}",
            this.cBase, this.cBase, base.getPerimetro(), base.getArea());
        }

    }
}