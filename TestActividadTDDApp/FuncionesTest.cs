using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {

        [TestMethod]
        [DataRow(-10, -1)]  // Caso número negativo
        [DataRow(0, 1)]     // Caso cero
        [DataRow(4, 24)]    // Caso número positivo
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            //Test a implementar

            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, resultado);

        }



        [TestMethod]
        public void EsContrasenyaValida_NullOVacia()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(null));
            Assert.IsFalse(Funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void EsContrasenyaValida_Menor8Caracteres()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("#123456")); // 7 caracteres
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("123456789"));
        }

        [TestMethod]
        public void EsContrasenyaValida_Valida()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("Clave#1234"));
        }




















        /*

        [TestMethod]
        public void CalcularFactorial_NumeroNegativo()
        {
            //Test a implementar
            //Si n < 0 → se debe devolver -1.
            long resultado = Funciones.CalcularFactorial(-10);
            Assert.AreEqual(-1, resultado);
        }



        [TestMethod]
        public void CalcularFactorial_Cero()
        {
            //Test a implementar
            //El factorial de 0 es 1, en este caso devolver 1.
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);

        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo()
        {
            //Test a implementar
            //Para el resto de valores positivos, devolver el cálculo correcto del factorial.
            long resultado = Funciones.CalcularFactorial(4);
            Assert.AreEqual(24, resultado);
        }
        */


    }
}
