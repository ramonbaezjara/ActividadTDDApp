using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
     

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
        

    }
}
