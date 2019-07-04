namespace _01geometria
{
    //Necesito una base, 2 lados y la altura
    //Perimetro = base + lado1 + lado2 
    //area = (base * altura) / 2
    public class Triangulo : Forma
    {
        private double tBase;
        private double tLado1;
        private double tLado2;
        private double tAltura;

        //Declaración del constructor. Le pasamos los valores de las propiedades de la clase triangulo (bases y altura)
        //Luego llamamos a la clase de donde heredamos (Forma) con base que tiene perimetro y area y le pasamos el calculo
        //que tiene que hacer
        public Triangulo(double tBase, double tLado1, double tLado2, double tAltura) 
            :base((tBase + tLado1 + tLado2), ((tBase * tAltura)/2))
        {            
            this.setTBase(tBase);
            this.setTLado1(tLado1);
            this.setTLado2(tLado2);
            this.setTAltura(tAltura);            
            System.Console.WriteLine("Triángulo creado");            
        }

        //Constructores getters y setters
        public double getTBase()
        {
            return this.tBase;
        }

        public void setTBase(double tBase)
        {
            this.tBase = tBase;
        }

        public double getTLado1()
        {
            return this.tLado1;
        }

        public void setTLado1(double tLado1)
        {
            this.tLado1 = tLado1;
        }

        public double getTLado2()
        {
            return this.tLado2;
        }

        public void setTLado2(double tLado2)
        {
            this.tLado2 = tLado2;
        }
        public double getTAltura()
        {
            return this.tAltura;
        }

        public void setTAltura(double tAltura)
        {
            this.tAltura = tAltura;
        }

         public override string ToString()
        {            
            return string.Format(" Soy un triángulo de perimetro {0}, area {1}",base.getPerimetro(), base.getArea());
        }
        public override void dibujar(){
            System.Console.WriteLine("**************Dibujamos un triángulo**************");
        }
    }
}