using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraDeString;

namespace TestCalculadoraDeString
{
    [TestClass]
    public class TestCalculadoraString
    {
        /*
        [TestMethod]
        public void ListaInstanciada()
        {
            //Arrange
            Vendedor vendedor = new Vendedor("Leandro");

            //Act

            //Assert
            Assert.IsNotNull(vendedor.Ventas);
        }

        [TestMethod]
        public void AgregaVentas()
        {
            //Arrange
            Vendedor vendedor = new Vendedor("Leandro");
            Biografia biografia = new Biografia("xxx", 2, 79);
            //Act
            bool respuesta = vendedor + biografia;
            //Assert
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void NoAgregaVentas()
        {
            //Arrange
            Vendedor vendedor = new Vendedor("Leandro");
            Biografia biografia = new Biografia("xxx", 0, 79);
            //Act
            bool respuesta = vendedor + biografia;
            //Assert
            Assert.IsFalse(respuesta);
        }
        */
        [TestMethod]
        public void Retorna_0_Cuando_Recibe_Vacio()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add(String.Empty);

            //Assert 
            Assert.AreEqual(0, respuesta);
        }

        [TestMethod]
        public void Retorna_1_Cuando_Recibe_1()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1");

            //Assert 
            Assert.AreEqual(1, respuesta);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Numeros_Separados_Por_Coma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2");

            //Assert 
            Assert.AreEqual(3, respuesta);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Numeros_Cantidad_Indeterminados()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2,10,5,6,7");

            //Assert 
            Assert.AreEqual(31, respuesta);
        }

        [TestMethod]
        [ExpectedException(typeof (FormatException))]
        public void Retorna_FormatException_Cuando_Recibe_Numeros_Y_Letras()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,a");
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Salto_De_Linea_Y_Coma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("1,2\n3");

            //Assert 
            Assert.AreEqual(6, respuesta);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Retorna_Suma_Cuando_Recibe_Barras()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();

            //Act
            int respuesta = calculadora.Add("//;\n1;2");

            //Assert 
            Assert.AreEqual(3, respuesta);
        }

        
    }
}
