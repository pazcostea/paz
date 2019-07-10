using NUnit.Framework;
using Calculadora;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaBasica()
        {
            //Arrange. Definimos los datos
            int a = 2;
            int b = 1;

            //Act. Utilizamos el método que hemos creado
            int suma = Matematicas.Sumar(a, b);

            //Asert. La comprobación 
            Assert.AreEqual(a + b, suma, "No funciona la suma");

            //Matematicas.Sumar(1, 2);
            //Assert.Pass();
        }
    }
}