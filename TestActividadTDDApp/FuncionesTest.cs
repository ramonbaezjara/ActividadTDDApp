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


        [DataTestMethod]
        [DataRow(null, false, DisplayName = "Debería retornar falso si es null")]
        [DataRow("", false, DisplayName = "Debería retornar falso si está vacía")]
        [DataRow("#123456", false, DisplayName = "Debería retornar falso si tiene menos de 8 caracteres")]
        [DataRow("123456789", false, DisplayName = "Debería retornar falso si no incluye '#'")]
        [DataRow("Clave#1234", true, DisplayName = "Debería retornar verdadero si cumple todas las reglas")]
        public void EsContrasenyaValida_DiversosCasos_DevuelveResultadoEsperado(string contrasenya, bool resultadoEsperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(resultadoEsperado, resultado);
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
