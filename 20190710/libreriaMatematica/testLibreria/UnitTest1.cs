using NUnit.Framework;
using libreriaMatematica;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEsPar()
        {
            //Arrange. Definimos los datos
            int num = 8;
            

            //Act. Utilizamos el método que hemos creado
            bool resultado = EsPar.esPar(num);

            //Asert. La comprobación 
            Assert.IsTrue(resultado, "No es par");
            
        }

        [Test]
        public void TestEsPrimo()
        {
            //Arrange. Definimos los datos
            int num = 25;
           

            //Act. Utilizamos el método que hemos creado
            bool resultado = EsPrimo.esPrimo(num);

            //Asert. La comprobación 
            Assert.IsTrue(resultado, "Error es primo");

        }
    }
}